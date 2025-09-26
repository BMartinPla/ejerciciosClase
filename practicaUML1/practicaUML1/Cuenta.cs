using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Cuenta
    {
        private string _cbu;
        private Cliente _tit;

        public string cbu
        {
            get { return this._cbu; }
            set { this._cbu = value; }
        }

        public Cliente tit
        {
            get { return this._tit; } 
            set { this._tit = value; }
        }
    }
}
