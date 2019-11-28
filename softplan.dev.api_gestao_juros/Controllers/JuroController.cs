using Microsoft.AspNetCore.Mvc;
using softplan.dev.api_gestao_juros.Services.Interfaces;

namespace softplan.dev.api_gestao_juros.Controllers
{
    [Route("calculajuros")]
    public class JuroController : Controller
    {
        private readonly IJuroService _juroService;
        public JuroController(IJuroService juroService)
        {
            _juroService = juroService;
        }

        [HttpGet]
        [Route("{pValorInicial:decimal}/{pMeses:int}")]
        public ActionResult<decimal> GetCalcularJuros(decimal pValorInicial, int pMeses)
        {
            return _juroService.CalcularJuro(pValorInicial, pMeses);
        }
    }
}