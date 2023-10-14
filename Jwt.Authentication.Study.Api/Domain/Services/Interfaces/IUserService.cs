using Jwt.Authentication.Study.Api.Business.Abstractions;
using Jwt.Authentication.Study.Api.Domain.Entities;

namespace Jwt.Authentication.Study.Api.Domain.Services.Interfaces
{
    public interface IUserService
    {
        AuthenticationResponse Authenticate(string userName, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
