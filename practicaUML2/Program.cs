using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace practicaUML2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F1 Formula = new F1();

            string Aux = File.ReadAllText("C:\\Users\\braian.pla\\Desktop\\CLASES PROG 2\\ejerciciosClase\\practicaUML2\\Datos.json");

            Formula = JsonSerializer.Deserialize<F1>(Aux);

            Mrdata DataInfo = new Mrdata();

            //Console.WriteLine(Formula.MRData.RaceTable.round);

            foreach (Result Res in Formula.MRData.RaceTable.Races[0].Results)
            {
                Console.WriteLine($"P{Res.position}. {Res.Driver.familyName}, {Res.Driver.givenName} - {Res.Constructor.name} - {Res.Time?.time}");
            }

            Console.ReadKey();
        }
    }
}
