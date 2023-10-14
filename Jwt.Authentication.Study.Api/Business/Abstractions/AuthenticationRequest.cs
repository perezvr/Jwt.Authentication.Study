using System.ComponentModel.DataAnnotations;

namespace Jwt.Authentication.Study.Api.Business.Abstractions
{
    public class AuthenticationRequest
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
