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


        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public string[] LibrosPrestados
        {
            get { return this.LibrosPrestados; }
            set { this.LibrosPrestados = value; }
        }

        MostrarLibrosPrestados()
        {
            for (int i = 0; i < LibrosPrestados.Length; i++)
            {
                Console.WriteLine(LibrosPrestados[i]);
            }
        }


    }
}
