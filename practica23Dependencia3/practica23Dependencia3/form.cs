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

        public abstract int perimetro
        {
            get;
        }

        public abstract int area
        {
            get;
        }

        public virtual void show()
        {
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Perimetro: {this.perimetro}");
            Console.WriteLine($"Area: {this.area}");
        }

    }
}
