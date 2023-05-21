using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Traductor
    {
        public string Palabra { get; set; }
        public string Ingles { get; set; }
        public string Espaniol { get; set; }
        public int Active { get; set; }
    }
}