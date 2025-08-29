using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica21Dependencia2
{
    public class premio
    {
        public int nada (int x)
        {
            return x * 0;
        }

        public int tresLimones (int x)
        {
            return x * 10;
        }

        public int tresCerezas (int x)
        {
            return x * 100;
        }

        public int tresSiete (int x)
        {
            return x * 1000;
        }


    }
}
