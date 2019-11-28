namespace softplan.dev.api_gestao_juros.External.APIJuros
{
    public class JurosAPIClient
    {
        private string _chaveInternaJurosAPI;
        public JurosAPIClient(string chaveInternaApi)
        {
            _chaveInternaJurosAPI = chaveInternaApi;
        }

        public Query Query()
        {
            Query consulta = new Query(_chaveInternaJurosAPI);
            if (consulta.ValidRequest)
                return consulta;

            return null;
        }

    }
}
