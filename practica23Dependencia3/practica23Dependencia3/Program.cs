using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23Dependencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            square sq = new square();
            sq.color = tono.azul;
            

            square[] squ = new square[2];
            squ[0] = new square(4, tono.rojo);
            squ[1] = new square(6, tono.blanco);

            for (int i = 0; i < squ.Length; i++) { 
            Console.WriteLine(squ[i].ladoA);
            }


            List<square> squares = new List<square>();
            squares.Add(new square(2, tono.negro));
            squares.Add(new square(5, tono.azul));

            foreach (square c in squares)
            {
                Console.WriteLine(c.ladoA);
            }

            List<square> mini = squares.Where(x => x.color == tono.rojo).ToList();

            Console.ReadKey();


            List<form> toys = new List<form>();
            toys.Add(new triangle(4, 5, 4, tono.rojo));
            toys.Add(new square(3, tono.blanco));
            toys.Add(new rectangle(4, 2, tono.azul));

            foreach (form f in toys)
            {
                Console.WriteLine($"Superficie: {f.area}");
            }

            Console.ReadKey();


            int opc = 0;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            int col = 0;
            int sal = 1;

            while (sal != 0)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1- Triangulo");
                Console.WriteLine("2- Cuadrado");
                Console.WriteLine("3- Rectangulo");
                Console.WriteLine("0- Salir");
                Console.WriteLine("Ingrese una opcion:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        sal = 0;
                        break;
                    case 1:
                        Console.WriteLine("Ingrese el lado 1");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el lado 2");
                        v2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el lado 3");
                        v3 = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el lado 1");
                        v1 = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el lado 1");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el lado 2");
                        v2 = int.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            




        }
    }
}
