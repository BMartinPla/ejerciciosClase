using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica24Dependencia4
{
    public enum typeEth
    {
        Americano,
        Afroamericano,
        Asiatico
    }
    public class human: info
    {
        private string _surname;
        private typeEth _ethnicity;

        public human()
        {
            this.name = "Ching";
            this.surname = "Chong";
            this.age = 1;
            this.ethnicity = typeEth.Asiatico;
        }

        public human(string name, string surname, int age, typeEth ethnicity)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.ethnicity = ethnicity;
        }


        public string surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }

        public typeEth ethnicity
        {
            get { return this._ethnicity; }
            set { this._ethnicity = value; }
        }

    }
}
