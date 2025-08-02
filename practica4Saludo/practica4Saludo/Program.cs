using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4Saludo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, ape;
            float n1, n2, n3;

            Console.WriteLine("Ingrese su nombre:");
            nom = Console.ReadLine();
            while (nom == string.Empty)
            {
                Console.WriteLine("Ingrese su nombre:");
                nom = Console.ReadLine();
            }

            Console.WriteLine("Ingrese su apellido: ");
            ape = Console.ReadLine();
            while (ape == string.Empty)
            {
                Console.WriteLine("Ingrese su apellido:");
                ape = Console.ReadLine();
            }

            saludo(nom, ape);
            Console.ReadKey();

            Console.WriteLine("Ingrese la primer nota: ");
            n1 = float.Parse(Console.ReadLine());
            while (n1 < 0 || n1 > 10)
            {
                Console.WriteLine("Ingrese la primer nota (entre 0 y 10): ");
                n1 = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese la segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            while (n2 < 0 || n2 > 10)
            {
                Console.WriteLine("Ingrese la segunda nota (entre 0 y 10): ");
                n2 = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese la tercer nota: ");
            n3 = float.Parse(Console.ReadLine());
            while (n3 < 0 || n3 > 10)
            {
                Console.WriteLine("Ingrese la tercer nota (entre 0 y 10): ");
                n3 = float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El promedio de las notas es: {promedio(n1, n2, n3)}");
            Console.ReadKey();

            if (promedio(n1, n2, n3) >= 6)
            {
                Console.WriteLine($"{ape}, {nom} está aprobado.");
            }
            else
            {
                Console.WriteLine($"{ape}, {nom} está desaprobado.");
            }

            Console.ReadKey();

        }

        static void saludo(string nombre, string apellido)
        {
            Console.WriteLine($"Bienvenido {apellido}, {nombre}");
        }

        static float promedio(float nota1, float nota2, float nota3)
        {
            return (nota1 + nota2 + nota3)/3;
        }

    }
}
