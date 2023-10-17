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

        public IActionResult Login([FromBody] AuthenticationRequest request)
        {
            _authenticationService.Authenticate(request);
            return Ok();
        }
    }
}
