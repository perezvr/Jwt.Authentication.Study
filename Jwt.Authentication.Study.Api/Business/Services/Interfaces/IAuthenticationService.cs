using Jwt.Authentication.Study.Api.Business.Abstractions;

namespace Jwt.Authentication.Study.Api.Business.Services.Interfaces
{
    public interface IAuthenticationService
    {
        AuthenticationResponse Authenticate(AuthenticationRequest request);
    }
}
