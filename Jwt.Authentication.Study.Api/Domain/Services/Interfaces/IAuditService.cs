using Jwt.Authentication.Study.Api.Domain.Entities;

namespace Jwt.Authentication.Study.Api.Domain.Services.Interfaces
{
    public interface IAuditService
    {
        void RecordEvent(string eventName);
    }
}