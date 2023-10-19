using Jwt.Authentication.Study.Api.Business.Abstractions;
using Jwt.Authentication.Study.Api.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Authentication.Study.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthenticationRequest request)
        {
            var response = _authenticationService.Authenticate(request);
            return Ok(response);
        }
    }
}
