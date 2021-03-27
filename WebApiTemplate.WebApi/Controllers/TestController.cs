using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WebApiTemplate.Application.UseCases.Greeting;

namespace WebApiTemplate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMediator _mediator;

        public TestController(
            IMediator mediator,
            ILogger<TestController> logger
        )
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Test()
        {
            try
            {
                var result = await _mediator.Send(new TestQuery());
                _logger.LogInformation($"Ok, here is result: {result}");

                return result;
            }
            catch(Exception ex)
            {
                _logger.LogError("Failed to test", ex);
                return BadRequest();
            }
        }
    }
}
