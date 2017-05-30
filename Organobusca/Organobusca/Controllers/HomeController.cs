﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Organobusca.Models;

namespace Organobusca.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Temp = TempData["mensagem"];
            return View();
        }
        public ActionResult Opcoes()
        {
            return View();
        }

    }
}