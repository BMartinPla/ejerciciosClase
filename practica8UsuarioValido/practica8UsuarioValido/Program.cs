using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8UsuarioValido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string nom;
            int aux;
            int k = 0;

            Console.WriteLine("Ingrese su nombre");
            nom = Console.ReadLine();

            
            foreach (char letra in nom)
            {
                if (int.TryParse(letra.ToString(), out aux) == true)
                {
                    Console.WriteLine("El nombre tiene un numero");
                    Console.ReadKey();
                    k = 1;
                }
            }
            
            Console.WriteLine($"Su nombre es {nom}");
            Console.ReadKey();

        }
    }
}
