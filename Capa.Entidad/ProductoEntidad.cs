using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
   public class ProductoEntidad
    {
        public int IdProducto { set; get; }
        public SucursalEntidad sucursalEntidad { set; get; }
        public MedidaProductoEntidad medidaProductoEntidad { set; get; }
        public string NombreProducto { set; get; }
        public double Precio { set; get; }
        public int Impuesto { set; get; }
        public int Cantidad { set; get; }
        public string Imagen { set; get; }
        public DateTime FechaVencimiento { set; get; }
        public string Descripcion { set; get; }
        public bool Estado { set; get; }
        public ProductoEntidad()
        {
        }
        public ProductoEntidad(int idProducto, int idSucursal, int idMedida, string nombreProducto, double precio, int impuesto, int cantidad, string imagen, DateTime fechaVencimiento, string descripcion, bool estado)
        {
            IdProducto = idProducto;
            sucursalEntidad.IdSucursal = idSucursal;
            medidaProductoEntidad.IdMedida = idMedida;
            NombreProducto = nombreProducto;
            Precio = precio;
            Impuesto = impuesto;
            Cantidad = cantidad;
            Imagen = imagen;
            FechaVencimiento = fechaVencimiento;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
