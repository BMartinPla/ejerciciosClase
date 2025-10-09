using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUML3Supermercado
{

    public class Supermercados
    {
        public Supermercado[] Property1 { get; set; }
    }

    public class Supermercado
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public Producto[] productos { get; set; }
    }

    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double precioCosto { get; set; }
        public double porcentajeGanancia { get; set; }
        public double porcentajeDescuento { get; set; }
        public double iva { get; set; }
        public Ubicacion ubicacion { get; set; }
        public double precioBruto { get { return this.precioCosto + ((this.precioCosto * this.porcentajeGanancia)/100); } }
        public double montoDescuento { get { return (this.precioBruto * this.porcentajeDescuento)/100; } }
        public double precioFinal { get { return (this.precioBruto - this.montoDescuento) + (((this.precioBruto - this.montoDescuento) * this.iva)/100); } }
    }

    public class Ubicacion
    {
        public string pasillo { get; set; }
        public string estante { get; set; }
    }

}
