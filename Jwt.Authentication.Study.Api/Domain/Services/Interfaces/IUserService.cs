using Jwt.Authentication.Study.Api.Domain.Entities;

namespace Jwt.Authentication.Study.Api.Domain.Services.Interfaces
{
    public interface IUserService
    {
        User? GetByUsenNameAndPassword(string userName, string password);
        User? GetById(int id);
    }
}
