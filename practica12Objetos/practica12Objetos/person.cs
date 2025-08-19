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
        private string _nation;
        private DateTime _birthDate;

        // Constructores
        public person()
        {
            this.name = "NN";
            this.nation = "Tierra";
            this.birthDate = DateTime.Today;
        }

        public person(string name)
        {
            this.name = name;
            this.nation = "Tierra";
            this.birthDate = DateTime.Today;
        }

        public person(string name, string nation)
        {
            this.name = name;
            this.nation = nation;
            this.birthDate = DateTime.Today;
        }

        public person(string name, string nation, DateTime birthDate)
        {
            this.name = name;
            this.nation = nation;
            this.birthDate = birthDate;
        }


        // Metodos de propiedades
        public string name
        {
            get { return this._name; }
            set { 
               this._name = value;
            }
        }

        public int age
        {
            get { return DateTime.Today.Year - this.birthDate.Year; }
        }

        public string nation
        {
            get { return this._nation; }
            set
            {
                this._nation = value;
            }
        }

        public DateTime birthDate
        {
            get { return this._birthDate; }
            set
            {
                if (value <= DateTime.Today)
                {
                    this._birthDate = value;
                }
            }
        }
    }
}
