using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica26Comercio
{
    public class Postre : ProductoMenu
    {
        private bool _TieneExtraDulce;

        public Postre(string Nombre, double PrecioBase, bool TieneExtraDulce)
        {
            this.Nombre = Nombre;
            this.PrecioBase = PrecioBase;
            this.TieneExtraDulce = TieneExtraDulce;
        }


        public override double CalcularPrecioFinal
        {
            get
            {
                if (TieneExtraDulce == true)
                {
                    return PrecioBase + 500;
                }
                else
                {
                    return PrecioBase;
                }

            }
        }


        public bool TieneExtraDulce
        {
            get { return this._TieneExtraDulce; }
            set { this._TieneExtraDulce = value; }
        }
    }
}
