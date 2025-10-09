using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace practicaUML3Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Supermercado> Cadena = new List<Supermercado>();

            string Aux = File.ReadAllText("C:\\Users\\braian.pla\\source\\repos\\practicaUML3Supermercado\\practicaUML3Supermercado\\Datos.json");

            Cadena = JsonSerializer.Deserialize<List<Supermercado>>(Aux);

            /*
            Supermercado CadAux = new Supermercado();
 
            CadAux = JsonSerializer.Deserialize<Supermercado>(Aux);
            */


            foreach (Supermercado Sup in Cadena)
            {
                Console.WriteLine($"{Sup.nombre} - {Sup.direccion}");

                foreach (Producto p in Sup.productos)
                {
                    Console.WriteLine($"Producto: {p.descripcion}");
                }

                Console.WriteLine();
            }



            Console.ReadKey();


        }
    }
}
