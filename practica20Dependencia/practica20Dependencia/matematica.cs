using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica20Dependencia
{
    public class matematica
    {

        public int sumar (int x, int y)
        {
            return x + y;
        }

        public int restar(int x, int y)
        {
            return x - y;
        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        public int dividir(int x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new Exception("Imposible dividir por cero");
            }
        }

    }
}
