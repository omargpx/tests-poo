using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Perro : Canido
    {
        public Perro(string sonidos, string alimento, string nombreCientifico) : base(sonidos, alimento, nombreCientifico)
        {
        }
    }
}
