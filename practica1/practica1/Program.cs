using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, ape, sal;

            Console.WriteLine("Ingrese su nombre: ");
            nom = Console.ReadLine();
            while (nom == string.Empty)
            {
                Console.WriteLine("El nombre no puede ser nulo.");
                Console.ReadKey();
                Console.WriteLine("Ingrese su nombre: ");
                nom = Console.ReadLine();
            }

            Console.WriteLine("Ingrese su apellido: ");
            ape = Console.ReadLine();
            while (ape == string.Empty)
            {
                Console.WriteLine("El apellido no puede ser nulo.");
                Console.ReadKey();
                Console.WriteLine("Ingrese su apellido: ");
                ape = Console.ReadLine();
            }

            formatear(nom, ape);

            Console.WriteLine($"Hola {formatea2(nom, ape)}");
            Console.WriteLine($"Adios {formatea2(nom, ape)}");
            Console.ReadKey();

            formatearPlus(nom, ape, out sal);
            Console.WriteLine($"Hola {sal}");
            Console.WriteLine($"Adios {sal}");
            Console.ReadKey();



        }

        static void formatear(string n, string a)
        {
            Console.WriteLine($"Hola {a}, {n}");
            Console.ReadKey();
        }

        static void formatearPlus(string n, string a, out string combinado)
        {
            combinado = $"{a}, {n}";
        }

        static string formatea2(string n, string a)
        {
            string apelnom;
            apelnom = $"{a}, {n}";
            return apelnom;

        }
    }
}