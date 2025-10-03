using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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


            Materias mat = new Materias();
            Alumnos alum = new Alumnos();

            string cadena = File.ReadAllText("C:\\Users\\braian.pla\\Desktop\\CLASES PROG 2\\ejerciciosClase\\practicaUML1\\practicaUML1\\prueba.json");

            mat = JsonSerializer.Deserialize<Materias>(cadena);

            Console.WriteLine($"Materia: {mat.materia}");
            Console.WriteLine($"Aula: {mat.aula}");

            foreach (Alumnos alu in mat.alumnos)
            {
                Console.WriteLine($"Alumno: {alu.apelnom} || EntregoTP: {alu.entregoTP}");
            }






            Console.ReadKey();

        }
    }
}
