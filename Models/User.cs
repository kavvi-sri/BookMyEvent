using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Models
{
    public class User
    {
        private long user_id;
        private string username;
        private string email;
        private string password;
        private string mobile_number;
        private string gender;
        private DateTime dob;
        private string address;
        private DateTime created_date;
        private DateTime updated_date;
        private DateTime login_time;
        private DateTime logout_time;

        public long User_id { get => user_id; set => user_id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Mobile_number { get => mobile_number; set => mobile_number = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Created_date { get => created_date; set => created_date = value; }
        public DateTime Updated_date { get => updated_date; set => updated_date = value; }
        public DateTime Login_time { get => login_time; set => login_time = value; }
        public DateTime Logout_time { get => logout_time; set => logout_time = value; }
    }
}