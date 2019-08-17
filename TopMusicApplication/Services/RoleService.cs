using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;



namespace TopMusicApplication.Services
{
    class RoleService
    {
        public string CreateRole(RoleViewModel viewModel)
        {
            return TopMusicDomain.Services.RoleService.CreateRole(viewModel.Name);
        }
    }
}
