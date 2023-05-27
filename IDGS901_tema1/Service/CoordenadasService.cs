using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using traductor.Models;

namespace traductor.Services
{
    public class CoordenadasService
    {
        public void calcular(Coordenadas cor)
        {
            double x = cor.x2 - cor.x1;
            double y = cor.y2 - cor.y1;
            cor.lado1 = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            double x1 = cor.x3 - cor.x2;
            double y1 = cor.y3 - cor.y2;
            cor.lado2 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            double x2 = cor.x1 - cor.x3;
            double y2 = cor.y1 - cor.y3;
            cor.lado3 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            double p = cor.lado1 + cor.lado2 + cor.lado3;
            double sp = p / 2;

            cor.area = Math.Sqrt((sp * (sp - cor.lado1) * (sp - cor.lado2) * (sp - cor.lado3)));

            double ladov1 = Math.Round(cor.lado1, 2);
            double ladov2 = Math.Round(cor.lado2, 2);
            double ladov3 = Math.Round(cor.lado3, 2);

            double s1 = cor.lado1 + cor.lado2;
            double s2 = cor.lado2 + cor.lado3;
            double s3 = cor.lado3 + cor.lado1;

            if (s1 > ladov3 && s2 > ladov1 && s3 > ladov2)
            {
                if (ladov1 == ladov2 && ladov2 == ladov3 && ladov1 == ladov3)
                {
                    cor.tipo = "Equilatero";
                }
                else if ((ladov1 == ladov2 || ladov2 == ladov3 || ladov1 == ladov3) && (ladov1 != ladov2 || ladov2 != ladov3 || ladov1 != ladov3))
                {
                    cor.tipo = "Isoceles";
                }
                else if ((ladov1 != ladov2) && (ladov2 != ladov3) && (ladov1 != ladov3))
                {
                    cor.tipo = "Escaleno";

                }
            }
            else
            {
                cor.tipo = "Las coordenadas no forman un triangulo";
                cor.area = 0;

            }
          
            
        }

    }
}