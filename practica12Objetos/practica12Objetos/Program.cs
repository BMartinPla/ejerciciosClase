using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica12Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();

            p1.name = "Carlito";
            p1.age = 10;

            Console.WriteLine("Persona 1");
            Console.WriteLine($"El nombre es: {p1.name}");
            Console.WriteLine($"La edad es: {p1.age}");
            Console.ReadKey();

            person p2 = new person("Pedrito", 8);

            Console.WriteLine("Persona 2");
            Console.WriteLine($"El nombre es: {p2.name}");
            Console.WriteLine($"La edad es: {p2.age}");
            Console.ReadKey();

            person p3 = new person("Juanito", 9, "Paraguayo");

            Console.WriteLine("Persona 3");
            Console.WriteLine($"El nombre es: {p3.name}");
            Console.WriteLine($"La edad es: {p3.age}");
            Console.WriteLine($"La nacionalidad es: {p3.nation}");
            Console.ReadKey();
        }
    }
}
