using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Desktop.Repository
{
    public class UserRepository
    {
        private static List<UserModel> users = new List<UserModel>
        {
            new UserModel
            {
                Id = Guid.NewGuid(),
                Username = "admin",
                Email = "admin@mail.ru",
                Password = "adminadmin"
            }
        };

        public static bool RegisterUser(string username, string email, string password)
        {
            if (users.Any(u => u.Username == username || u.Email == email))
            {
                return false;
            }

            var newUser = new UserModel
            {
                Id = Guid.NewGuid(),
                Username = username,
                Email = email,
                Password = password
            };

            users.Add(newUser);
            return true;
        }

        public static UserModel AuthenticateUser(string email, string password)
        {
            var user = users.FirstOrDefault(u => (u.Email == email && u.Password == password));

            return user;
        }
    }
}
