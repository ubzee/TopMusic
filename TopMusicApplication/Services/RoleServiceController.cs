using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;
using TopMusicDomain.Services;

namespace TopMusicApplication.Services
{
    public class RoleServiceController
    {
        public string CreateRole(RoleViewModel viewModel)
        {
            return RoleService.CreateRole(viewModel.Name);
        }

    }
}
