using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practica19MenuOpciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task.Run(MostrarHora);
            */

            // Listas

            // Crear lista
            List<string> Victor = new List<string>();

            // Agregar datos
            Victor.Add("Uvas");
            Victor.Add("Sandias");
            Victor.Add("Manzanas");
            Victor.Add("Peras");
            Victor.Add("Ananas");
            Victor.Add("Naranjas");

            // Mostrar lista
            foreach (string fruta in Victor)
            {
                Console.WriteLine(fruta);
            }
            Console.ReadKey();
            Console.Clear();

            // Borrar datos 
            // 1 - Borrar por indice
            Victor.RemoveAt(2);
            // 2 - Borrar por elemento
            Victor.Remove("Peras");
            // 3 - Borrar por rango
            Victor.RemoveRange(0, 1);

            foreach (string fruta in Victor)
            {
                Console.WriteLine(fruta);
            }
            Console.ReadKey();
            Console.Clear();



            // Menu, colores y mas

            /*
            int opcion = 0;


            while (opcion != 4)
            {
                menu();
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("======");
                        Console.WriteLine("¡Hola!");
                        Console.WriteLine("======");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("==================");
                        Console.WriteLine($"Hora actual: {DateTime.Now.Hour}:{DateTime.Now.Minute}");
                        Console.WriteLine("==================");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("=======================");
                        Console.WriteLine($"Fecha actual: {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}");
                        Console.WriteLine("=======================");
                        Console.ReadKey();
                        break;
                    case 4:
                        opcion = 4;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Escoja una opcion valida!");
                        Console.ReadKey();
                        break;
                }
            */

        }

            

        }

    /*
        static void menu()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("================");
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Saludo");
            Console.WriteLine("2 - Hora");
            Console.WriteLine("3 - Fecha");
            Console.WriteLine("4 - Salir");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("================");
            Console.WriteLine("Opcion:");
            Console.ResetColor();
            Task.Run(MostrarHora);
        }
    */

    /*
        static void MostrarHora()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hora actual: " + DateTime.Now.ToLongTimeString());
                Console.ResetColor();
                Thread.Sleep(1000);
                
                Console.Title = "Hora actual: " + DateTime.Now.ToLongTimeString();
                Thread.Sleep(1000);
                
            }
        }
    
    */
}
