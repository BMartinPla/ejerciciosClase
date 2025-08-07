using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = 10;
            int w = 10;
            int e = 10;
            int resultado;

            resultado = sumar(q, w);
            Console.WriteLine(resultado);
            Console.ReadKey();

            // Referencia

            int numero = 20;
            agregarCinco(ref numero);
            Console.WriteLine(numero);
            Console.ReadKey();

            // Parsear

            int n1, n2;
            string aux;

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
                Console.WriteLine("Ingrese el primer numero: ");
                aux = Console.ReadLine();
            }

            Console.WriteLine($"El resultado es {n1 + n2}");
            Console.ReadKey();

            // Parsear con verificacion

            string numA, numB;
            int nA, nB;

            Console.WriteLine("Ingrese el primer numero: ");
            numA = Console.ReadLine(); // Parsea a entero de lo que ingrese por teclado
            while (int.TryParse(numA, out nA) == false)
            {
                Console.WriteLine("Ingrese el primer numero: ");
                numA = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            numB = Console.ReadLine();
            while (int.TryParse(numB, out nB) == false)
            {
                Console.WriteLine("Ingrese el primer numero: ");
                numB = Console.ReadLine();
            }

            Console.WriteLine($"El resultado es {nA + nB}");
            Console.ReadKey();

        }

        static int sumar(int a, int b, int c = 0)
        {
            return a + b + c;
        }

        static void agregarCinco(ref int num)
        {
            num = num + 5;
        }

    }
}
