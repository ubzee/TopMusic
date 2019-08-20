using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopMusicApplication.Services;

namespace TopMusicExam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var serviceController = new HomeServiceController();
            var viewModel = serviceController.GetHomeViewModel();

            return View(viewModel);
        }

        

       
    }
}