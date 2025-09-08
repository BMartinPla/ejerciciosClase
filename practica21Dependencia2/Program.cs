using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica21Dependencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tragaperras n1 = new tragaperras();
            n1.apuesta = 500;
            n1.prize = kprize.TresSiete;
            n1.cApuestas = 0;

            Console.WriteLine($"Apostaste: {n1.apuesta}");
            Console.WriteLine($"Conseguiste: {n1.resultado()}");
            Console.ReadKey();
        }
    }
}
