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
            try
            {
                using (TopMusicEntities db = new TopMusicEntities())
                {
                    var role = new AspNetRoles
                    {
                        Name = roleName,
                        Id = Guid.NewGuid().ToString()
                    };
                    db.AspNetRoles.Add(role);
                    db.SaveChanges();
                    return role.Name;
                }
            }
            catch (Exception error)
            {
                throw;
            }
            
        }


        

    }
}
