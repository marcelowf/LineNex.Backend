using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using LineNex.Infrastructure.Context;
using LineNex.Infrastructure.CrossCutting.IOCs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using System.Reflection;
using LineNex.Api.ExceptionHendler;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using LineNex.Api.Configurations;
using Serilog;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using Azure.Identity;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

#region Open Telemetry
builder.Services.AddOpenTelemetry()
    .WithMetrics(metrics =>
    {
        metrics
            .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("LineNex-Backend"))
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddRuntimeInstrumentation()
            .AddPrometheusExporter();
    });
#endregion

#region Loggers
var loggerConfig = new LoggerConfiguration()
    .WriteTo.Console();

if (builder.Environment.IsDevelopment()) { loggerConfig.MinimumLevel.Information(); }
else { loggerConfig.MinimumLevel.Warning(); }

// loggerConfig.WriteTo.File("Logs/LineNexLogs-.txt", rollingInterval: RollingInterval.Day);

Log.Logger = loggerConfig.CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(Log.Logger);
#endregion

#region Configuration
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();
#endregion

#region Azure Key Vault
if (builder.Environment.IsEnvironment("Testing") || builder.Environment.IsEnvironment("Development"))
{
    builder.Configuration.AddAzureKeyVault(new Uri("https://kv-linenex-dev.vault.azure.net/"), new DefaultAzureCredential());
}
else
{
    builder.Configuration.AddAzureKeyVault(new Uri("https://kv-linenex-prd.vault.azure.net/"), new DefaultAzureCredential());
}
#endregion

#region Health Checks
builder.Services.AddHealthChecks()
    .AddSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
#endregion

#region Dependency Injection
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new ModuleIOC());
});
#endregion

#region Identity
builder.Services.AddIdentityCore<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>(TokenOptions.DefaultProvider)
    .AddEntityFrameworkStores<SqlContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
});
#endregion

#region Authentication
var jwtKey = builder.Configuration["JwtBearer:SecretKey"];
var jwtIssuer = builder.Configuration["JwtBearer:TokenIssuer"];
var jwtAudience = builder.Configuration["JwtBearer:TokenAudience"];

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtAudience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
        };
    });
#endregion

#region Authorization
builder.Services.AddAuthorization();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Permission.Reader", policy =>
        policy.RequireClaim("permission", "RDR")
    );

    options.AddPolicy("Permission.Create", policy =>
        policy.RequireClaim("permission", "CRT")
    );

    options.AddPolicy("Permission.Update", policy =>
        policy.RequireClaim("permission", "UPD")
    );

    options.AddPolicy("Permission.Delete", policy =>
        policy.RequireClaim("permission", "DEL")
    );
});

Console.WriteLine("🔑 Authentication and Authorization: Succeeded ✅");
#endregion

#region CORS
builder.Services.AddCors(options => options.AddPolicy("MyPolicy", corsBuilder =>
{
    corsBuilder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
        .WithExposedHeaders("X-Pagination")
        .WithHeaders("authorization", "accept", "content-type", "origin", "X-Pagination", "OPTIONS");
}));
#endregion

#region Controllers
builder.Services.AddControllers()
    .AddJsonOptions(opts =>
        opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
#endregion

#region Versioning
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.ReportApiVersions = true;
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "LineNex 'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});
#endregion

#region Swagger
builder.Services.AddSwaggerGen(gen =>
{
    gen.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Description = "Enter the JWT token in the format: {token}"
    });

    gen.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    gen.IncludeXmlComments(xmlPath);

    gen.DescribeAllParametersInCamelCase();
});

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
Console.WriteLine("🌐 Swagger Configuration:            Succeeded ✅");
#endregion

#region Database
builder.Services.AddDbContext<SqlContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                     b => b.MigrationsAssembly("LineNex.Infrastructure")));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

try
{
    using var connection = new SqlConnection(connectionString);
    await connection.OpenAsync();
    Console.WriteLine("🔒 Database Connection:              Succeeded ✅");
}
catch (Exception ex)
{
    Console.WriteLine($"🔒 Database Connection:              Failed    ❌ => {ex.Message}");
}
#endregion

#region Middleware
var app = builder.Build();

// app.Urls.Add("http://0.0.0.0:4000");

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

var versionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    foreach (var description in versionDescriptionProvider.ApiVersionDescriptions)
    {
        options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
    }
});

app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = async (context, report) =>
    {
        context.Response.ContentType = "application/json";

        var result = JsonSerializer.Serialize(new
        {
            status = report.Status.ToString(),
            checks = report.Entries.Select(e => new
            {
                name = e.Key,
                status = e.Value.Status.ToString(),
                description = e.Value.Description
            })
        });

        await context.Response.WriteAsync(result);
    }
});

app.UseOpenTelemetryPrometheusScrapingEndpoint();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseMiddleware<ExceptionHendlerMiddleware>();

app.UseCors("MyPolicy");
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
Console.WriteLine("🚀 Startup Project:                  Succeeded ✅");
app.Run();
#endregion

#region Partials
public partial class Program { }
#endregion