using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Felino:Animal
    {
        public Felino(string sonidos, string alimento, string nombreCientifico) : base(sonidos, alimento, nombreCientifico)
        {
        }
    }
}
