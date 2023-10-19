using Jwt.Authentication.Study.Api.Business.Services;
using Jwt.Authentication.Study.Api.Business.Services.Interfaces;
using Jwt.Authentication.Study.Api.Domain.Services;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;

namespace Jwt.Authentication.Study.Api.Configuration.DependencyInjection
{
    public static class BusinessDI
    {
        public static void RegisterBusiness(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IAuditService, AuditService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
        }
    }
}
