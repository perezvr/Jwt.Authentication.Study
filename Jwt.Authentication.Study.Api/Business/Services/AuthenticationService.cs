using Jwt.Authentication.Study.Api.Business.Abstractions;
using Jwt.Authentication.Study.Api.Business.Services.Interfaces;

namespace Jwt.Authentication.Study.Api.Business.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<AuthenticationResponse> Authenticate(AuthenticationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
