using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace traductor.Models
{
    public class Palabras
    {
        public string Palabra { get; set; }
        public string Ingles { get; set; }
        public string Espaniol { get; set; }
        public int Active { get; set; }
    }
}