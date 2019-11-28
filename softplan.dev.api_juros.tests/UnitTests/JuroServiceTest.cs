using Microsoft.VisualStudio.TestTools.UnitTesting;
using softplan.dev.api_juros.Services;
using softplan.dev.api_juros.Services.Interfaces;

namespace softplan.dev.api_juros.tests.UnitTests
{
    [TestClass]
    public class JuroServiceTest
    {
        private readonly IJuroService _juroService;
        public JuroServiceTest()
        {
            _juroService = new JuroService();
        }

        [TestMethod]
        public void Juro_DeveRetornarObjetoJuroComTaxaFixa() 
        {
            var objJuro = _juroService.ObterJuro();
            
            Assert.AreEqual(0.01M, objJuro.Taxa);
        }

        [TestMethod]
        public void TaxaJuro_DeveRetornarOValoFixo()
        {
            var taxaJuro = _juroService.ObterTaxaJuro();

            Assert.AreEqual(0.01M, taxaJuro);
        }

    }
}
