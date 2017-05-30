using Organobusca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organobusca.Controllers
{
    public class FeiranteController : Controller
    {
        // GET: Feirante
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