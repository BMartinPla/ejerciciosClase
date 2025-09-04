using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica25Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Don Quijote", "Miguel de Cervantes", Tapa.Dura);
            Libro libro2 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", Tapa.Blanda);
            Libro libro3 = new Libro("El Principito", "Antoine de Saint-Exupéry", Tapa.Intermedia);

            Usuario usuario1 = new Usuario("Juan");

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);

            Console.WriteLine("\n--- Estado inicial de los libros ---");
            Console.WriteLine($"{libro1.Titulo} disponible: {libro1.Disponible}");
            Console.WriteLine($"{libro2.Titulo} disponible: {libro2.Disponible}");
            Console.WriteLine($"{libro3.Titulo} disponible: {libro3.Disponible}");

            biblioteca.PrestarLibro(libro1, usuario1);
            biblioteca.PrestarLibro(libro2, usuario1);

            Console.WriteLine("\n--- Libros prestados a Juan ---");
            usuario1.MostrarLibrosPrestados();

            Console.WriteLine("\n--- Estado de los libros después del préstamo ---");
            Console.WriteLine($"{libro1.Titulo} disponible: {libro1.Disponible}");
            Console.WriteLine($"{libro2.Titulo} disponible: {libro2.Disponible}");
            Console.WriteLine($"{libro3.Titulo} disponible: {libro3.Disponible}");

            biblioteca.DevolverLibro(libro1, usuario1);

            Console.WriteLine("\n--- Libros prestados a Juan después de devolver uno ---");
            usuario1.MostrarLibrosPrestados();

            Console.WriteLine("\n--- Estado de los libros después de la devolución ---");
            Console.WriteLine($"{libro1.Titulo} disponible: {libro1.Disponible}");
            Console.WriteLine($"{libro2.Titulo} disponible: {libro2.Disponible}");
            Console.WriteLine($"{libro3.Titulo} disponible: {libro3.Disponible}");

            Console.ReadKey();
        }
    }
}
