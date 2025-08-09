using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practica10Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fib=0;
            int cn;
            int aux=1;
            int na;
            string aux2;

            Console.WriteLine("Ingrese la cantidad de numeros a mostrar");
            aux2 = (Console.ReadLine());
            while (int.TryParse(aux2, out cn) == false)
            {
                Console.WriteLine("Ingrese la cantidad de numeros a mostrar");
                aux2 = (Console.ReadLine());
            }

            for (int i = 0; i < cn; i++)
            {
                Console.WriteLine($"{fib}");
                na = fib;
                fib = fib + aux;
                aux = na;
            }
            Console.ReadKey();

        }
    }
}
