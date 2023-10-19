using Jwt.Authentication.Study.Api.Domain.Entities;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Jwt.Authentication.Study.Api.Domain.Services
{
    public class AuditService : IAuditService
    {
        private readonly IHttpContextAccessor _httpContext;

        public AuditService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public void RecordEvent(string eventName)
        {
            if (_httpContext.HttpContext?.Items["User"] is User user)
            {
                Console.WriteLine($"event {eventName} executed by user: {user.Id} at {DateTime.UtcNow}");
            }
            else
            {
                Console.WriteLine($"Unknown user for event {eventName} at {DateTime.UtcNow}");
            }
        }
    }
}
