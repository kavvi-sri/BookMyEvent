using BookMyEvent.Models;
using BookMyEvent.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookMyEvent.Controllers
{
    public class UserController : ApiController
    {
        private UserService UserService;
        public UserController()
        {
            UserService = new UserService();
        }

        [HttpPost]
        [Route("api/User/save")]
        public User saveProduct([FromBody] User user)
        {

            try
            {
                return UserService.saveUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return user;
        }
        [HttpGet]
        [Route("api/user/GetAll")]
        public List<User> fetchAllUsers()
        {
            try
            {
                return UserService.getAllusers();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/user/GetById/{user_id}")]
        public User fetchUserById(int user_id)
        {
            try
            {
                return UserService.getUserById(user_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return UserService.getUserById(user_id);
        }
        [HttpGet]
        [Route("api/user/GetUserByUserName/{username}")]
        public User GetUserByUsername(string username)
        {
            try
            {
                return UserService.GetUserByUsername(username);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        [HttpPut]
        [Route("api/user/update/{user_id}")]
        public User UpdateUser(long user_id, User user)
        {
            try
            {
                return UserService.UpdateUser(user_id, user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        [HttpDelete]
        [Route("api/User/DeleteById/{user_id}")]
        public string DeleteUser(long user_id)
        {
            try
            {
                return UserService.DeleteUser(user_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
