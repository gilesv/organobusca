using Organobusca.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Organobusca.Controllers
{
    public class EditarController : Controller
    {
        // GET: Editar
        private dbOrg db = new dbOrg();
        [Authorize(Roles = "cliente")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Cliente c)
        {
            List<Cliente> dbList = db.Cliente.ToList<Cliente>();
            foreach (var item in dbList)
            { 
                if (item.id == c.id || true)
                {
                    db.Cliente.Remove(item);
                    db.Cliente.Add(c);
                    db.SaveChanges();
                    TempData["mensagem"] = "Alterado com sucesso!";
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return View();
        }
    }
}