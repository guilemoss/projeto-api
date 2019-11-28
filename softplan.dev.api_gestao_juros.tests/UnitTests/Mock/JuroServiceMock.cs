using softplan.dev.api_gestao_juros.Common;
using softplan.dev.api_gestao_juros.Services.Interfaces;

namespace softplan.dev.api_gestao_juros.tests.UnitTests.Mock
{
    public class JuroServiceMock : IJuroService
    {
        public decimal CalcularJuro(decimal pValorInicial, int pMeses)
        {
            double taxaJuroAPI = (double)0.01M;
            double taxaJuro = 1.0;

            taxaJuro = (taxaJuro + taxaJuroAPI);
            var valorJuro = pValorInicial * (MathUtils.CalcularPotencia(taxaJuro, pMeses));

            return MathUtils.TruncarValor(valorJuro);
        }
    }
}
