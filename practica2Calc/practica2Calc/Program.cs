using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena, operador;
            int a, b;

            Console.WriteLine("Ingrese el primer numero: ");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out a)==false)
            {
                Console.WriteLine("Ingrese el primer numero: ");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out b) == false)
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el operador (/-*+)");
            operador = Console.ReadLine();
            while (operador != "/" && operador != "-" && operador != "*" && operador != "/")
            {
                Console.WriteLine("Ingrese el operador (/-*+)");
                operador = Console.ReadLine();
            }

            switch (operador)
            {
                case "+":
                    {
                        Console.WriteLine($"El resultado es: {sum(a,b)}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine($"El resultado es: {res(a,b)}");
                        break;
                    }
                case "/":
                    {
                        try
                        {
                            div(a, b);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Operacion finalizada.");
                        }
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"El resultado es: {mul(a,b)}");
                        break;
                    }
            }

            Console.ReadKey();
        }

        static int sum(int a, int b)
        {
            return a + b;
        }

        static int res(int a, int b)
        {
            return a - b;
        }

        static void div(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"El resultado es: {a / b}");
            }
            else
            {
                Exception e = new Exception("Imposible dividir por cero.");
                e.Source = "Procedimiento de division";
                e.HelpLink = "Leer fundamentos matematicos";
                throw e;
            }
        }

        static int mul(int a, int b)
        {
            return a * b;
        }
    }
}
