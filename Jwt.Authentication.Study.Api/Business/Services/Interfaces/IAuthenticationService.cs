using Jwt.Authentication.Study.Api.Business.Abstractions;

namespace Jwt.Authentication.Study.Api.Business.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> Authenticate(AuthenticationRequest request);
    }
}
