using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica25Biblioteca
{
    public class Biblioteca
    {
        private Libro[] _Libros;
        private int _cantidadLibros;

        public Biblioteca()
        {
            this.Libros = new Libro[100];
            this.cantidadLibros = 0;
        }

        public Libro[] Libros
        {
            get { return this._Libros; }
            set { this._Libros = value; }
        }

        public int cantidadLibros
        {
            get { return this._cantidadLibros; }
            set { this._cantidadLibros = value; }
        }

        public void AgregarLibro(Libro libro)
        {
            if (cantidadLibros < 100)
            {
                Libros[cantidadLibros] = libro;
                cantidadLibros++;
                Console.WriteLine($"Libro agregado: {libro.Titulo}");
            }
            else
            {
                Console.WriteLine("La biblioteca está llena. No se pueden agregar más libros.");
            }
        }

        public void PrestarLibro(Libro libro, Usuario usuario)
        {
            if (libro.Disponible)
            {
                for (int i = 0; i < usuario.LibrosPrestados.Length; i++)
                {
                    if (string.IsNullOrEmpty(usuario.LibrosPrestados[i]))
                    {
                        usuario.LibrosPrestados[i] = libro.Titulo;
                        libro.Disponible = false;
                        Console.WriteLine($"El libro -{libro.Titulo}- fue prestado a {usuario.Nombre}.");
                        return;
                    }
                }
                Console.WriteLine($"{usuario.Nombre} ya tiene 5 libros prestados.");
            }
            else
            {
                Console.WriteLine($"El libro -{libro.Titulo}- ya fue prestado.");
            }
        }

        public void DevolverLibro(Libro libro, Usuario usuario)
        {
            for (int i = 0; i < usuario.LibrosPrestados.Length; i++)
            {
                if (usuario.LibrosPrestados[i] == libro.Titulo)
                {
                    usuario.LibrosPrestados[i] = null;
                    libro.Disponible = true; 
                    Console.WriteLine($"{usuario.Nombre} devolvió el libro -{libro.Titulo}-.");
                    return;
                }
            }
            Console.WriteLine($"{usuario.Nombre} no tenía prestado el libro -{libro.Titulo}-.");
        }

    }
}
