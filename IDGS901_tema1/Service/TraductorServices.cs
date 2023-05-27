using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using traductor.Models;

namespace traductor.Services
{
    public class TraductorServices
    {
        public void GuardarP(Palabras p)
        {
            var pI = p.Ingles;
            var pE = p.Espaniol;

            var datosE = pE + " - " + pI + "," + Environment.NewLine;
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


        public String Traducir(Palabras t)
        {
            string palabra = null;
            String buscarP = t.Palabra.ToLower();
            int botton = t.Active;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(archivo))
            {
                string[] lines = File.ReadAllLines(archivo);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(buscarP))
                    {


                        string palabrasearch = lines[i];
                        string[] palabrasSeparadas = palabrasearch.Split('-');


                        string palabra1 = palabrasSeparadas[0];//español
                        string palabra2 = palabrasSeparadas[1];//ingles
                        if (botton == 0)
                        {
                            palabra = "La traduccion de " + buscarP + " es " + palabra1;
                        }
                        else
                        {
                            palabra = "La traduccion de " + buscarP + " es " + palabra2.Replace(",", "");
                        }

                    }

                }

            }
            return palabra;
        }
    }
}