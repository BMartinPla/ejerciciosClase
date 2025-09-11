using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica26Comercio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioComida;
            double precioBebida;
            double precioPostre;


            Comida PalV = new Comida("Pollo al Verdeo", 10000, false);
            precioComida = PalV.CalcularPrecioFinal;
            PalV.MostrarInfo();
            Console.WriteLine("");
            Console.ReadKey();

            Bebida Coke = new Bebida("Cola Cola", 2000, Tamanio.Mediano);
            precioBebida = Coke.CalcularPrecioFinal;
            Coke.MostrarInfo();
            Console.WriteLine("");
            Console.ReadKey();

            Postre CCake = new Postre("Cheesecake de Maracuya", 7000, true);
            precioPostre = CCake.CalcularPrecioFinal;
            CCake.MostrarInfo();
            Console.WriteLine("");
            Console.ReadKey();

            double precioTotal = precioComida + precioBebida + precioPostre;
            Console.WriteLine($"Total a abonar: {precioTotal}");
            Console.ReadKey();




        }
    }
}
