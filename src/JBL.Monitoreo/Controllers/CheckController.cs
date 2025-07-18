using JBL.Monitoreo.Controllers.Contracts;
using JBL.Monitoreo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JBL.Monitoreo.Controllers
{
    [Route("api/check")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Check()
        {
            return Ok("OK");
        }

    }
}

