using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23Dependencia3
{
    public class square: form
    {
        private int _ladoA;


        public square()
        {
            this.ladoA = 1;
            this.color = tono.negro;
        }

        public square(int ladoA, tono color)
        {
            this.ladoA = ladoA;
            this.color = color;
        }


        public int ladoA
        {
            get { return this._ladoA; }
            set { 
            if (value > 0)
                {
                    this._ladoA = value;
                }
            }
        }

        public override int perimetro
        {
            get { return this.ladoA * 4; }
        }

        public override int area
        {
            get { return this.ladoA * this.ladoA; }
        }

        public override void show()
        {
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Perimetro: {this.perimetro}");
            Console.WriteLine($"Area: {this.area}");
        }
    }
}
