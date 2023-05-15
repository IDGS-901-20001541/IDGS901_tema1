using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Distancia
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double d { get; set; }


        public void calcular()
        {
            double x = this.x1 - this.x2;
            double y = this.y1 - this.y2;
            this.d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}