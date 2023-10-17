using Jwt.Authentication.Study.Api.Domain.Entities;

namespace Jwt.Authentication.Study.Api.Business.Abstractions
{
    public class AuthenticationResponse
    {
        public int UserId { get; private set; }
        public string Token { get; private set; }
        public string ExpiresIn { get; private set; }

        public AuthenticationResponse(User user, string token, DateTime expiresIn)
        {
            UserId = user.Id;
            Token = token;
            ExpiresIn = expiresIn.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
