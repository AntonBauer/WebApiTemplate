using Microsoft.AspNetCore.Mvc;

namespace WebApiTemplate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public string Test() => "Hello world";
    }
}
