using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica14SumaMult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vIni = 1;
            int vIng;
            int s = 0;
            int aux = 0;

            Console.WriteLine("Ingrese el numero");
            vIng = int.Parse(Console.ReadLine());

            int sum = vIni;
            int mul = vIni;

            /*
            while (s != 1)
            {
                
               

                if(vIng != sum)
                {
                    if (vIng != sum*3)
                    {
                        mul = mul * 3;
                    }
                    else{
                        s = 1;
                        Console.WriteLine("True");
                        Console.ReadKey();
                    }
                }
                else{
                    s = 1;
                    Console.WriteLine("True");
                    Console.ReadKey();
                }

                sum = sum + 5;

                
                if (vIng == sum || vIng == mul)
                {
                    s = 1;
                    Console.WriteLine($"True");
                    Console.ReadKey();
                }
                
            }
            */

            for (int i = 1; i <= vIng; i = i * 3)
            {
                aux = i;
                for (int k = aux; k <=vIng; k = k + 5)
                {
                    if (vIng == k)
                    {
                        Console.WriteLine("True");
                        Console.ReadKey();
                    }
                }
            }

            if (vIng == aux)
            {
                Console.WriteLine("True");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("False");
                Console.ReadKey();
            }
        }
    }
}
