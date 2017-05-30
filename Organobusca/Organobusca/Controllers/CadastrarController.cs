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
                if (db.Cliente.FirstOrDefault(a => a.email == c.email) == null)
                {
                    db.Cliente.Add(c);
                    db.SaveChanges();
                    TempData["mensagem"] = "Cadastrado com sucesso!";
                    return RedirectToAction("Index", "Dashboard");
                }
                ModelState.AddModelError("", "Email já existente!");
                return View();
            }
            return View();
        }

        //public ActionResult ClienteResultado(Cliente c)
        //{
        //    return View(c);
        //}

        public ActionResult FeiranteFormulario()
        {
            //ViewBag.Feira_id = new SelectList(db.Feira.ToList(), "id", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult FeiranteFormulario(Feirante f)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Feira_id = new SelectList(db.Feira.ToList(), "id", "nome");
                if (db.Feirante.FirstOrDefault(a => a.email == f.email) == null)
                {
                    db.Feirante.Add(f);
                    db.SaveChanges();
                    TempData["mensagem"] = "Cadastrado com sucesso!";
                    return RedirectToAction("Index", "Dashboard");
                }
                ModelState.AddModelError("", "Email já existente!");
                return View();
            }
            return View();
        }

        //public ActionResult FeiranteResultado(Feirante f)
        //{
        //    return View(f);
        //}
    }
}