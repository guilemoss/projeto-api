using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Xunit;

namespace softplan.dev.api_gestao_juros.tests.IntegrationTests
{
    public class BasicTests
    : IClassFixture<WebApplicationFactory<api_gestao_juros.Startup>>
    {
        private readonly WebApplicationFactory<api_gestao_juros.Startup> _factory;

        public BasicTests(WebApplicationFactory<api_gestao_juros.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/showmethecode")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            #region Arrange
            var client = _factory.CreateClient();
            #endregion

            #region Act
            var response = await client.GetAsync(url);
            #endregion

            #region Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.AreEqual("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString(), true);
            #endregion
        }
    }

}
