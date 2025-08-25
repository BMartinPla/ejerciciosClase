using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica18NuevaCreacion
{
    public enum comp
    {
        Samsung,
        Apple,
        Xiaomi
    }

    public enum comp2
    {
        Claro,
        Movistar,
        Personal
    }

    public class phone
    {
        private comp _brand;
        private int _inch;
        private comp2 _data;
        private @case _phonecase;

        public phone()
        {
            this.brand = comp.Samsung;
            this.inch = 5;
            this.data = comp2.Claro;
            this.phonecase = new @case();
        }

        public phone(comp brand, int inch, comp2 data, @case phonecase)
        {
            this.brand = brand;
            this.inch = inch;
            this.data = data;
            this.phonecase = phonecase;
        }



        public comp brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public int inch
        {
            get { return this._inch; }
            set
            {
                if (value >= 4 && value <= 6)
                {
                    this._inch = value;
                }
            }
        }

        public comp2 data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public @case phonecase
        {
            get { return this._phonecase; }
            set { this._phonecase = value; }
        }
    }
}
