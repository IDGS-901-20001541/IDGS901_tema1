using IDGS901_tema1.Models;
using IDGS901_tema1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Registrar()
        {
           
            return View();
        }
        [HttpPost] 
        public ActionResult Registrar(Maestros maes)
        {
            var op = new GuardarService();
            op.Guardar(maes);
            return View();
        }
        public ActionResult LeerDatos()
        {
            var archi = new LeerServices();
            ViewBag.Archivos = archi.LeerArchivo();
            return View();
        }

    }
}
