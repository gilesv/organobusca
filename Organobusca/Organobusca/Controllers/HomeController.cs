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
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Opcoes()
        {
            return View();
        }
        public ActionResult ClienteFormulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteFormulario(Cliente c)
        {
            if (ModelState.IsValid)
            {
                return View("ClienteResultado", c);
            }
            return View();
        }

        public ActionResult ClienteResultado(Cliente c)
        {
            return View(c);
        }

        public ActionResult FeiranteFormulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FeiranteFormulario(Feirante f)
        {
            if (ModelState.IsValid)
            {
                return View("FeiranteResultado", f);
            }
            return View();
        }

        public ActionResult FeiranteResultado(Feirante f)
        {
            return View(f);
        }
    }
}