using Microsoft.VisualStudio.TestTools.UnitTesting;
using softplan.dev.api_gestao_juros.Services.Interfaces;
using softplan.dev.api_gestao_juros.tests.UnitTests.Mock;

namespace softplan.dev.api_gestao_juros.tests.UnitTests
{
    [TestClass]
    public class JuroServiceTest
    {
        private readonly IJuroService _juroService;
        public JuroServiceTest()
        {
            _juroService = new JuroServiceMock();
        }

        [TestMethod]
        public void Juro_DeveRetornarValorJuroCalculado()
        {
            decimal valorInicial = 100M;
            int meses = 5;
            
            var juroCalculado = _juroService.CalcularJuro(valorInicial, meses);

            Assert.AreEqual(105.10M, juroCalculado);
        }
    }
}
