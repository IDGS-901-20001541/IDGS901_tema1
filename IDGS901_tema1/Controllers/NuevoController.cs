using IDGS901_tema1.Models;
using IDGS901_tema1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperasBas( String n1, String n2 ,String radio)
        {
            int res;
            int op = Convert.ToInt16(radio);
            if (op == 1)
            {
               res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            else if(op == 2)
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            else if(op ==3) 
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            else
            {
                if(Convert.ToInt16(n2) == 0)
                {
                    res = 0;
                }
                else
                {
                    res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                }
            }
           
           
            ViewBag.Res = res;

            return View();
        }
        public ActionResult MuestraPulques()
        {
            var PulquesService1 = new PulquesService();
            var model = PulquesService1.ObtenerPulque();

            return View(model);

        }

        public ActionResult Calculos(OperasBas op, String radio)

        {
            op.operacion();
            return View(op);
        }
    }
}