using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona();
            Direccion direccion = new Direccion();
            direccion.num = 232;
            direccion.calle = "bolivar";

            persona.domicilio = direccion;
            persona.ape = "gomez";



        }
    }
}
