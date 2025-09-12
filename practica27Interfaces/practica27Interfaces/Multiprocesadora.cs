using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica27Interfaces
{
    public class Multiprocesadora: IBatidora, ILicuadora, IProcesadora
    {
        private string _marca;
        private string _modelo;
        private int _cantidadCuchillas;
        public string color { get; set; }



        
        public void Batir()
        {
            throw new NotImplementedException();
        }

        public void Licuar()
        {
            throw new NotImplementedException();
        }

        public void Procesar()
        {
            throw new NotImplementedException();
        }

        public Multiprocesadora()
        {
            this.marca = string.Empty;
            this.modelo = string.Empty;
            this.cantidadCuchillas = 0;
        }

        public Multiprocesadora(string marca, string modelo, int cantidadCuchillas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cantidadCuchillas = cantidadCuchillas;
        }

        public string marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }

        public string modelo
        {
            get { return this._modelo; }
            set { this._modelo = value; }
        }

        public int cantidadCuchillas
        {
            get { return this._cantidadCuchillas; }
            set { this._cantidadCuchillas = value; }
        }




    }
}
