using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace WebApiTemplate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMediator _mediator;

        public GreetingController(
            IMediator mediator,
            ILogger<GreetingController> logger
        )
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult<string> Greet()
        {
            _logger.LogInformation($"Hello there from {nameof(Greet)}");
            try
            {
                //var result = await _mediator.Send(new GreetingQuery());
                return "Hello there";
            }
            catch(Exception ex)
            {
                _logger.LogError("Failed to test", ex);
                return BadRequest();
            }
        }
    }
}
