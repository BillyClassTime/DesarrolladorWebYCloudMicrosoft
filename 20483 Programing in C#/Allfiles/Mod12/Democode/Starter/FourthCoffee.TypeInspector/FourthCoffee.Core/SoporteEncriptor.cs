using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthCoffee.Core
{
    class SoporteEncriptor
    {
        public string Nombre;
        public int IdSoporte { get; set; }

        SoporteEncriptor(int NoSoporte)
        {

        }

        public string NombresACifrar()
        {
            return "Nombre";
        }
    }
}
