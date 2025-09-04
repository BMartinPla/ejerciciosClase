using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica25Biblioteca
{
    public enum Tapa
    {
        Blanda,
        Intermedia,
        Dura
    }
    public class Libro
    {
        private string _Titulo;
        private string _Autor;
        private bool _Disponible;
        private Tapa _TipoTapa;

        public Libro (string Titulo, string Autor, Tapa TipoTapa)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.TipoTapa = TipoTapa;
            this.Disponible = true;
        }

        public string Titulo
        {
            get { return this._Titulo; }
            set { this._Titulo = value; }
        }

        public string Autor
        {
            get { return this._Autor; }
            set { this._Autor = value; }
        }

        public bool Disponible
        {
            get { return this._Disponible; }
            set { this._Disponible = value; }
        }

        public Tapa TipoTapa
        {
            get { return this._TipoTapa; }
            set { this._TipoTapa = value; }
        }


    }
}
