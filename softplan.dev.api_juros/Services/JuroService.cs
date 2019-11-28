using softplan.dev.api_juros.Models;
using softplan.dev.api_juros.Services.Interfaces;

namespace softplan.dev.api_juros.Services
{
    public class JuroService : IJuroService
    {
        private decimal TaxaJuro => 0.01M;
        public decimal ObterTaxaJuro() => TaxaJuro;
        public Juro ObterJuro() => new Juro();
    }
}
