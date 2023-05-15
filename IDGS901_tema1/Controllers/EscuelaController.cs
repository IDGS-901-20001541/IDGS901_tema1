using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ViewResult Index()
        {
            //return Content("<h1> IDGS901-DWI </h1>");
            
            return View();
        }
        public JsonResult About()
        {
            var pulques = new Pulques()
            {
                Producto = "pulque",
                Descripcion = "Mango",
                litros = 20,
                Produccion = new DateTime(2023, 05, 2)
            };
            return Json(pulques, JsonRequestBehavior.AllowGet);
                //return View();
        }
        public RedirectResult About1(int id)
        {
            return Redirect("https/google.com");
        }

        public RedirectToRouteResult About2()
        {
            TempData["Nombre"] = "Alumno: Ana";
            return RedirectToAction("Informacion");
        }
        public ActionResult Informacion()
        {
            ViewBag.Grupo = "IDGS901";
            ViewData["Materia"] = "DWI";
            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.Nombre = nombre;
            return View();
        } 


    }
}