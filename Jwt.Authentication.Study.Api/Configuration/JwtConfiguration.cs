using System.ComponentModel.DataAnnotations;

namespace Jwt.Authentication.Study.Api.Configuration
{
    public class JwtConfiguration
    {
        public const string SectionName = "JWT";

        [Required(ErrorMessage = $"Property {nameof(SectionName)}:{nameof(Secret)} must to be set")]
        public string Secret { get; set; } = string.Empty;
        [Required(ErrorMessage = $"Property {nameof(SectionName)}:{nameof(Audience)} must to be set")]
        public string Audience { get; set; } = string.Empty;
    }
}
