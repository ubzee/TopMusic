using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;
using TopMusicCommon;
using TopMusicDomain.Services;

namespace TopMusicApplication.Services
{
    public class CategoryServiceController
    {
        //Creation
        public int CreateCategory(CategoryViewModel viewModel)
        {
            return CategoryService.CreateCategory(viewModel.Name, viewModel.Description);
        }

        //Liste des catégories pour la view index
        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            foreach (var category in CategoryService.GetCategories())
            {
                yield return new CategoryViewModel() { Category = category };
            }
        }

        //get category pour Edit view
        public CategoryViewModel GetCategoryViewModel(int category_id)
        {
            var category = CategoryService.GetCategory(category_id);
            return new CategoryViewModel()
            {
                Category_ID = category.Category_ID,
                Name = category.Name,
                Description = category.Description,
                Visibility = (CategoryVisibility)category.Status
            };
        }

        //Edit Category
        public int EditCategory(CategoryViewModel viewModel)
        {
            return CategoryService.EditCategory(viewModel.Category_ID, viewModel.Name, viewModel.Description, (int)viewModel.Visibility);
        }

        //Delete Category
        public int DeleteCategory(int category_id)
        {
            return CategoryService.DeleteCategory(category_id);
        }






        //Get List Of Categories
        //public List<CategoryViewModel> GetAllCategories()
        //{
        //    List<CategoryViewModel> viewModels = new List<CategoryViewModel>();

        //    foreach (var category in CategoryService.GetListCategories())
        //    {
        //        viewModels.Add(new CategoryViewModel
        //        {
        //            Category_ID = category.Category_ID,
        //            Name = category.Name,
        //            Description = category.Description,
        //            Image = category.Image
        //        });
        //    }
        //    return viewModels;
        //}


    }
}
