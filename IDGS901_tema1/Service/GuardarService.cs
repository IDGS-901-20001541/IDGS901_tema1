using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Service
{
    public class GuardarService
    {
        public void Guardar(Maestros maes)
        {
            var mat = maes.Maricula;
            var nom = maes.Nombre;
            var apa = maes.Apaterno;
            var ama = maes.Amaterno;
            var email = maes.Email;

            var datos = mat + ", " + nom + ", " + apa + ", " + ama + ", " + email +","+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Datos.txt");
            File.AppendAllText(archivo, datos);
            
        }
    }
}