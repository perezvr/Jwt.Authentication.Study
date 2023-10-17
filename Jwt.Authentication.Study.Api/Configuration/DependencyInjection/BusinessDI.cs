using Jwt.Authentication.Study.Api.Domain.Services;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;

namespace Jwt.Authentication.Study.Api.Configuration.DependencyInjection
{
    public static class BusinessDI
    {
        public static void RegisterBusiness(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
        }
    }
}
