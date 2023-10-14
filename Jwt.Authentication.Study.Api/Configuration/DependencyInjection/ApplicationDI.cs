namespace Jwt.Authentication.Study.Api.Configuration.DependencyInjection
{
    internal static class ApplicationDI
    {
        internal static void RegisterApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterConfiguration(configuration);


        }
    }
}
