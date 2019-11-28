using softplan.dev.api_gestao_juros.Common;
using softplan.dev.api_gestao_juros.External.APIJuros;
using softplan.dev.api_gestao_juros.Services.Interfaces;

namespace softplan.dev.api_gestao_juros.Services
{
    public class JuroService : IJuroService
    {
        private double ObterTaxaJuroApi() {
            var apiJuro = new JurosAPIClient("");
            return (double)apiJuro.Query().TaxaJuro;
        }

        public decimal CalcularJuro(decimal pValorInicial, int pMeses)
        {
            double taxaJuroAPI = ObterTaxaJuroApi();
            double taxaJuro = 1.0;

            taxaJuro = (taxaJuro + taxaJuroAPI);
            var valorJuro = pValorInicial * (MathUtils.CalcularPotencia(taxaJuro, pMeses));

            return MathUtils.TruncarValor(valorJuro);
        }
    }
}
