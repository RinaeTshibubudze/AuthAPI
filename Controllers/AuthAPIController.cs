using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<IActionResult> Register()
        {
            // Registration logic will go here
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login()
        {
            // Login logic will go here
            return Ok();
        }

    }
}