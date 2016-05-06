using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Horario.Domain.Abstract;

namespace Horario.WebUI.Controllers
{
    public class DicaController : Controller
    {

        private IDicaRepository repository;


        public DicaController(IDicaRepository dicaRepository)
        {
            repository = dicaRepository;
        }

        public ViewResult List()
        {
            return View(repository);
        }
    }
}
