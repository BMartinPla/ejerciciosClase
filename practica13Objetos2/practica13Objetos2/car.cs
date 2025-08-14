using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica13Objetos2
{
    public class car
    {
        private string _brand;
        private int _year;
        private int _doors;

        public car()
        {
            this.brand = "NB";
            this.year = 1950;
            this.doors = 1;
        }

        public car(string brand)
        {
            this.brand = brand;
            this.year = 1950;
            this.doors = 1;
        }

        public car(string brand, int year)
        {
            this.brand = brand;
            this.year = year;
            this.doors = 1;
        }

        public car(string brand, int year, int doors)
        {
            this.brand = brand;
            this.year = year;
            this.doors = doors;
        }

        public string brand
        {
            get { return this._brand; }
            set
            {
                this._brand = value;
            }
        }

        public int year
        {
            get { return this._year; }
            set
            {
                if (value >= 1950 && value <= 2025)
                {
                    this._year = value;
                }
            }
        }

        public int doors
        {
            get { return this._doors; }
            set
            {
                if (value >= 2 && value <= 12)
                {
                    this._doors = value;
                }
            }
        }

    }
}
