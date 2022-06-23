using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion
{
    public class CalcularPrecio
    {
        private ITipoCalculo calculo;

        public void descuento(ITipoCalculo c)
        {
            this.calculo = c;
        }

        public decimal CalcularCompra(Compra compra)
        {
            try
            {
                return calculo.Calcular(compra);
            }
            catch(Exception e)
            {
                return 0;
            }
        }
    }
}
