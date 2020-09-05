using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class OrdenPedidoDatos
    {
        public void insertar(OrdenPedidoEntidad ordenPedidoEntidad)
        {
            string sql = @"Insert into OrdenPedido(IdProducto,IdUsuario,FechaPedido,FechaEntregaPedido,Estado) values (@IdProducto,@IdUsuario,@FechaPedido,@FechaEntregaPedido,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", ordenPedidoEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdUsuario", ordenPedidoEntidad.usuarioEntidad.IdUsuario);
            cmd.Parameters.AddWithValue("@FechaPedido", ordenPedidoEntidad.FechaPedido);
            cmd.Parameters.AddWithValue("@FechaEntregaPedido", ordenPedidoEntidad.FechaEntregaPedido);
            cmd.Parameters.AddWithValue("@Estado", ordenPedidoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(OrdenPedidoEntidad ordenPedidoEntidad)
        {
            string sql = @"Update  OrdenPedido SET 
            IdProducto = @IdProducto ,IdUsuario = @IdUsuario ,FechaPedido = @FechaPedido ,FechaEntregaPedido = @FechaEntregaPedido ,Estado = @Estado  Where (@IdOrdenPedido ="+ordenPedidoEntidad.IdOrdenPedido+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdOrdenPedido", ordenPedidoEntidad.IdOrdenPedido);
            cmd.Parameters.AddWithValue("@IdProducto", ordenPedidoEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdUsuario", ordenPedidoEntidad.usuarioEntidad.IdUsuario);
            cmd.Parameters.AddWithValue("@FechaPedido", ordenPedidoEntidad.FechaPedido);
            cmd.Parameters.AddWithValue("@FechaEntregaPedido", ordenPedidoEntidad.FechaEntregaPedido);
            cmd.Parameters.AddWithValue("@Estado", ordenPedidoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(OrdenPedidoEntidad ordenPedidoEntidad)
        {
            string sql = @"Delete from  OrdenPedido 
            Where (@IdOrdenPedido = IdOrdenPedido) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdOrdenPedido", ordenPedidoEntidad.IdOrdenPedido);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(OrdenPedidoEntidad ordenPedidoEntidad)
        {
            string sql = @"Select  IdOrdenPedido,IdProducto,IdUsuario,FechaPedido,FechaEntregaPedido,Estado  from  OrdenPedido 
            Where (IdOrdenPedido = @IdOrdenPedido) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdOrdenPedido", ordenPedidoEntidad.IdOrdenPedido);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdOrdenPedido,IdProducto,IdUsuario,FechaPedido,FechaEntregaPedido,Estado  from  OrdenPedido";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
