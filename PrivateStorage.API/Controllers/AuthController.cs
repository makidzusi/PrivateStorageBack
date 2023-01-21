using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PrivateStorage.Core.Services;
using System.Net.Http.Headers;

namespace PrivateStorage.API.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("sign-in")]
        public async Task<IActionResult> SignUp()
        {
            return StatusCode(200);
        }

        [HttpPost]
        [Route("sign-up")]
        public async Task<IActionResult> SignIn()
        {
            return StatusCode(200);
        }
    }
}
