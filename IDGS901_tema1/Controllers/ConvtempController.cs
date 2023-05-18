using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class ConvtempController : Controller
    {
        // GET: Convtemp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularT(Temperatura t)
        {
            t.convertirF();
            return View(t);
        }
      
    }
}
