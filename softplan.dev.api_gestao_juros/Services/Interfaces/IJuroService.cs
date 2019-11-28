namespace softplan.dev.api_gestao_juros.Services.Interfaces
{
    public interface IJuroService
    {
        decimal CalcularJuro(decimal pValorInicial, int pMeses);
    }
}
