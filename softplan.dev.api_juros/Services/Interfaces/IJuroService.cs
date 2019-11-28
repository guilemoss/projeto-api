using softplan.dev.api_juros.Models;

namespace softplan.dev.api_juros.Services.Interfaces
{
    public interface IJuroService
    {
        decimal ObterTaxaJuro();
        Juro ObterJuro();
    }
}
