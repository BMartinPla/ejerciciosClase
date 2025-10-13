using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;

namespace practicaUML4http
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            try
            {
                HttpClient client = new HttpClient();


                F1 F1Datos = new F1();

                /*
                string temp = string.Empty;
                string race = string.Empty;

                Console.Write("Ingrese el año: ");
                temp = Console.ReadLine();

                Console.Write("Ingrese la carrera: ");
                race = Console.ReadLine();
                */

                string cad;
                int temp;
                int race;

                Console.Write("Ingrese el año: ");
                cad = Console.ReadLine();
                while (!int.TryParse(cad, out temp))
                {
                    Console.Write("Ingrese el año: ");
                    cad = Console.ReadLine();
                }

                Console.Write("Ingrese la carrera: ");
                cad = Console.ReadLine();
                while (!int.TryParse(cad, out race))
                {
                    Console.Write("Ingrese la carrera: ");
                    cad = Console.ReadLine();
                }


                string urlApi = $"https://api.jolpi.ca/ergast/f1/{temp}/{race}/results/";
                string datos = await client.GetStringAsync(urlApi);

                F1Datos = JsonSerializer.Deserialize<F1>(datos);

                Console.Clear();

                Console.WriteLine($"TEMPORADA {temp} | CARRERA N°{race} | {F1Datos.MRData.RaceTable.Races[0].Circuit.circuitName}");
                foreach (Result Res in F1Datos.MRData.RaceTable.Races[0].Results)
                {
                    Console.WriteLine($"P{Res.position}. {Res.Driver.familyName}, {Res.Driver.givenName} - {Res.Constructor.name} | {Res.Time?.time}");
                }


                Console.ReadKey();
            }

            catch
            {

            }
        }
    }
}
