using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class DistanciapuntosController : Controller
    {
        // GET: Distanciapuntos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(Distancia dis)
        { 
            dis.calcular();
            ViewBag.Resulado = dis;
            return View(dis);
        }

    }
}
