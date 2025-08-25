using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica17Caballero
{
    public enum comp2
    {
        sable,
        katana,
        mauser
    }

    public enum comp3
    {
        wood,
        metal
    }

    public enum comp4
    {
        romo,
        afilado,
        oxidado
    }

    public class espada
    {
        private comp2 _type;
        private comp3 _mat;
        private comp4 _tfilo;

        public espada()
        {
            this.type = comp2.sable;
            this.mat = comp3.wood;
            this.tfilo = comp4.romo;
        }

        public espada (comp2 type, comp3 mat, comp4 tfilo)
        {
            this.type = type;
            this.mat = mat;
            this.tfilo = tfilo;
        }

        public comp2 type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public comp3 mat
        {
            get { return this._mat; }
            set { this._mat = value; }
        }

        public comp4 tfilo
        {
            get { return this._tfilo; }
            set { this._tfilo = value; }
        }



    }
}
