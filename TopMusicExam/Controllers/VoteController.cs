using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopMusicApplication.Services;
using Microsoft.AspNet.Identity;

namespace TopMusicExam.Controllers
{
    [Authorize]
    public class VoteController : Controller
    {
        // GET: Category
        public ActionResult Index(int category_id)
        {
            var serviceController = new VoteServiceController();
            var viewModel = serviceController.GetVoteViewModel(category_id);
            return View(viewModel);
        }

        // GET: Category/{AlbumId}
        public ActionResult Vote(int album_id, int category_ID)
        {
            var serviceController = new VoteServiceController();
            var userID = User.Identity.GetUserId();
            var viewModel = serviceController.Vote(album_id, userID);
            
            return RedirectToAction("Index", new { category_id = category_ID });
        }
    }
}