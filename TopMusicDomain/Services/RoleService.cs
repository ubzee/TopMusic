using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMusicDomain.Services
{
    public class RoleService
    {
        public static string CreateRole (string roleName)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var role = new AspNetRoles
                {
                    Name = roleName
                };
                db.AspNetRoles.Add(role);
                db.SaveChanges();
                return role.Name;
            }
        }


        

    }
}
