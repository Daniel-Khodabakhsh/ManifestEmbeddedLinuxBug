using System.Net.Http;
using System.Threading.Tasks;

using Xunit;

namespace ManifestEmbeddedLinuxBug
{

    public class PageTests
    {
        private readonly HttpClient httpClient = new CustomWebApplicationFactory().CreateClient();

        [Fact]
        public async Task Test_embedded_resource_at_root()
        {
            var response = await httpClient.GetAsync("/assets-at-root/ResourcesToEmbed/script.js").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Assert.Equal("console.log(\"test\");", responseBody);
        }

        [Fact]
        public async Task Test_embedded_resource_different_from_root()
        {
            var response = await httpClient.GetAsync("/assets-with-different-root/ResourcesToEmbedWithLogicalName/script2.js").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Assert.Equal("console.log(\"test2\");", responseBody);
        }
    }
}
