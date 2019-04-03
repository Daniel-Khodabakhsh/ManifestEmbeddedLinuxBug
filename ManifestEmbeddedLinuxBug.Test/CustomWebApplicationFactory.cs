using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace ManifestEmbeddedLinuxBug
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override IWebHostBuilder CreateWebHostBuilder() => WebHost.CreateDefaultBuilder().UseStartup<Startup>();
    }
}
