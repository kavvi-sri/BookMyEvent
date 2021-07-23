using BookMyEvent.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookMyEvent.Repository
{
    public class UserRepositoryImpl : IUserRepository
    {
        SqlConnection con = null;
        public User CreateUser(User user)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO BME_TBL_USERS values('" + user.Username + "','" + user.Email + "','" + user.Password + "'," +
                    "'" + user.Mobile_number + "','" + user.Gender + "','" + user.Dob + "','" + user.Address + "','" + user.Created_date + "','" + user.Updated_date + "','" + user.Login_time + "','" + user.Logout_time + "')", con);
                cmd.ExecuteNonQuery();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return user;
        }


        public string DeleteUser(long user_id)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete  from BME_TBL_USERS WHERE user_id=" + user_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return " Deleted Sucessfully:" + user_id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                User theUser = new User();
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BME_TBL_USERS", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    theUser = new User();
                    theUser.User_id = Convert.ToInt32(sdr["user_id"]);
                    theUser.Username = Convert.ToString(sdr["Username"]);
                    theUser.Email = Convert.ToString(sdr["Email"]);
                    theUser.Password = Convert.ToString(sdr["Password"]);
                    theUser.Mobile_number = Convert.ToString(sdr["Mobile_number"]);
                    theUser.Gender = Convert.ToString(sdr["Gender"]);
                    theUser.Dob = Convert.ToDateTime(sdr["Dob"]);
                    theUser.Address = Convert.ToString(sdr["Address"]);
                    theUser.Created_date = Convert.ToDateTime(sdr["Created_date"]);
                    theUser.Updated_date = Convert.ToDateTime(sdr["Updated_date"]);
                    theUser.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                    theUser.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                    userList.Add(theUser);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return userList;
        }

        public User GetUserById(long user_id)
        {
            try
            {
                User theUser = new User();
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BME_TBL_USERS WHERE User_id = " + user_id, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    theUser = new User();
                    theUser.User_id = Convert.ToInt32(sdr["user_id"]);
                    theUser.Username = Convert.ToString(sdr["Username"]);
                    theUser.Email = Convert.ToString(sdr["Email"]);
                    theUser.Password = Convert.ToString(sdr["Password"]);
                    theUser.Mobile_number = Convert.ToString(sdr["Mobile_number"]);
                    theUser.Gender = Convert.ToString(sdr["Gender"]);
                    theUser.Dob = Convert.ToDateTime(sdr["Dob"]);
                    theUser.Address = Convert.ToString(sdr["Address"]);
                    theUser.Created_date = Convert.ToDateTime(sdr["Created_date"]);
                    theUser.Updated_date = Convert.ToDateTime(sdr["Updated_date"]);
                    theUser.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                    theUser.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                    return theUser;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }



        public User GetUserByUsername(string username)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);


                con.Open();
                SqlCommand cmd = new SqlCommand("select * from BME_TBL_USERS where username='" + username + "'", con);
                User user = new User();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    user = new User();
                    user.User_id = Convert.ToInt32(sdr["user_id"]);
                    user.Username = Convert.ToString(sdr["username"]);
                    user.Email = Convert.ToString(sdr["email"]);
                    user.Password = Convert.ToString(sdr["password"]);
                    user.Mobile_number = Convert.ToString(sdr["mobile_number"]);
                    user.Gender = Convert.ToString(sdr["gender"]);
                    user.Dob = Convert.ToDateTime(sdr["dob"]);
                    user.Address = Convert.ToString(sdr["address"]);
                    user.Created_date = Convert.ToDateTime(sdr["created_date"]);
                    user.Updated_date = Convert.ToDateTime(sdr["updated_date"]);
                    user.Login_time = Convert.ToDateTime(sdr["login_time"]);
                    user.Logout_time = Convert.ToDateTime(sdr["logout_time"]);


                    return user;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public User UpdateUser(long user_id, User user)
        {
            try
            {
                
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BME_TBL_USERS  SET  Username = '" + user.Username + "', Email = '" + user.Email + "', Password = '" + user.Password + "', Mobile_number = '" + user.Mobile_number + "', Gender = '" + user.Gender + "',  Dob = '" + user.Dob + "', Address = '" + user.Address + "', Created_date = '" + user.Created_date + "', Updated_date = '" + user.Updated_date + "',Login_time = '" + user.Login_time + "',Logout_time = '" + user.Logout_time + "' WHERE user_id =" + user_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}








