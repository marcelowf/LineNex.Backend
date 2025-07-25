using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;

namespace LineNex.Tests.AcceptanceTests.Drivers
{
    internal class ApiDriver
    {
        public HttpClient Client { get; }

        public ApiDriver()
        {
            var factory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    builder.UseSetting("environment", "Testing");
                });

            Client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                BaseAddress = new Uri("http://localhost:4000")
            });
        }
    }
}
