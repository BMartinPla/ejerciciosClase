using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica22PersonaSueldo
{
    public enum jobs
    {
        medico,
        programador,
        portero
    }

    public class trabajoTipo
    {
        private int _sueldoporhora;
        private int _horas;
        private jobs _tipo;


        
        public trabajoTipo()
        {
            this.sueldoporhora = 0;
            this.horas = 0;
            this.tipo = jobs.portero;
        }

        public trabajoTipo(int sueldoporhora, int horas, jobs tipo)
        {
            this.sueldoporhora = horas;
            this.horas = horas;
            this.tipo = tipo;
        }


        public jobs tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }

        public int sueldoporhora
        {
            get { return this._sueldoporhora; }
            set { this._sueldoporhora = value; }
        }

        public int horas
        {
            get { return this._horas; }
            set { this._horas = value; }
        }
    }
}
