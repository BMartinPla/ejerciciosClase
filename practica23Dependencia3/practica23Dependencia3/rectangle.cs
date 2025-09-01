using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23Dependencia3
{
    public class rectangle: form
    {
        private int _ladoA;
        private int _ladoB;

        public rectangle()
        {
            this.ladoA = 1;
            this.ladoB = 1;
            this.color = tono.blanco;
        }

        public rectangle(int ladoA, int ladoB, tono color)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.color = color;
        }



        public int ladoA
        {
            get { return this._ladoA; }
            set
            {
                if (value > 0)
                {
                    this._ladoA = value;
                }
            }
        }

        public int ladoB
        {
            get { return this._ladoB; }
            set
            {
                if (value > 0)
                {
                    this._ladoB = value;
                }
            }
        }

    }
}
