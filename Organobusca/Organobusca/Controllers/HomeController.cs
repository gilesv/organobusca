using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Organobusca.Models;

namespace Organobusca.Controllers
{
    public class HomeController : Controller
    {
        private dbOrg db = new dbOrg();
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

        [HttpPost]
        public ActionResult login(string email)
        {
            var result = db.Cliente.FirstOrDefault(model => model.email.ToLower() != email);
            return Json(result);
        }
    }
}