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
    public class AlbumController : Controller
    {
        // GET: Admin/Album
        public ActionResult Index(int category_id)
        {
            var serviceController = new AlbumServiceController();
            var viewModel = serviceController.GetAlbumsViewModel(category_id);
            return View(viewModel);
        }

        // GET: Admin/Album/Delete
        public ActionResult DeleteAlbum(int album_id, int category_id)
        {
            var serviceController = new AlbumServiceController();
            var viewModel = serviceController.DeleteAlbum(album_id);

            return RedirectToAction("Index", new { category_id });
        }

        //POST: Admin/Album/Search/{}
        [HttpPost]
        public ActionResult MbSearch(int category_id,AlbumViewModel searchModel)
        {
            var serviceController = new AlbumServiceController();
            var viewModel = serviceController.AlbumMBSearch(searchModel, category_id);
            return View("Index", viewModel);
        }

        //GET: Admin/Album/Add/{category_id}
        public ActionResult AddAlbum(int category_id, string MusicBrainz_id, string Title, string ArtistName)
        {
            var serviceController = new AlbumServiceController();
            var viewModel = serviceController.AddAlbum(category_id, MusicBrainz_id, Title, ArtistName);

            return RedirectToAction("Index", new { category_id });
        }
    }


}