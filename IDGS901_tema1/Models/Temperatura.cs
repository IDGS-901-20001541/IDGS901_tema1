using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Temperatura
    {
      public double temperaura { get; set; }
        public double gradosF { get; set; }
        public double gradosC { get; set; }

        public int Activo { get; set; }
        public String resulatado { get; set; }
        public void convertirF()
        {
            if (this.Activo == 1)
            {
                this.gradosC = (this.temperaura - 32) / 1.8;
                this.resulatado = this.gradosC +"°C";
            }else if (this.Activo==2)
            {
                this.gradosF =  this.temperaura * 1.8 + 32;
                this.resulatado = this.gradosF+"°F";
            }
            
        }
       

    }
}