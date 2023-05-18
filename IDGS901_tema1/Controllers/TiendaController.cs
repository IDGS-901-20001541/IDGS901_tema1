using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TiendaController : Controller
    {
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Daniela",
                Edad = 20,
                Empleado = true,
                Nacimiento = new DateTime(2001, 11, 3)
            };

            ViewBag.Persona = persona;

            return View();
        }

        public ActionResult Registrar()
        {
            var persona = new Persona();

            return View();
        }
        public ActionResult Registrar2()
        {
            var persona = new Persona();

            return View();
        }

    }
}