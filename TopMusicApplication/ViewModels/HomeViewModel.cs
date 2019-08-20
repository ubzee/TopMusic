using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMusicApplication.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            NewCategories = new List<CategoryViewModel>();
            TopRankCategories = new List<CategoryViewModel>();
        }
        public List<CategoryViewModel> NewCategories { get; set; }
        public List<CategoryViewModel> TopRankCategories { get; set; }

    }
}
