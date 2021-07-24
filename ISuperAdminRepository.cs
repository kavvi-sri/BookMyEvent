using BookMyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyEvent.Repository
{
    interface ISuperAdminRepository
    {

        SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin);

        SuperAdmin GetSuperAdminById(long Super_admin_id);

        SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin);
    }
}
