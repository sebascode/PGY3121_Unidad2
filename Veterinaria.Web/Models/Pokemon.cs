using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Web.Models
{
    public class Pokemon
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Altura { get; set; }
        public string Tipo { get; set; }
        public int Peso { get; set; }
        public bool esChainih { get; set; }

        public Pokemon()
        {

        }
    }
}
