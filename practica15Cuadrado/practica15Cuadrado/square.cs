using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace practica15Cuadrado
{
    public enum comp
    {
        madera,
        metal,
        plastico
    }

    public class square
    {
        private bool _fill;
        private comp _type;
        private int _side;

        public square ()
        {
            this.fill = true;
            this.type = comp.plastico;
            this.side = 5;
        }

        public square(bool fill, comp type, int side)
        {
            this.fill = fill;
            this.type = type;
            this.side = side;
        }

        public bool fill
        {
            get { return this._fill; }
            set
            {
                this._fill = value;
            }
        }

        public comp type
        {
            get { return this._type; }
            set
            {
                    this._type = value;
            }
        }

        public int side
        {
            get { return this._side; }
            set
            {
                if (value >= 0 )
                {
                    this._side = value;
                }
            }
        }

        public int perim
        {
            get { return this.side * 4; }
        }
        
        public int area
        {
            get { return this.side * this.side; }
        }
    }
}
