﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopMusicExam.Areas.Admin.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Admin/Album
        public ActionResult Index()
        {
            return View();
        }
    }
}