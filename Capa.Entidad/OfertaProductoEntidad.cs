using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class OfertaProductoEntidad
    {
        public int IdOferta { set; get; }
        public ProductoEntidad productoEntidad { set; get; }
        public SucursalEntidad sucursal { set; get; }
        public int Descuento { set; get; }
        public DateTime FechaOferta { set; get; }
        public int DiasOferta { set; get; }
        public string Descripcion { set; get; }
        public bool Estado { set; get; }
        public OfertaProductoEntidad()
        {
        }
        public OfertaProductoEntidad(int idOferta, int idProducto, int idSucursal, int descuento, DateTime fechaOferta, int diasOferta, string descripcion, bool estado)
        {
            IdOferta = idOferta;
            productoEntidad.IdProducto = idProducto;
            sucursal.IdSucursal = idSucursal;
            Descuento = descuento;
            FechaOferta = fechaOferta;
            DiasOferta = diasOferta;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
