using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Canido:Animal
    {
        public Canido(string sonidos, string alimento, string nombreCientifico) : base(sonidos, alimento, nombreCientifico)
        {
        }

        public void correr()
        {
            Console.WriteLine("puede correr\n");
        }
        
    }
}
