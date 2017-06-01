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
        [Authorize(Roles = "feirante")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "feirante")]
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "feirante")]
        public ActionResult Criar(Feira f, int[] dia, TimeSpan[] hora_inicio, TimeSpan[] hora_fim)
        {
            for(int i = 0; i < dia.Length; i++)
            {
                DiaDaSemana horarioDia = new DiaDaSemana();
                horarioDia.dia = dia[i];
                horarioDia.hora_inicio = hora_inicio[i];
                horarioDia.hora_fim = hora_fim[i];
                horarioDia.Feira_id = f.id;

                db.DiaDaSemana.Add(horarioDia);
            }
            db.Feira.Add(f);
            db.SaveChanges();
            return View("Listar");
        }
        [Authorize(Roles = "feirante")]
        public ActionResult Listar()
        {
            return View(db.Feira.ToList());
        }
        [Authorize(Roles = "feirante")]
        public ActionResult Excluir(int id)
        {
            var remover = db.Feira.Where(m => m.id == id).FirstOrDefault();
            db.Feira.Remove(remover);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }
        [Authorize(Roles = "feirante")]
        [HttpPost]
        public PartialViewResult HorarioFuncionamentoPartial()
        {
            return PartialView();
        }
    }
}