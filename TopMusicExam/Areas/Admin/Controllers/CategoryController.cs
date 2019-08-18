using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopMusicApplication.Services;
using TopMusicApplication.ViewModels;

namespace TopMusicExam.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class CategoryController : Controller
    {
        //GET : Admin/ Liste des catégories à afficher dans la vue Index
        public ActionResult Index()
        {
            var viewModel = new CategoryServiceController();
            return View(viewModel.GetAllCategories());
        }

        // redirection vers la vue de création de catégorie
        public ActionResult CreateCategory()
        {
            return View("CreateCategory");
        }

        //POST: Admin/Create Category
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel viewModel)
        {
            var categoryService = new CategoryServiceController();
            categoryService.CreateCategory(viewModel);

            return RedirectToAction("Index");
        }

        //Get Admin/récupération de la catégorie cliquée afin de populer la vue Edit 
        public ActionResult GetCategory(int category_id)
        {
            var viewModel = new CategoryServiceController();
            return View("EditCategory", viewModel.GetCategoryViewModel(category_id));
        }

        //Update des informations de la catégorie 
        public ActionResult EditCategory(CategoryViewModel viewModel)
        {
            var categoryService = new CategoryServiceController();
            categoryService.EditCategory(viewModel);

            return RedirectToAction("Index");
        }

        //Suppression de la catégorie sur base de son ID ( selectionnée dans la liste de catégories présente dans la vue Index )
        public ActionResult DeleteCategory(int category_id)
        {
            var viewModel = new CategoryServiceController();
            viewModel.DeleteCategory(category_id);
            return RedirectToAction("Index");
        }
    }
}