using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica24Dependencia4
{
    public abstract class info
    {
        private string _name;
        private int _age;

        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int age
        {
            get { return this._age; }
            set { 
            if (value > 0 && value < 120)
                {
                    this._age = value;
                }
            }
        }
    }
}
