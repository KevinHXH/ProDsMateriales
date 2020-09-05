using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
   public class TransferenciaEntidad
    {
        public int IdTransferencia { set; get; }
        public ProductoEntidad productoEntidad { set; get; }
        public SucursalEntidad sucursalEntidad { set; get; }
        public bool Estado { set; get; }
        public TransferenciaEntidad()
        {
        }
        public TransferenciaEntidad(int idTransferencia, int idProducto, int idSucursal, bool estado)
        {
            IdTransferencia = idTransferencia;
            productoEntidad.IdProducto = idProducto;
            sucursalEntidad.IdSucursal = idSucursal;
            Estado = estado;
        }
    }
}
