using BookMyEvent.Models;
using BookMyEvent.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Service
{
    public class AdminService
    {
        private AdminRepositoryImpl AdminRepositoryImpl;
        public AdminService()
        {
            AdminRepositoryImpl = new AdminRepositoryImpl();
        }
        public Admin CreateAdmin(Admin admin)
        {

            return AdminRepositoryImpl.CreateAdmin(admin);
        }

       public Admin GetAdminById(long admin_id)
        {
            return AdminRepositoryImpl.GetAdminById(admin_id);
        }

        public Admin UpdateAdmin(long admin_id, Admin admin)
        {
            return AdminRepositoryImpl.UpdateAdmin(admin_id, admin);
        }
    }
}