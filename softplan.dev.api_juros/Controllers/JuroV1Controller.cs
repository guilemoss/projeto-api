using Microsoft.AspNetCore.Mvc;
using softplan.dev.api_juros.Models;
using softplan.dev.api_juros.Services.Interfaces;

namespace softplan.dev.api_juros.Controllers
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
        [Route("juro")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        public ActionResult<Juro> GetJuro()
        {
            return _juroService.ObterJuro();
        }
    }
}