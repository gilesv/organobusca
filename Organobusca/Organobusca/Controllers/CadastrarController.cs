using Organobusca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organobusca.Controllers
{
    public class CadastrarController : Controller
    {
        // GET: Cadastrar
        private dbOrg db = new dbOrg();
        public ActionResult Index()
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
            ViewBag.Feira_id = new SelectList(db.Feira.ToList(), "id", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult FeiranteFormulario(Feirante f)
        {
            ViewBag.Feira_id = new SelectList(db.Feira.ToList(), "id", "nome");
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