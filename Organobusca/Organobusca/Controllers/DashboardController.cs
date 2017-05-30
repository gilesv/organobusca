using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organobusca.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles ="cliente")]
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "feirante")]
        public ActionResult IndexFeirante()
        {
            return View();
        }
    }
}