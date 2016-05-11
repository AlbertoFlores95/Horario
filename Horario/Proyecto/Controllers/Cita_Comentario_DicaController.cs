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
    public class Cita_Comentario_DicaController : Controller
    {
        private HorarioEntities db = new HorarioEntities();

        // GET: Cita_Comentario_Dica
        public ActionResult Index()
        {
            var cita_Comentario_Dica = db.Cita_Comentario_Dica.Include(c => c.Cita);
            return View(cita_Comentario_Dica.ToList());
        }

        // GET: Cita_Comentario_Dica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cita_Comentario_Dica cita_Comentario_Dica = db.Cita_Comentario_Dica.Find(id);
            if (cita_Comentario_Dica == null)
            {
                return HttpNotFound();
            }
            return View(cita_Comentario_Dica);
        }

        // GET: Cita_Comentario_Dica/Create
        public ActionResult Create()
        {
            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo");
            return View();
        }

        // POST: Cita_Comentario_Dica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Folio,Comentario")] Cita_Comentario_Dica cita_Comentario_Dica)
        {
            if (ModelState.IsValid)
            {
                db.Cita_Comentario_Dica.Add(cita_Comentario_Dica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo", cita_Comentario_Dica.Folio);
            return View(cita_Comentario_Dica);
        }

        // GET: Cita_Comentario_Dica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cita_Comentario_Dica cita_Comentario_Dica = db.Cita_Comentario_Dica.Find(id);
            if (cita_Comentario_Dica == null)
            {
                return HttpNotFound();
            }
            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo", cita_Comentario_Dica.Folio);
            return View(cita_Comentario_Dica);
        }

        // POST: Cita_Comentario_Dica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Folio,Comentario")] Cita_Comentario_Dica cita_Comentario_Dica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cita_Comentario_Dica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Folio = new SelectList(db.Citas, "Folio", "Correo", cita_Comentario_Dica.Folio);
            return View(cita_Comentario_Dica);
        }

        // GET: Cita_Comentario_Dica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cita_Comentario_Dica cita_Comentario_Dica = db.Cita_Comentario_Dica.Find(id);
            if (cita_Comentario_Dica == null)
            {
                return HttpNotFound();
            }
            return View(cita_Comentario_Dica);
        }

        // POST: Cita_Comentario_Dica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cita_Comentario_Dica cita_Comentario_Dica = db.Cita_Comentario_Dica.Find(id);
            db.Cita_Comentario_Dica.Remove(cita_Comentario_Dica);
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
