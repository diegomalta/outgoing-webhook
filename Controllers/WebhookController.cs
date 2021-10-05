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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { text = "Hello" });
        }
        
    }
}
