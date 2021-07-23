using BookMyEvent.Models;
using BookMyEvent.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Service
{
    public class UserService
    {
        private UserRepositoryImpl UserRepositoryImpl;
        public UserService()
        {
            UserRepositoryImpl = new UserRepositoryImpl();
        }
        public User saveUser(User user)
        {

            return UserRepositoryImpl.CreateUser(user);
        }

        public List<User> getAllusers()
        {
            return UserRepositoryImpl.GetAllUsers();
        }
        public User getUserById(int user_id)
        {
            return UserRepositoryImpl.GetUserById(user_id);
        }

        public User GetUserByUsername(string username)
        {
            return UserRepositoryImpl.GetUserByUsername(username);
        }

        public User UpdateUser(long user_id, User user)
        {
            return UserRepositoryImpl.UpdateUser(user_id, user);
        }
        public string DeleteUser(long user_id)
        {
            return UserRepositoryImpl.DeleteUser(user_id);
        }

    }
}