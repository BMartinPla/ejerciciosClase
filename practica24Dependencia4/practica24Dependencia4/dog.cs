using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica24Dependencia4
{
    public enum typeRace
    {
        Dalmata,
        Chihuahua,
        Dogo,
        Pitbull,
        Calle
    }

    public enum typeSize
    {
        Pequeño,
        Mediano,
        Grande
    }

    public class dog: info
    {
        private typeRace _race;
        private typeSize _size;

        public dog ()
        {
            this.name = "Pichicho";
            this.age = 5;
            this.race = typeRace.Dalmata;
            this.size = typeSize.Grande;
        }

        public dog(string name, int age, typeRace race, typeSize size)
        {
            this.name = name;
            this.age = age;
            this.race = race;
            this.size = size;
        }


        public typeRace race
        {
            get { return this._race; }
            set { this._race = value; }
        }

        public typeSize size
        {
            get { return this._size; }
            set { this._size = value; }
        }


    }
}
