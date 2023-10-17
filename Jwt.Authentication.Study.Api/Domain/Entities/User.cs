using System.Text.Json.Serialization;

namespace Jwt.Authentication.Study.Api.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Username { get; private set; }

        [JsonIgnore]
        public string Password { get; private set; }

        public User(int id, string firstName, string lastName, string username, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }
    }
}
