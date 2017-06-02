using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Organobusca.Models;

namespace Organobusca.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles ="cliente")]
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "feirante")]
        public ActionResult IndexFeirante()
        {
            return View();
        }
        public JsonResult FeirasJson()
        {
            dbOrg db = new dbOrg();
            var todasAsFeiras = db.Feira.ToList();
            List<object> retorno = new List<object>();
            foreach(var feira in todasAsFeiras)
            {
                retorno.Add(new
                {
                    Id = feira.id,
                    Nome = feira.nome,
                    Latitude = feira.latitude,
                    Longitude = feira.longitude
                });
            }
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
        public class IdJson
        {
            public int id { get; set; }
        }
        public PartialViewResult MostrarDetalhes(IdJson id)
        {
            dbOrg db = new dbOrg();
            var feira = db.Feira.Where(f => f.id == id.id).First();
            return PartialView(feira);
        }
        [Authorize(Roles = "cliente")]
        public ActionResult panorama()
        {
            return View();
        }
    }
}