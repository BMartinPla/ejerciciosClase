using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace practica12Objetos
{
    public class person
    {
        // Propiedades
        private string _name;
        private int _age;
        private string _nation;

        // Constructores
        public person()
        {
            this.name = "NN";
            this.age = 1;
            this.nation = "Tierra";
        }

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public person(string name, int age, string nation)
        {
            this.name = name;
            this.age = age;
            this.nation = nation;
        }


        // Metodos de propiedades
        public string name
        {
            get {  return this._name; }
            set { 
               this._name = value;
            }
        }

        public int age
        {
            get { return this._age; }
            set {
            if(value >= 0 && value < 150)
                {
                    this._age = value;
                }
            }
        }

        public string nation
        {
            get { return this._nation; }
            set
            {
                this._nation = value;
            }
        }
    }
}
