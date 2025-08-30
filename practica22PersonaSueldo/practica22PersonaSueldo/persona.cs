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
            trabajoTipo trabajo1 = new trabajoTipo();
            int sueldo = 0;
            //Console.WriteLine(trabajo.tipo);
            switch (trabajo.tipo)

            
            {
                case jobs.portero:
                    {
                        trabajo1.sueldoporhora = 15;
                        sueldo = trabajo.sueldoporhora * trabajo.horas;
                        break;
                    }
                case jobs.programador:
                    {
                        trabajo1.sueldoporhora = 45;
                        sueldo = trabajo.sueldoporhora * trabajo.horas;
                        break;
                    }
                case jobs.medico:
                    {
                        trabajo1.sueldoporhora = 90;
                        sueldo = trabajo.sueldoporhora * trabajo.horas;
                        break;
                    }
            }
            
            return sueldo;
        }
    }
}
