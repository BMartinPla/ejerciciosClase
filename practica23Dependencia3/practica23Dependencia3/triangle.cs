using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica23Dependencia3
{
    public class triangle: form
    {
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;


        public triangle()
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.ladoC = 0;
            this.color = tono.blanco;
        }

        public triangle (int ladoA, int ladoB, int ladoC, tono color)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
            this.color = color;
        }

        public int ladoA
        {
            get { return this._ladoA; }
            set { if (value > 0)
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

        public int ladoC
        {
            get { return this._ladoC; }
            set
            {
                if (value > 0)
                {
                    this._ladoC = value;
                }
            }
        }

        public override int perimetro
        {
            get { return this.ladoA + this.ladoB + this.ladoC; }
        }

        public override int area
        {
            get {
                double s = (this.ladoA + this.ladoB + this.ladoC) / 2.0;
                double area = Math.Sqrt(s * (s - this.ladoA) * (s - this.ladoB) * (s - this.ladoC));
                return (int)Math.Round(area);
            }
        }

        public override void show()
        {
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Perimetro: {this.perimetro}");
            Console.WriteLine($"Area: {this.area}");
        }

    }
}
