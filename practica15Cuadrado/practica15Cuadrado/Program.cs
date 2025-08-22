using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica15Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            square c1 = new square(fill: false, type: comp.madera, side: 3);
            if (c1.fill == true) {
                Console.WriteLine($"Tiene relleno");
            }
            else
            {
                Console.WriteLine($"No tiene relleno");
            }
            Console.WriteLine($"Material: {c1.type}");
            Console.WriteLine($"Perimetro: {c1.perim}");
            Console.WriteLine($"Area: {c1.area}");

        }
    }
}
