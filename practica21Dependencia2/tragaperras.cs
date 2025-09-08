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

    public class tragaperras: calculo
    {
        private kprize _prize;
        private int _apuesta;
        private int _cApuestas;

        
        public tragaperras()
        {
            this.apuesta = 0;
            this.prize = kprize.nada;
            this.cApuestas = 0;
        }

        public tragaperras(int apuesta, kprize prize, int cApuestas)
        {
            this.apuesta = apuesta;
            this.prize = prize;
            this.cApuestas = cApuestas;
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

        public int cApuestas
        {
            set { this._cApuestas = value; }
            get { return this._cApuestas; }
        }

        public override string debeGanar
        {
            get { if (cApuestas >= 50 )
                {
                    return "s";
                }
            else
                {
                    return "n";
                }
            }
        }

        public int resultado()
        {
            premio prem = new premio();
            int fin = 0;

            if (debeGanar == "s")
            {
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
            else if (debeGanar == "n")
            {
                Console.WriteLine("No ganaste");
                fin = 0;
                return fin;
            }
            else
            {
                fin = 0;
                return fin;
            }

           

        }

    }
}
