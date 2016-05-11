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
    public class DicasController : Controller
    {
        private HorarioEntities db = new HorarioEntities();

        // GET: Dicas
        public ActionResult Index()
        {
            return View(db.Dicas.ToList());
        }

        // GET: Dicas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dica dica = db.Dicas.Find(id);
            if (dica == null)
            {
                return HttpNotFound();
            }
            return View(dica);
        }

        // GET: Dicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nomina,Nombre,Apellido_Paterno,Apellido_Materno,Correo")] Dica dica)
        {
            if (ModelState.IsValid)
            {
                db.Dicas.Add(dica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dica);
        }

        // GET: Dicas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dica dica = db.Dicas.Find(id);
            if (dica == null)
            {
                return HttpNotFound();
            }
            return View(dica);
        }

        // POST: Dicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nomina,Nombre,Apellido_Paterno,Apellido_Materno,Correo")] Dica dica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dica);
        }

        // GET: Dicas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dica dica = db.Dicas.Find(id);
            if (dica == null)
            {
                return HttpNotFound();
            }
            return View(dica);
        }

        // POST: Dicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Dica dica = db.Dicas.Find(id);
            db.Dicas.Remove(dica);
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
