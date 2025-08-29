using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica20Dependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora cal = new calculadora();
            cal.operacion = tipoOperacion.multiplicar;
            cal.valorA = 10;
            cal.valorB = 2;

            Console.WriteLine($"El resultado es: {cal.calcular()}");
            Console.ReadKey();

        }
    }
}
