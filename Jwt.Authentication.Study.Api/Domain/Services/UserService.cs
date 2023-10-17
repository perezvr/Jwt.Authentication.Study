using Jwt.Authentication.Study.Api.Business.Abstractions;
using Jwt.Authentication.Study.Api.Domain.Entities;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;

namespace Jwt.Authentication.Study.Api.Domain.Services
{
    public class UserService : IUserService
    {
        /// <summary>
        /// Representation of repository
        /// </summary>
        private List<User> _users =
            new List<User>
            {
                new User (1, "Renan", "Perez","userName", "passWord" )
            };

        public User? GetByUsenNameAndPassword(string userName, string password)
        {
            //Auntenticando usuário
            var user = _users.FirstOrDefault(x => x.Username == userName && x.Password == password);
            return user;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
