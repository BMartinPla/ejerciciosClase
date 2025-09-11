using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica26Comercio
{
    public class Comida: ProductoMenu
    {
        private bool _EsVegano;

        public Comida(string Nombre, double PrecioBase, bool EsVegano)
        {
            this.Nombre = Nombre;
            this.PrecioBase = PrecioBase;
            this.EsVegano = EsVegano;
        }


        public override double CalcularPrecioFinal
        {
            get
            {
                if (EsVegano == true)
                {
                    return PrecioBase;
                }
                else
                {
                    return PrecioBase * 1.10;
                }

            }
        }


        public bool EsVegano
        {
            get { return this._EsVegano; }
            set { this._EsVegano = value; }
        }

    }
}
