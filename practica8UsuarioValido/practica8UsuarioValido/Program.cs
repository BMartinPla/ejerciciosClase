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
            string nom;
            int aux;
            int hasN = 0;

            Console.WriteLine("Ingrese su nombre: ");
            nom = Console.ReadLine();

            
            foreach (char letra in nom)
            {
                if (int.TryParse(letra.ToString(), out aux) == true)
                {
                    hasN = hasN + 1;
                }
            }

            if (hasN == 1)
            {
                Console.WriteLine($"El nombre {nom} no es valido ya que posee {hasN} numero.");
            }
            else if (hasN > 1)
            {
                Console.WriteLine($"El nombre {nom} no es valido ya que posee {hasN} numeros.");
            }
            else
            {
                Console.WriteLine($"El nombre {nom} es valido.");
            }
        }
    }
}
