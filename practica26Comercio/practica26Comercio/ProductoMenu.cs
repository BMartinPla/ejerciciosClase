using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica26Comercio
{
    public abstract class ProductoMenu
    {
        private string _Nombre;
        private double _PrecioBase;

        public abstract double CalcularPrecioFinal
        {
            get;
        } 

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal}");
        }

        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public double PrecioBase
        {
            get { return this._PrecioBase; }
            set { this._PrecioBase = value; }
        }

    }
}
