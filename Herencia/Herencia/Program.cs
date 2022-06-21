using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro cactus = new Perro("ladrido", "croquetas", "folus");
            informacion i = new informacion();
            i.informe();
        }
    }
}

