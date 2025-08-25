using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica17Caballero
{
    public enum comp
    {
        Liviana,
        Mediana,
        Pesada
    }

    public class caballero
    {
        private int _dni;
        private string _nombre;
        private string _direccion;
        private comp _armadura;
        private espada _espada;

        public caballero()
        {
            this.dni = 0;
            this.nombre = "Rrrrah";
            this.direccion = "Clash Royale";
            this.armadura = comp.Liviana;
            this.espada = new espada(comp2.mauser, comp3.metal, comp4.oxidado);
        }

        public caballero(int dni, string nombre, string direccion, comp armadura, espada espada)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.direccion = direccion;
            this.armadura = armadura;
            this.espada = espada;
        }
       
        public comp armadura
        {
            get { return this._armadura; }
            set { this._armadura = value; }
        }


        public int dni
        {
            get { return this._dni; }
            set
            {
                if (value >= 0)
                {
                    this._dni = value;
                }
            }
        }

        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        public espada espada
        {
            get { return this._espada; }
            set { this._espada = value; }
        }
    }
}
