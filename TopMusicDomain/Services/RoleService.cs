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
        public static string CreateRole (string name)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var role = new AspNetRoles
                {
                    Name = name
                };
                db.AspNetRoles.Add(role);
                db.SaveChanges();
                return role.Name;
            }
        }


        

    }
}
