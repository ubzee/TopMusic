using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;
using TopMusicDomain.Services;

namespace TopMusicApplication.Services
{
    public class HomeServiceController
    {
        public HomeViewModel GetHomeViewModel()
        {
            var viewModel = new HomeViewModel();

            //List<CategoryViewModel> categories = new List<CategoryViewModel>();
            foreach (var category in CategoryService.GetTopRankCategories().Take(3))
            {
                viewModel.TopRankCategories.Add(new CategoryViewModel
                {
                    Category_ID = category.Category_ID,
                    Name = category.Name,
                    Description = category.Description,
                    Image = category.Image
                });
            }


            //List<CategoryViewModel> newcategories = new List<CategoryViewModel>();
            foreach (var category in CategoryService.GetNewCategories().Take(3))
            {
                viewModel.NewCategories.Add(new CategoryViewModel
                {
                    Category_ID = category.Category_ID,
                    Name = category.Name,
                    Description = category.Description,
                    Image = category.Image
                });
            }
            return viewModel;

        }
    }
}
