using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Models
{
    public class SuperAdmin
    {
        private long super_admin_id;
        private string name;
        private string email;
        private string password;
        private long mobile_number;
        private DateTime login_time;
        private DateTime logout_time;

        public long Super_admin_id { get => super_admin_id; set => super_admin_id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public long Mobile_number { get => mobile_number; set => mobile_number = value; }
        public DateTime Login_time { get => login_time; set => login_time = value; }
        public DateTime Logout_time { get => logout_time; set => logout_time = value; }
    }
}