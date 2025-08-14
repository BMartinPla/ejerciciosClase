using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica13Objetos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car camaro = new car("Chevrolet", 1970, 3);

            mostrar(camaro);
        }

        static void mostrar (car veh)
        {
            Console.WriteLine($"Marca: {veh.brand}");
            Console.WriteLine($"Modelo: {veh.year}");
            Console.WriteLine($"Puertas: {veh.doors}");
            Console.ReadKey();
        }
    }
}
