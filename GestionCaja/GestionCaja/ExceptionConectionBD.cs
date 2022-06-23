using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCaja
{
    internal class ExceptionConectionBD:Exception
    {
        public ExceptionConectionBD(string bdName) :base($"No se pudo conectar con la DB de {bdName}"){}
    }
}
