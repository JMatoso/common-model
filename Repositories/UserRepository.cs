using System.Collections.Generic;
using CommonModel.Models;
namespace CommonModel.Repositories
{
    public class UserRepository
    {
        public static List<Users> GetUsers(){
            var users = new List<Users>(); 

            users.Add(new Users {Id = 1, Name = "Pedro Joel", Age = 17});
            users.Add(new Users {Id = 2, Name = "Leonardo Pedro", Age = 29});
            users.Add(new Users {Id = 3, Name = "Joel Leonardo", Age = 28});

            return users;
        }
    }
}