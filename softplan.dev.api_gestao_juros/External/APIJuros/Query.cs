using Newtonsoft.Json.Linq;

namespace softplan.dev.api_gestao_juros.External.APIJuros
{
    public class Query
    {
        private bool validRequest;
        private decimal taxaJuro;
        public bool ValidRequest { get { return validRequest; } }
        public decimal TaxaJuro { get { return taxaJuro; } }
        
        private readonly string juroApiUrl = $"http://localhost:6000/v1/juros/juro";
        //TODO Guilherme Implementar - GetEnvironmentVariable
        //private readonly string juroApiUrl = Environment.GetEnvironmentVariable("JuroApiUrl");
        public Query(string chaveInternaApi)
        {
            JObject jsonData = JObject.Parse(new System.Net.WebClient().DownloadString(juroApiUrl));
            var taxaJuroApi = decimal.Parse(jsonData.SelectToken("taxa").ToString());
            validRequest = (taxaJuroApi > 0);
            
            if (validRequest)
                taxaJuro = taxaJuroApi;
        }
    }
}
