using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica22PersonaSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            trabajoTipo t1 = new trabajoTipo();
            persona p1 = new persona();


            t1.tipo = jobs.programador;
            t1.horas = 160;
            p1.trabajo = t1;
            p1.apellido = "Perez";
            p1.dni = 1223;

           // p1.calcularSueldo();

            Console.WriteLine("El sueldo de " + p1.apellido + " es: " + p1.calcularSueldo());
            Console.ReadKey();   

        }
    }
}
