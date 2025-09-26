using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Direccion
    {
        private string _calle;
        private int _num;
        private int _piso;

        public string calle
        {
            get { return this._calle; }
            set { this._calle = value; }
        }

        public int num
        {
            get { return this._num; }
            set { this._num = value; }
        }

        public int piso
        {
            get { return this._piso; }
            set { this._piso = value; }
        }
    }
}
