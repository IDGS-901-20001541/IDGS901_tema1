using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.Mvc;
using traductor.Models;
using traductor.Services;

namespace traductor.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Calcular(Coordenadas cor)
        {
            var triangulos = new CoordenadasService();
            triangulos.calcular(cor);
            ViewBag.Resulado = cor;
            return View(cor);
        }


    }
}
