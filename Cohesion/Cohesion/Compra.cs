using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion
{
    public class Compra
    {
        public int id { get; set; }
        public CiudadEnum ciudadEnum { get; set; }
        public int valor { get; set; }

        public Compra(int id, CiudadEnum ciudadEnum, int valor)
        {
            this.id = id;
            this.ciudadEnum = ciudadEnum;
            this.valor = valor;
        }
    }
}
