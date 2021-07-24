using BookMyEvent.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookMyEvent.Repository
{
    public class AdminRepositoryImpl : IAdminRepository
    {
        SqlConnection con = null;
        public Admin CreateAdmin(Admin admin)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO BME_TBL_ADMIN values('" + admin.Name + "','" + admin.Email + "','" + admin.Password + "'," +
                    "'" + admin.Mobile_number + "','" + admin.Login_time + "','" + admin.Logout_time + "')", con);
                cmd.ExecuteNonQuery();
                return admin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return admin;
        }

        public Admin GetAdminById(long admin_id)
        {
            try
            {
                Admin admin = new Admin();
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BME_TBL_ADMIN WHERE Admin_id = " + admin_id, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    admin = new Admin();

                    admin.Admin_id = Convert.ToInt32(sdr["admin_id"]);
                    admin.Name = Convert.ToString(sdr["Name"]);
                    admin.Email = Convert.ToString(sdr["Email"]);
                    admin.Password = Convert.ToString(sdr["Password"]);
                    admin.Mobile_number = Convert.ToInt64(sdr["Mobile_number"]);
                    admin.Login_time = Convert.ToDateTime(sdr["login_time"]);
                   admin.Logout_time = Convert.ToDateTime(sdr["logout_time"]);
                    return admin;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Admin UpdateAdmin(long admin_id, Admin admin)
        {

            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BME_TBL_ADMIN  SET  name = '" + admin.Name + "', Email = '" + admin.Email + "', Password = '" + admin.Password + "', Mobile_number = '" + admin.Mobile_number + "',Login_time = '" + admin.Login_time + "',Logout_time = '" + admin.Logout_time + "' WHERE admin_id =" + admin_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return admin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}