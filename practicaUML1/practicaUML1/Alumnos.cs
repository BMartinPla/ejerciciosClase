using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Alumnos
    {
        private int _legajo;
        private string _apelnom;
        private DateTime _fechaNac;
        private bool _entregoTP;
        private string _empresaTrabaja;

        public Alumnos ()
        {
            this.legajo = 0;
            this.apelnom = string.Empty;
            this.fechaNac = DateTime.Now;
            this.entregoTP = false;
            this.empresaTrabaja = string.Empty;
        }

        public Alumnos (int legajo, string apelnom, DateTime fechaNac, bool entregoTP, string empresaTrabaja)
        {
            this.legajo = legajo;
            this.apelnom = apelnom;
            this.fechaNac = fechaNac;
            this.entregoTP = entregoTP;
            this.empresaTrabaja = empresaTrabaja;
        }




        public int legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public string apelnom
        {
            get { return _apelnom; }
            set { _apelnom = value; }
        }

        public DateTime fechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public bool entregoTP
        {
            get { return _entregoTP; }
            set { _entregoTP = value; }
        }

        public string empresaTrabaja
        {
            get { return _empresaTrabaja; }
            set { _empresaTrabaja = value; }
        }
    }
}
