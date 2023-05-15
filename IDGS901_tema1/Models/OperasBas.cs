using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class OperasBas
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double Res { get; set; }

        public int radio { get; set; }
        public void Suma()
        {
            this.Res = this.num1 + this.num2;
        }
        public void Resta()
        {
            this.Res = this.num1 - this.num2;
        }
        public void muliplicacion()
        {
            this.Res = this.num1 * this.num2;
        }
        public void division()
        {
            this.Res = this.num1 / this.num2;
        }

        public void operacion()
        {
            if (this.radio == 1)
            {
                Suma();
            }
            else if (this.radio == 2)
            {
                Resta();
            }
            else if (this.radio == 3)
            {
                muliplicacion();
            }
            else if (this.radio == 4)
            {
               division();
            }
        }
    }
}