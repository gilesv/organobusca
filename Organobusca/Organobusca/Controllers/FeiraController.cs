using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Organobusca.Models;

namespace Organobusca.Controllers
{
    public class FeiraController : Controller
    {
        // GET: Feira
        private dbOrg db = new dbOrg();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Feira f)
        {
            db.Feira.Add(f);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            return View(db.Feira.ToList());
        }
    }
}