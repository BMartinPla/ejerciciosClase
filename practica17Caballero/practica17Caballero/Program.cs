using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica17Caballero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            espada nunu = new espada(comp2.katana, comp3.metal, comp4.afilado);

            caballero seiya = new caballero(dni: 49284721, nombre: "Seiya", direccion: "Olimpo", comp.Mediana, espada: nunu);

            Console.WriteLine($"CABALLERO");
            Console.WriteLine($"DNI: {seiya.dni}");
            Console.WriteLine($"Nombre: {seiya.nombre}");
            Console.WriteLine($"Direccion: {seiya.direccion}");
            Console.WriteLine($"Armadura: {seiya.armadura}");
            Console.WriteLine($"\nESPADA");
            Console.WriteLine($"Tipo: {seiya.espada.type}");
            Console.WriteLine($"Material: {seiya.espada.mat}");
            Console.WriteLine($"Filo: {seiya.espada.tfilo}");
            Console.ReadKey();


        }
    }
}
