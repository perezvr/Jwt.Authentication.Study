using Jwt.Authentication.Study.Api.Configuration;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Jwt.Authentication.Study.Api.Middlewares
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly JwtConfiguration _jwtConfiguration;

        public JwtMiddleware(RequestDelegate next, IOptions<JwtConfiguration> jwtConfiguration)
        {
            _next = next;
            _jwtConfiguration = jwtConfiguration.Value;
        }

        public async Task Invoke(HttpContext context, IUserService userService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                AttachUserToContext(context, userService, token);

            await _next(context);
        }

        private JwtSecurityToken ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfiguration.Secret);

            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = true,
                ValidAudiences = new List<string>() { _jwtConfiguration.Audience },
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            return (JwtSecurityToken)validatedToken;
        }

        private void AttachUserToContext(HttpContext context, IUserService userService, string token)
        {
            try
            {
                var jwtToken = ValidateToken(token);
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "sub").Value);

                // Incluindo usuário no contexto após validar o token
                context.Items["User"] = userService.GetById(userId);
            }
            catch (Exception) { }
        }
    }
}
