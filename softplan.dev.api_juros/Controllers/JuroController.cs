using Microsoft.AspNetCore.Mvc;
using softplan.dev.api_juros.Services;
using softplan.dev.api_juros.Services.Interfaces;

namespace softplan.dev.api_juros.Controllers
{
    [Route("taxaJuros")]
    public class JuroController : Controller
    {
        private readonly IJuroService _juroService;
        public JuroController()
        {
            _juroService = new JuroService();
        }

        [HttpGet]
        [Route("")]
        public ActionResult<decimal> GetTaxaJuros() 
        {
            return _juroService.ObterTaxaJuro()*8;
        }
    }
}