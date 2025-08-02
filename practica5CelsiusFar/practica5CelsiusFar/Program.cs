using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5CelsiusFar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tiptemp, temp;

            Console.WriteLine("Ingrese el tipo de temperatura que desea convertir: \n1. Celsius a Fahrenheit \n2. Fahrenheit a Celsius");
            tiptemp = float.Parse(Console.ReadLine());
            while (tiptemp != 1 && tiptemp != 2)
            {
                Console.WriteLine("Opción no válida. Ingrese 1 o 2.");
                tiptemp = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese la temperatura actual: ");
            temp = float.Parse(Console.ReadLine());

            if (tiptemp == 1)
            {
                Console.WriteLine($"Celsius: {temp}\nFahrenheit: {celaf(temp)}");
                Console.ReadKey();
            }
            else if (tiptemp == 2)
            {
                Console.WriteLine($"Fahrenheit: {temp}\nCelsius: {farac(temp)}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Temperatura no valida.");
                Console.ReadKey();
            }

        }

        static float celaf(float temp)
        {
            return (temp * 9 / 5) + 32;
        }

        static float farac(float temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
