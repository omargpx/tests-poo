using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cohesion;

namespace Cohesion
{
    public interface ITipoCalculo
    {
        public decimal Calcular(Compra compra);
    }
}
