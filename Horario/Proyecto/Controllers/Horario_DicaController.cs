using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class Horario_DicaController : Controller
    {
        private HorarioEntities db = new HorarioEntities();

        // GET: Horario_Dica
        public ActionResult Index()
        {
            var horario_Dica = db.Horario_Dica.Include(h => h.Dica);
            return View(horario_Dica.ToList());
        }

        // GET: Horario_Dica/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horario_Dica horario_Dica = db.Horario_Dica.Find(id);
            if (horario_Dica == null)
            {
                return HttpNotFound();
            }
            return View(horario_Dica);
        }

        // GET: Horario_Dica/Create
        public ActionResult Create()
        {
            ViewBag.Nomina = new SelectList(db.Dicas, "Nomina", "Nombre");
            return View();
        }

        // POST: Horario_Dica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nomina,Dia,HoraInicio,HoraFin")] Horario_Dica horario_Dica)
        {
            if (ModelState.IsValid)
            {
                db.Horario_Dica.Add(horario_Dica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Nomina = new SelectList(db.Dicas, "Nomina", "Nombre", horario_Dica.Nomina);
            return View(horario_Dica);
        }

        // GET: Horario_Dica/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horario_Dica horario_Dica = db.Horario_Dica.Find(id);
            if (horario_Dica == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nomina = new SelectList(db.Dicas, "Nomina", "Nombre", horario_Dica.Nomina);
            return View(horario_Dica);
        }

        // POST: Horario_Dica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nomina,Dia,HoraInicio,HoraFin")] Horario_Dica horario_Dica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horario_Dica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Nomina = new SelectList(db.Dicas, "Nomina", "Nombre", horario_Dica.Nomina);
            return View(horario_Dica);
        }

        // GET: Horario_Dica/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horario_Dica horario_Dica = db.Horario_Dica.Find(id);
            if (horario_Dica == null)
            {
                return HttpNotFound();
            }
            return View(horario_Dica);
        }

        // POST: Horario_Dica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Horario_Dica horario_Dica = db.Horario_Dica.Find(id);
            db.Horario_Dica.Remove(horario_Dica);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
