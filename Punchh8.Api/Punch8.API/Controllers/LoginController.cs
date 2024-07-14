


using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Punch8.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        #region Private Members
        readonly ILogger<LoginController> logger;

        #endregion

        #region ctor
        public LoginController(ILogger<LoginController> logger)
        {
            this.logger = logger;
        }
        #endregion

        #region Public Methods
        [HttpGet]
        [Route("Hi")]
        public async Task<IActionResult> Hi(string Name="")
        {
            logger.LogInformation($"hi Method Invoked");
            await Task.CompletedTask;
            logger.LogInformation($"Hi Method Ended");
            return Ok("Hi "+ Name);
        }
        #endregion
    }
}