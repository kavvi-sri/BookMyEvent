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
    public class AdminController : ApiController
    {
        private AdminService AdminService;
        public AdminController()
        {
            AdminService = new AdminService();
        }

        [HttpPost]
        [Route("api/Admin/save")]
        public Admin saveAdmin([FromBody] Admin admin)
        {

            try
            {
                return AdminService.CreateAdmin(admin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return admin;
        }
       [HttpGet]
       [Route("api/Admin/GetAdminById/{admin_id}")]
       public Admin GetAdminById(long admin_id)
        {
            try
            {
                return AdminService.GetAdminById(admin_id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return AdminService.GetAdminById(admin_id);
        }
        [HttpPut]
        [Route("api/Admin/update/{admin_id}")]
        public Admin UpdateAdmin(long admin_id, Admin admin)
        {
            try
            {
                return AdminService.UpdateAdmin(admin_id, admin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

    }
}
