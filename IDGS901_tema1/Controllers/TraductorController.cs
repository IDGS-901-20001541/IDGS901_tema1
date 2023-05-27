using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traductor.Models;
using traductor.Services;

namespace traductor.Controllers
{
    public class TraductorController : Controller
    {
        public ActionResult Registrar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Palabras p)
        {
            var op = new TraductorServices();
            op.GuardarP(p);
            return View();
        }
        
        public ActionResult LeerDatos()
        {
            var archi = new TraductorServices();
            ViewBag.Archivos = archi.LeerArchivo(); ;
            return View();
        }

        
        public ActionResult Buscar(int b)
        {


            return View();
        }


        [HttpPost]
        public ActionResult Buscar(Palabras b)
        {
           
                var archi = new TraductorServices();
                ViewBag.Palabra = archi.Traducir(b);
           

            return View();
        }
    }
}
