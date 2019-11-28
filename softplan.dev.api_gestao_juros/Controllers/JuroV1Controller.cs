using Microsoft.AspNetCore.Mvc;
using softplan.dev.api_gestao_juros.Services.Interfaces;

namespace softplan.dev.api_gestao_juros.Controllers
{
    [Route("v1/juros")]
    public class JuroV1Controller : Controller
    {
        private readonly IJuroService _juroService;
        public JuroV1Controller(IJuroService juroService)
        {
            _juroService = juroService;
        }

        [HttpGet]
        [Route("calcular-juro/{pValorInicial:decimal}/{pMeses:int}")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        public ActionResult<decimal> GetCalcularJuros(decimal pValorInicial, int pMeses)
        {
            return _juroService.CalcularJuro(pValorInicial, pMeses);
        }
        
    }
}
