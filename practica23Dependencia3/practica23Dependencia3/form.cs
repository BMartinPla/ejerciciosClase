using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23Dependencia3
{
    public enum tono
    {
        blanco,
        negro,
        rojo,
        azul
    }
    public abstract class form
    {
        private tono _color;

        public tono color
        {
            get { return this._color; }
            set { this._color = value; }
        }
    }
}
