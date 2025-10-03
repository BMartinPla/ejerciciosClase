using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{
    internal class Materias
    {
        private int _nivel;
        private string _aula;
        private string _materia;
        private string[] _docentes;
        private List<Alumnos> _alumnos;


        public Materias()
        {
            this.nivel = 0;
            this.aula = string.Empty;
            this.materia = string.Empty;
            this.docentes = new string[3];
            this.alumnos = new List<Alumnos>();
        }

        public Materias(int nivel, string aula, string materia, string[] docentes, List<Alumnos> alumnos)
        {
            this._nivel = nivel;
            this._aula = aula;
            this._materia = materia;
            this._docentes = docentes;
            this._alumnos = alumnos;
        }


        public int nivel
        {
            get { return this._nivel; }
            set { this._nivel = value; }
        }

        public string aula
        {
            get { return this._aula; }
            set { this._aula = value; }
        }

        public string materia
        {
            get { return this._materia; }
            set { this._materia = value; }
        }

        public string[] docentes
        {
            get { return this._docentes; }
            set { this._docentes = value; }
        }

        public List<Alumnos> alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }
    }
}
