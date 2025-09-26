using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Empleado
    {
        private int _leg;
        private string _ape;
        private Empleado _supervisor;
        private List<Empleado> _genteACargo;
        

        public string ape { 
            get { return this._ape; } 
            set { this._ape = value; } 
        }
        public int leg
        {
            get { return this._leg; }
            set { this._leg = value; }
        }

        public Empleado supervisor
        {
            get { return this._supervisor; }
            set { this._supervisor = value; }
        }

        public List<Empleado> genteACargo
        {
            get { return this._genteACargo; }
            set { this._genteACargo = value; }
        }

    }
}
