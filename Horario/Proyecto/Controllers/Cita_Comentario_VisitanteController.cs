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
    public class Cita_Comentario_VisitanteController : Controller
    {
        private HorarioEntities db = new HorarioEntities();

        // GET: Cita_Comentario_Visitante
        public ActionResult Index()
        {
            var cita_Comentario_Visitante = db.Cita_Comentario_Visitante.Include(c => c.Cita);
            return View(cita_Comentario_Visitante.ToList());
        }

        // GET: Cita_Comentario_Visitante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cita_Comentario_Visitante cita_Comentario_Visitante = db.Cita_Comentario_Visitante.Find(id);
            if (cita_Comentario_Visitante == null)
            {
                return HttpNotFound();
            }
            return View(cita_Comentario_Visitante);
        }

        // GET: Cita_Comentario_Visitante/Create
        public ActionResult Create()
        {
            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo");
            return View();
        }

        // POST: Cita_Comentario_Visitante/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Folio,Comentario")] Cita_Comentario_Visitante cita_Comentario_Visitante)
        {
            if (ModelState.IsValid)
            {
                db.Cita_Comentario_Visitante.Add(cita_Comentario_Visitante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo", cita_Comentario_Visitante.Folio);
            return View(cita_Comentario_Visitante);
        }

        // GET: Cita_Comentario_Visitante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cita_Comentario_Visitante cita_Comentario_Visitante = db.Cita_Comentario_Visitante.Find(id);
            if (cita_Comentario_Visitante == null)
            {
                return HttpNotFound();
            }
            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo", cita_Comentario_Visitante.Folio);
            return View(cita_Comentario_Visitante);
        }

        // POST: Cita_Comentario_Visitante/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Folio,Comentario")] Cita_Comentario_Visitante cita_Comentario_Visitante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cita_Comentario_Visitante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo", cita_Comentario_Visitante.Folio);
            return View(cita_Comentario_Visitante);
        }

        // GET: Cita_Comentario_Visitante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cita_Comentario_Visitante cita_Comentario_Visitante = db.Cita_Comentario_Visitante.Find(id);
            if (cita_Comentario_Visitante == null)
            {
                return HttpNotFound();
            }
            return View(cita_Comentario_Visitante);
        }

        // POST: Cita_Comentario_Visitante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cita_Comentario_Visitante cita_Comentario_Visitante = db.Cita_Comentario_Visitante.Find(id);
            db.Cita_Comentario_Visitante.Remove(cita_Comentario_Visitante);
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
