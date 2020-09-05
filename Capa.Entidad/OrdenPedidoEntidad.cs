using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class OrdenPedidoEntidad
    {
        public int IdOrdenPedido { set; get; }
        public ProductoEntidad productoEntidad { set; get; }
        public UsuarioEntidad usuarioEntidad { set; get; }
        public DateTime FechaPedido { set; get; }
        public DateTime FechaEntregaPedido { set; get; }
        public bool Estado { set; get; }
        public OrdenPedidoEntidad()
        {
        }
        public OrdenPedidoEntidad(int idOrdenPedido, int idProducto, int idUsuario, DateTime fechaPedido, DateTime fechaEntregaPedido, bool estado)
        {
            IdOrdenPedido = idOrdenPedido;
            productoEntidad.IdProducto = idProducto;
            usuarioEntidad.IdUsuario = idUsuario;
            FechaPedido = fechaPedido;
            FechaEntregaPedido = fechaEntregaPedido;
            Estado = estado;
        }
    }
}
