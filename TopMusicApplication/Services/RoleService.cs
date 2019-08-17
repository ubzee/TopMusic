using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;
using TopMusicDomain;


namespace TopMusicApplication.Services
{
    class RoleService
    {
        public string CreateRole(RoleViewModel viewModel)
        {
            return RoleService.CreateRole(viewModel.Name);

        }
    }
}
