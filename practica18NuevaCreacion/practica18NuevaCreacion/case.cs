using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica18NuevaCreacion
{
    public enum comp3
    {
        Transparente,
        Opaca
    }

    public class @case
    {
        private comp3 _tipo;
        private string _color;

        public @case ()
        {
            this.tipo = comp3.Transparente;
            this.color = "Negro";
        }

        public @case(comp3 tipo, string color)
        {
            this.tipo = tipo;
            this.color = color;
        }

        public comp3 tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }

        public string color
        {
            get { return this._color; }
            set { this._color = value; }
        }

    }
}
