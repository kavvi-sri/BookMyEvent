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
    public class SuperAdminController : ApiController
    {
        private SuperAdminService SuperAdminService;
        public SuperAdminController()
        {
            SuperAdminService = new SuperAdminService();
        }

        [HttpPost]
        [Route("api/SuperAdmin/save")]
        public SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin)
        {

            try
            {
                return SuperAdminService.CreateSuperAdmin(superAdmin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return superAdmin;
        }
        [HttpGet]
        [Route("api/SuperAdmin/GetSuperAdminById/{Super_admin_id}")]
        public SuperAdmin GetSuperAdminById(long Super_admin_id)
        {
            try
            {
                return SuperAdminService.GetSuperAdminById(Super_admin_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        [HttpPut]
        [Route("api/SuperAdmin/Update/{Super_admin_id}")]
        public SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin)
        {
            try
            {
                return SuperAdminService.UpdateSuperAdmin(super_admin_id, superAdmin);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
