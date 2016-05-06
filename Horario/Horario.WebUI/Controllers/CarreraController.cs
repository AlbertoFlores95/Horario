using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Abstract;
using Horario.Domain.Entities;

namespace Horario.WebUI.Controllers
{
    public class CarreraController : Controller
    {
        private ICarreraRepository repository;

        public CarreraController(ICarreraRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Carreras);
        }

        public ViewResult Edit(string Siglas)
        {
            Carrera carrera = repository.Carreras.FirstOrDefault(c => c.Carrera_Siglas == Siglas);
            return View(carrera);
        }

        [HttpPost]
        public ActionResult Edit(Carrera carrera)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCarrera(carrera);
                TempData["message"] = string.Format("{0} salvado correctamente", carrera.Carrera_Nombre);
                return RedirectToAction("Index");
            }
            else
            {
                return View(carrera);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Carrera());
        }

        [HttpPost]
        public ActionResult Delete(string siglas)
        {
            Carrera deletedCarrera = repository.DeleteCarrera(siglas);
            if (deletedCarrera != null)
            {
                TempData["message"] = string.Format("{0} fue borrado", deletedCarrera.Carrera_Nombre);
            }
            return RedirectToAction("Index");
        }

    }
}
