using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PrivateStorage.API.Contracts;
using PrivateStorage.Core.DTO;
using PrivateStorage.Core.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace PrivateStorage.API.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("sign-in")]
        public async Task<IActionResult> SignIn(SignInDTO user)
        {
            
            
            var claims = new List<Claim> { new Claim(ClaimTypes.Email, user.Email) };
          
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromDays(14)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return Ok(new JwtSecurityTokenHandler().WriteToken(jwt));
 
        }

        [HttpPost]
        [Route("sign-up")]
        public async Task<IActionResult> SignUp(CreateUserRequest _user)
        {
            var result = await _userService.createUserAsync(_user);
            return Ok(result);
        }

        [HttpGet]
        [Route("me")]
        [Authorize]
        public async Task<IActionResult> GetMe()
        {
            return Ok(HttpContext.Items.ToList());
        }
    }
}
