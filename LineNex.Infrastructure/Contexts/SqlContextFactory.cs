using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace LineNex.Infrastructure.Context
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("A connection string 'DefaultConnection' não foi encontrada nas variáveis de ambiente.");
            }

            var optionsBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SqlContext(optionsBuilder.Options);
        }
    }
}
