using BookMyEvent.Models;
using BookMyEvent.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Service
{
    public class SuperAdminService 
    {
        private SuperAdminRepositoryImpl SuperAdminRepositoryImpl;
        public SuperAdminService()
        {
            SuperAdminRepositoryImpl = new SuperAdminRepositoryImpl();
        }
        public SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin)
        {

            return SuperAdminRepositoryImpl.CreateSuperAdmin(superAdmin);
        }
        public SuperAdmin GetSuperAdminById(long Super_admin_id)
        {
            return SuperAdminRepositoryImpl.GetSuperAdminById(Super_admin_id);
        }
        public SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin)
        {
            return SuperAdminRepositoryImpl.UpdateSuperAdmin(super_admin_id, superAdmin);
        }
    }
}