using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Persona
    {
        private string _ape;
        private Direccion _domicilio;


        public string ape
        {
            get { return this._ape; }
            set { this._ape = value; }
        }

        public Direccion domicilio
        {
            get { return this._domicilio; }
            set { this._domicilio = value; }
        }
    }
}
