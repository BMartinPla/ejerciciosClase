using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practica25Biblioteca
{
    public class Usuario
    {
        private string _Nombre;
        private string[] _LibrosPrestados;

        public Usuario (string nombre)
        {
            this.Nombre = nombre;
            this.LibrosPrestados = new string[5];
        }


        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public string[] LibrosPrestados
        {
            get { return this._LibrosPrestados; }
            set { this._LibrosPrestados = value; }
        }

        public void MostrarLibrosPrestados()
        {
            foreach (var libro in LibrosPrestados)
            {
                if (!string.IsNullOrEmpty(libro))
                {
                    Console.WriteLine(libro);
                }
            }
        }


    }
}
