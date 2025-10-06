using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML1
{

    public class MateriasUTN
    {
        public int nivel { get; set; }
        public string aula { get; set; }
        public string materia { get; set; }
        public string[] docentes { get; set; }
        public AlumnosUTN[] alumnos { get; set; }
    }

    public class AlumnosUTN
    {
        public int legajo { get; set; }
        public string apelnom { get; set; }
        public string fechaNac { get; set; }
        public bool entregoTP { get; set; }
        public string empresaTrabaja { get; set; }
    }


}
