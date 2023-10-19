using Jwt.Authentication.Study.Api.Domain.Entities;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;

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
            string record = (_httpContext.HttpContext?.Items["User"] is User user)
                ? $"event {eventName} executed by user: {user.Id} at {DateTime.UtcNow}"
                : $"Unknown user for event {eventName} at {DateTime.UtcNow}";

            Console.WriteLine(record);
        }
    }
}
