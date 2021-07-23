using BookMyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyEvent.Repository
{
    interface IUserRepository 
    {
        //GET USER
        User CreateUser(User user);
        //DELETE USER BY ID
        string DeleteUser(long user_id);
        //UPDATE USER BY USERID
        User UpdateUser(long user_id, User user);
        //GET ALL USERS
        List<User> GetAllUsers();
        //GET USER BY USER ID
        User GetUserById(long user_id);
        // GET USER BY NAME
        User GetUserByUsername(string username);

    }
}
