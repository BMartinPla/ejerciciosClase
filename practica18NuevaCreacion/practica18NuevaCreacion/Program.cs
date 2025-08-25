using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica18NuevaCreacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            phone POCO = new phone(comp.Xiaomi, 5, comp2.Personal, new @case(comp3.Opaca, "Rojo"));
            Console.WriteLine($"CELULAR");
            Console.WriteLine($"Marca: {POCO.brand}");
            Console.WriteLine($"Pulgadas: {POCO.inch}");
            Console.WriteLine($"Compania: {POCO.data}");
            Console.WriteLine($"FUNDA");
            Console.WriteLine($"Tipo: {POCO.phonecase.tipo}");
            Console.WriteLine($"Color: {POCO.phonecase.color}");
            Console.ReadKey();

        }
    }
}
