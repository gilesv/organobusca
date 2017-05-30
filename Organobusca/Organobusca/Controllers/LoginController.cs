using Organobusca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organobusca.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private dbOrg db = new dbOrg();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(string email, string senha)
        {
            if (ModelState.IsValid)
            {
                var v = db.Cliente.Where(a => a.email.Equals(email) && a.senha.Equals(senha)).FirstOrDefault();
                if (v != null)
                {
                    Session["usuarioLogadoId"] = v.id.ToString();
                    Session["nomeUsuarioLogado"] = v.nome.ToString();
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Login ou senha inválido!");
            return View();
        }
    }
}