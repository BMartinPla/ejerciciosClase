using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica20Dependencia
{
    public enum tipoOperacion
    {
        sumar,
        restar,
        multiplicar,
        dividir
    }
    public class calculadora
    {
        private tipoOperacion _operacion;
        private int _valorA;
        private int _valorB;

        public calculadora ()
        {
            this.operacion = tipoOperacion.sumar;
            this.valorA = 0;
            this.valorB = 0;
        }

        public calculadora(tipoOperacion operacion, int valorA, int valorB)
        {
            this.operacion = operacion;
            this.valorA = valorA;
            this.valorB = valorB;
        }

        public tipoOperacion operacion
        {
            get { return this._operacion; }
            set { this._operacion = value; }
        }

        public int valorA
        {
            get { return this._valorA; }
            set { this._valorA = value; }
        }

        public int valorB
        {
            get { return this._valorB; }
            set { this. _valorB = value; }
        }

        public int calcular()
        {
            matematica mat = new matematica();
            int res = 0;

            switch (this.operacion)
            {
                case tipoOperacion.sumar:
                    {
                        res = mat.sumar(this.valorA, this.valorB);
                        break;
                    }
                case tipoOperacion.restar:
                    {
                        res = mat.restar(this.valorA, this.valorB);
                        break;
                    }
                case tipoOperacion.multiplicar:
                    {
                        res = mat.multiplicar(this.valorA, this.valorB);
                        break;
                    }
                case tipoOperacion.dividir:
                    {
                        res = mat.dividir(this.valorA, this.valorB);
                        break;
                    }
            }
            return res;
        }

    }
}
