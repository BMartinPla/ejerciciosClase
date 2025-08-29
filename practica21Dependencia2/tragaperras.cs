using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica21Dependencia2
{
    public enum kprize
    {
        nada,
        tresLimones,
        tresCerezas,
        TresSiete
    }

    public class tragaperras
    {
        private kprize _prize;
        private int _apuesta;

        
        public tragaperras()
        {
            this.apuesta = 0;
            this.prize = kprize.nada;
        }

        public tragaperras(int apuesta, kprize prize)
        {
            this.apuesta = apuesta;
            this.prize = prize;
        }


        public kprize prize
        {
            get { return this._prize; }
            set { this._prize = value; }
        }

        public int apuesta
        {
            set { this._apuesta = value; }
            get { return this._apuesta; }
        }

        public int resultado()
        {
            premio prem = new premio();
            int fin = 0;

            switch (this.prize)
            {
                case kprize.nada:
                    {
                        fin = prem.nada(apuesta);
                        break;
                    }
                case kprize.tresLimones:
                    {
                        fin = prem.tresLimones(apuesta);
                        break;
                    }
                case kprize.tresCerezas:
                    {
                        fin = prem.tresCerezas(apuesta);
                        break;
                    }
                case kprize.TresSiete:
                    {
                        fin = prem.tresSiete(apuesta);
                        break;
                    }
            }
            return fin;

        }

    }
}
