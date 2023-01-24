using Microsoft.AspNetCore.Mvc;
using WsBlazorCrud.Models.Response;

namespace WsBlazorCrud.Controllers {
    [Route("api/controller")]
    [ApiController]
    public class BeerController : Controller {
        [HttpGet]
        public IActionResult Get() {
            DefaultResponse response = new DefaultResponse();
            return Ok(response);
        }
    }
}
