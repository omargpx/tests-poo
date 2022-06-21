using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Animal:informacion
    {
        //  Atributos
        public string sonidos { get; set; }
        public string alimento { get; set; }
        public string nombreCientifico { get; set; }

        public Animal() { }
        public Animal(string sonidos, string alimento, string nombreCientifico)
        {
            this.sonidos = sonidos;
            this.alimento = alimento;
            this.nombreCientifico = nombreCientifico;
        }

        public void descripcion(List<Animal> animal)
        {
            /*
             Console.WriteLine("Sonidos: " + sonidos);
            Console.WriteLine("Alimento: "+ alimento);
            Console.WriteLine("Nombre Científico: "+ nombreCientifico);
             */

            for (int i = 0; i < animal.Count; i++)
            {
                Console.WriteLine(animal[i]);
                Console.WriteLine("sonido: "+animal[i].sonidos+"; Alimentación: " + animal[i].alimento+"; Nombre Científico: "+ animal[i].nombreCientifico);
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \n");
            }
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("                             Fin del informe\n");
            Console.ResetColor();
        }
    }
    class informacion
    {
        public void informe()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Generando informe . . . . .\n");
            Console.ResetColor();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            Animal animal = new Animal();
            List<Animal> animalList = new List<Animal>();

            Perro perro = new Perro("ladrido", "carnívora", "canis lupus familiaris");
            Lobo lobo = new Lobo("aullido", "carnívora", "canis lupus");
            Leon leon = new Leon("rugido", "carnívora", "phantera leo");
            Gato gato = new Gato("maullido", "ratones", "felis silvestris catus");

            animalList.Add(perro);
            animalList.Add(lobo);
            animalList.Add(leon);
            animalList.Add(gato);

            animal.descripcion(animalList);
 
        }
    }
}
