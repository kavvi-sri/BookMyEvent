using BookMyEvent.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookMyEvent.Repository
{
    public class SuperAdminRepositoryImpl : ISuperAdminRepository
    {
        SqlConnection con = null;
        public SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO BME_TBL_SUPER_ADMIN values('" + superAdmin.Name + "','" + superAdmin.Email + "','" + superAdmin.Password + "'," +
                    "'" + superAdmin.Mobile_number + "','" + superAdmin.Login_time + "','" + superAdmin.Logout_time + "')", con);
                cmd.ExecuteNonQuery();
                return superAdmin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return superAdmin;
        }

        public SuperAdmin GetSuperAdminById(long Super_admin_id)
        {
            try
            {
                SuperAdmin superAdmin = new SuperAdmin();
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BME_TBL_SUPER_ADMIN WHERE Super_admin_id = " + Super_admin_id, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    superAdmin = new SuperAdmin();

                    superAdmin.Super_admin_id = Convert.ToInt32(sdr["Super_admin_id"]);
                    superAdmin.Name = Convert.ToString(sdr["Name"]);
                    superAdmin.Email = Convert.ToString(sdr["Email"]);
                    superAdmin.Password = Convert.ToString(sdr["Password"]);
                    superAdmin.Mobile_number = Convert.ToInt64(sdr["Mobile_number"]);
                    superAdmin.Login_time = Convert.ToDateTime(sdr["login_time"]);
                    superAdmin.Logout_time = Convert.ToDateTime(sdr["logout_time"]);
                    return superAdmin;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin)
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BME_TBL_SUPER_ADMIN  SET  name = '" + superAdmin.Name + "', Email = '" + superAdmin.Email + "', Password = '" + superAdmin.Password + "', Mobile_number = '" + superAdmin.Mobile_number + "',Login_time = '" + superAdmin.Login_time + "',Logout_time = '" + superAdmin.Logout_time + "' WHERE super_admin_id =" + super_admin_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return superAdmin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}