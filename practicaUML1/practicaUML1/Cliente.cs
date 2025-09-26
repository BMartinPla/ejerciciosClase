using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Cliente
    {
        private string _ape;
        private List<Cuenta> _ctas;


        public string ape
        {
            get { return this._ape; }
            set { this._ape = value; }
        }

        public List<Cuenta> ctas
        {
            get { return this._ctas; }
            set { this._ctas = value; }
        }
    }
}
