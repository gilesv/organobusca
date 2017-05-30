﻿using Organobusca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
                var f = db.Feirante.Where(a => a.email.Equals(email) && a.senha.Equals(senha)).FirstOrDefault();

                if (v != null || f != null)
                {
                    string nome = string.Empty;

                    if (v != null)
                    {   
                        Session["usuario"] = v;
                        nome = v.nome;
                        FormsAuthentication.RedirectFromLoginPage(nome, false);
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else if (f != null)
                    {
                        Session["usuario"] = f;
                        nome = f.nome;
                        FormsAuthentication.RedirectFromLoginPage(nome, false);
                        return RedirectToAction("IndexFeirante", "Dashboard");
                    }
                    //FormsAuthentication.SignOut();
                    //Session.Clear();
                    //Session["usuarioLogadoId"] = v.id.ToString();
                    //Session["nomeUsuarioLogado"] = v.nome.ToString();
                    return View();
                }
            }
            ModelState.AddModelError("", "Login ou senha inválido!");
            return View();
        }
    }
}