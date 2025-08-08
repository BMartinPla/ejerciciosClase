using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6Salidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, ape, apelnom, apelnom2, hola, adios;

            Console.WriteLine("Ingrese su nombre: ");
            nom = Console.ReadLine();
            Console.Clear();
            while (nom == string.Empty)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nom = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Ingrese su apellido: ");
            ape = Console.ReadLine();
            Console.Clear();
            while (ape == string.Empty)
            {
                Console.WriteLine("Ingrese su apellido: ");
                ape = Console.ReadLine();
                Console.Clear();
            }

            nombre(nom, ape);

            apelnom = combinar(nom, ape);
            Console.WriteLine($"Ud. es: {apelnom} (Función)");
            Console.ReadKey();

            combinarPar(nom, ape, out apelnom2);
            Console.WriteLine($"Ud. es: {apelnom2} (Función en parametro)");
            Console.ReadKey();

            saludo(nom, ape, out hola, out adios);
            Console.WriteLine(hola);
            Console.WriteLine(adios);
            Console.ReadKey();

            string aux;
            int n1, n2;
            Console.WriteLine("Ingrese el primer numero: ");
            aux = Console.ReadLine();
            while (int.TryParse(aux, out n1) == false)
            {
                Console.WriteLine("Ingrese el primer numero: ");
                aux = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            aux = Console.ReadLine();
            while (int.TryParse(aux, out n2) == false)
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                aux = Console.ReadLine();
            }

            mayMen(n1, n2);
            Console.ReadKey();

            // Booleano

            int n3;

            Console.WriteLine("Ingrese el tercer numero: ");
            aux = Console.ReadLine();
            while (int.TryParse(aux, out n3) == false)
            {
                Console.WriteLine("Ingrese el tercer numero: ");
                aux = Console.ReadLine();
            }

            int min, may;

            if (mmBool(n1, n2, n3, out min, out int may) == true)
            {
                Console.WriteLine($"{may} es mayor.");
            }
            else if (mmBool(n1, n2, n3, out min, out int may) == false)
            {
                Console.WriteLine($"Hay numeros repetidos");
            }
            Console.ReadKey();
            
        }

        static void nombre(string nom, string ape)
        {
            Console.WriteLine($"{ape}, {nom}. (Parametro)");
            Console.ReadKey();
        }

        static void combinarPar(string nom, string ape, out string apenom)
        {
            apenom = $"{ape}, {nom}.";
        }

        static void saludo(string nom, string ape, out string hola, out string adios)
        {
            hola = $"Hola {ape}, {nom}.";
            adios = $"Adios {ape}, {nom}";
        }

        static void mayMen(int n1, int n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine($"El primer numero ({n1}) es mayor al segundo numero ({n2}).");
            }
            else if (n1 < n2)
            {
                Console.WriteLine($"El segundo numero ({n2}) es mayor al primer numero ({n1}).");
            }
            else
            {
                Console.WriteLine($"El primer numero ({n1}) es igual al segundo numero ({n2}).");
            }
        }

        static bool mmBool(int n1, int n2, int n3, out int min, out int max)
        {
            max = 0;
            if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                min = 0;
                max = 0;
                return false;
            }
            else if (n2 > n1 && n2 > n3)
            {
                min = 0;
                max = n2;
                return true;
                if (n1 > n3)
                {
                    min = n1;
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                max = n3;
                return true;
            }
            else if (n1 > n2 && n1 > n3)
            {
                max = n1;
                return true;
            }
            else
            {
                return false;
            }
        }

        static string combinar(string nom, string ape)
        {
            string resul = $"{ape}, {nom}.";

            return resul;
        }

    }
}
