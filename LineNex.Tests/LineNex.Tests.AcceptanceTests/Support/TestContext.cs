using LineNex.Tests.AcceptanceTests.Drivers;

namespace LineNex.Tests.AcceptanceTests.Support
{
    public class TestContext
    {
        public HttpClient Client { get; }
        public HttpResponseMessage LatestResponse { get; set; }
        public string RefreshToken { get; set; } 

        public TestContext ()
        {
            var factory = new ApiDriver();
            Client = factory.Client;
        }
    }
}
