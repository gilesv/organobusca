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
        public ActionResult ClienteFormulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteFormulario(Cliente c)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(c);
                TempData["mensagem"] = "Cadastrado com sucesso!";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //public ActionResult ClienteResultado(Cliente c)
        //{
        //    return View(c);
        //}

        public ActionResult FeiranteFormulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FeiranteFormulario(Feirante f)
        {
            if (ModelState.IsValid)
            {
                TempData["mensagem"] = "Cadastrado com sucesso!";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //public ActionResult FeiranteResultado(Feirante f)
        //{
        //    return View(f);
        //}
    }
}