namespace Jwt.Authentication.Study.Api.Configuration.DependencyInjection
{
    internal static class ConfigurationDI
    {
        internal static void RegisterConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .Configure<JwtConfiguration>(configuration.GetSection(JwtConfiguration.SectionName));
        }
    }
}
