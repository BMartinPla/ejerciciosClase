using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica22PersonaSueldo
{
    public class persona
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private trabajoTipo _trabajo;

        public persona()
        {
            this.nombre = "n";
            this.apellido = "a";
            this.dni = 0;
            this.trabajo = new trabajoTipo();
        }

        public persona(string nombre, string apellido, int dni, trabajoTipo trabajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.trabajo = trabajo;
        }


        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        public trabajoTipo trabajo
        {
            get { return this._trabajo; }
            set { this._trabajo = value; }
        }

        public int calcularSueldo()
        {
            int sueldo = 0;
            switch (trabajo.tipo)
            {
                case jobs.portero:
                    trabajo.sueldoporhora = 15;
                    break;
                case jobs.programador:
                    trabajo.sueldoporhora = 45;
                    break;
                case jobs.medico:
                    trabajo.sueldoporhora = 90;
                    break;
            }
            sueldo = trabajo.sueldoporhora * trabajo.horas;
            return sueldo;
        }
    }
}
