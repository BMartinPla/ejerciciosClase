using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ct;
            string tri="";
            int aux=1;

            Console.WriteLine("Ingrese la cantidad de numeros para el triangulo: ");
            ct = int.Parse(Console.ReadLine());

            for (int i = 0; i < ct-2; i++)
            {
                Console.WriteLine(tri);
                /*
                for (int j=0; j < 1; j++)
                {
                    Console.WriteLine(tri);
                } */
                tri = aux + tri;
                aux = aux + 2;
            }
            Console.ReadKey();
        }
    }
}
