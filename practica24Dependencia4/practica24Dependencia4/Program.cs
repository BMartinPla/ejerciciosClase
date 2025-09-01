using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica24Dependencia4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human human1 = new human("Roger", "Thompson", 23, typeEth.Americano);
            Console.WriteLine($"HUMANO");
            Console.WriteLine($"Nombre: {human1.name}");
            Console.WriteLine($"Apellido: {human1.surname}");
            Console.WriteLine($"Edad: {human1.age}");
            Console.WriteLine($"Etnia: {human1.ethnicity}");
            Console.ReadKey();

            dog dog1 = new dog("Negra", 10, typeRace.Calle, typeSize.Mediano);
            Console.WriteLine($"PERRO");
            Console.WriteLine($"Nombre: {dog1.name}");
            Console.WriteLine($"Edad: {dog1.age}");
            Console.WriteLine($"Raza: {dog1.race}");
            Console.WriteLine($"Tamaño: {dog1.size}");
            Console.ReadKey();
        }
    }
}
