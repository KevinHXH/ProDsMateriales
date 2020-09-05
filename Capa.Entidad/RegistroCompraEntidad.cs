using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class RegistroCompraEntidad
    {
        public int IdRegistroCompra { set; get; }
        public ProductoEntidad productoEntidad { set; get; }
        public string NombreCliente { set; get; }
        public double TotalImpuesto { set; get; }
        public double SubTotal { set; get; }
        public double Total { set; get; }
        public bool Estado { set; get; }
        public RegistroCompraEntidad()
        {
        }
        public RegistroCompraEntidad(int idRegistroCompra, int idProducto, string nombreCliente, double totalImpuesto, double subTotal, double total, bool estado)
        {
            IdRegistroCompra = idRegistroCompra;
            productoEntidad.IdProducto = idProducto;
            NombreCliente = nombreCliente;
            TotalImpuesto = totalImpuesto;
            SubTotal = subTotal;
            Total = total;
            Estado = estado;
        }
    }
}
