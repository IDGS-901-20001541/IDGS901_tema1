using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Service
{
    public class TraductorServices
    {
        public void GuardarP(Traductor p)
        {
            var pI = p.Ingles;
            var pE = p.Espaniol;

            var datosE = pE + "-" + pI + "," + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");

            File.AppendAllText(archivo, datosE.ToLower());

        }
        public Array LeerArchivo()
        {
            Array palabra = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(archivo))
            {
                palabra = File.ReadAllLines(archivo);
            }
            return palabra;
        }
        public Array Buscar()
        {

            Array palabras = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(archivo))
            {
                palabras = File.ReadAllLines(archivo);
                palabras
            }

            return palabras;
        }
    }
}