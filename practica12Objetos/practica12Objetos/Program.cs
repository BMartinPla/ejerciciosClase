using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica12Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PERSONAS
            person p1 = new person();

            p1.name = "Carlito";
            p1.birthDate = DateTime.Parse("2015/7/10");

            Console.WriteLine("Persona 1");
            Console.WriteLine($"El nombre es: {p1.name}");
            Console.WriteLine($"La edad es: {p1.age}");
            Console.ReadKey();

            person p2 = new person("Pedrito", "Boliguayo", DateTime.Parse("2016/2/14"), tsex.male);

            Console.WriteLine("Persona 2");
            Console.WriteLine($"El nombre es: {p2.name}");
            Console.WriteLine($"La edad es: {p2.age}");
            Console.WriteLine($"{p2.name} es: {p2.sex}");
            Console.ReadKey();

            person p3 = new person("Juanito", "Paraguayo", DateTime.Parse("2017/2/8"));

            Console.WriteLine("Persona 3");
            Console.WriteLine($"El nombre es: {p3.name}");
            Console.WriteLine($"La edad es: {p3.age}");
            Console.WriteLine($"La nacionalidad es: {p3.nation}");
            Console.ReadKey();

            // SORTEO
            sorteo b1 = new sorteo();
            b1.bolilla = 27;
            mostrarBol(b1);

            sorteo b2 = new sorteo(34, "Azul");
            mostrarBol(b2);

            sorteo b3 = new sorteo(21, "Naranja");
            mostrarBol(b3);


        }

        static void mostrarBol (sorteo dato)
        {
            Console.WriteLine($"Bolilla");
            Console.WriteLine($"Numero: {dato.bolilla}");
            Console.WriteLine($"Color: {dato.color}");
            Console.ReadKey();
        }
    }
}
