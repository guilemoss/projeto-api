using Microsoft.AspNetCore.Mvc;

namespace softplan.dev.api_gestao_juros.Controllers
{
    [Route("showmethecode")]
    public class CodigoFonteController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult<string> GetUrlCodigoFonteHospedado()
        {
            return "https://github.com/guilemoss/projeto-api.git";
        }
    }
}