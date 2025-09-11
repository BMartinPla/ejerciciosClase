using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica26Comercio
{

    public enum Tamanio
    {
        Chico,
        Mediano,
        Grande
    }

    public class Bebida: ProductoMenu
    {
        private Tamanio _Tamano;

        public Bebida(string Nombre, double PrecioBase, Tamanio Tamano)
        {
            this.Nombre = Nombre;
            this.PrecioBase = PrecioBase;
            this.Tamano = Tamano;
        }



        public override double CalcularPrecioFinal
        {
            get
            {
                if (Tamano == Tamanio.Chico)
                {
                    return PrecioBase;
                }
                else if (Tamano == Tamanio.Mediano)
                {
                    return PrecioBase * 1.5;
                }
                else 
                {
                    return PrecioBase * 2.0;
                }

            }
        }

        public Tamanio Tamano
        {
            get { return this._Tamano; }
            set { this._Tamano = value; }
        }

    }
}
