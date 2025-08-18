using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace practica12Objetos
{
    public class sorteo
    {
        private int _bolilla;
        private string _color;

        public sorteo ()
        {
            this.bolilla = 0;
            this.color = "Naranja";
        }

        public sorteo(int bolilla)
        {
            this.bolilla = bolilla;
            this.color = "Naranja";
        }

        public sorteo(int bolilla, string color)
        {
            this.bolilla = bolilla;
            this.color = color;
        }

        public int bolilla
        {
            get { return this._bolilla; }
            set { this._bolilla = value; }
        }

        public string color
        {
            get { return this._color; }
            set
            {
                if (value == "Naranja" ||  value == "Azul")
                {
                    this._color = value;
                }
                else
                {
                    throw new Exception("Color no valido");
                }
            }
        }

    }
}
