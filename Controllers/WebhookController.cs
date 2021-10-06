using Microsoft.AspNetCore.Mvc;

namespace webhook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {

        public WebhookController()
        {

        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok(new { text = "Hello from the outside!" });
        }
        
    }
}
