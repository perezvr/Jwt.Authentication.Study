using Jwt.Authentication.Study.Api.Business.Abstractions;
using Jwt.Authentication.Study.Api.Business.Services.Interfaces;
using Jwt.Authentication.Study.Api.Configuration;
using Jwt.Authentication.Study.Api.Domain.Entities;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jwt.Authentication.Study.Api.Business.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly JwtConfiguration _jwtConfiguration;

        public AuthenticationService(IUserService userService, IOptions<JwtConfiguration> jwtConfiguration)
        {
            _userService = userService;
            _jwtConfiguration = jwtConfiguration.Value;
        }

        public AuthenticationResponse? Authenticate(AuthenticationRequest request)
        {
            var user = _userService.GetByUsenNameAndPassword(request.Username, request.Password);

            //retornar o erro de outra forma
            if(user is null)
                return null;

            //todo pensar em uma estratégia para devolver um usuário nao encontrado
            var token = GenerateJwtToken(user);
            var validTo = GetExpireTime(token);

            return new AuthenticationResponse(user, token, validTo);
        }

        public string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfiguration.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("sub", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Audience = _jwtConfiguration.Audience
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public DateTime GetExpireTime(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);

            return jsonToken.ValidTo;
        }
    }
}
