using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class TransferenciaDatos
    {
        public void insertar(TransferenciaEntidad transferenciaEntidad)
        {
            string sql = @"Insert into Transferencia(IdProducto,IdSucursal,Estado) values (@IdProducto,@IdSucursal,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", transferenciaEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdSucursal", transferenciaEntidad.sucursalEntidad.IdSucursal);
            cmd.Parameters.AddWithValue("@Estado", transferenciaEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(TransferenciaEntidad transferenciaEntidad)
        {
            string sql = @"Update  Transferencia SET 
            IdProducto = @IdProducto ,IdSucursal = @IdSucursal ,Estado = @Estado  Where (@IdTransferencia ="+transferenciaEntidad.IdTransferencia+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTransferencia", transferenciaEntidad.IdTransferencia);
            cmd.Parameters.AddWithValue("@IdProducto", transferenciaEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdSucursal", transferenciaEntidad.sucursalEntidad.IdSucursal);
            cmd.Parameters.AddWithValue("@Estado", transferenciaEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(TransferenciaEntidad transferenciaEntidad)
        {
            string sql = @"Delete from  Transferencia 
            Where (@IdTransferencia = IdTransferencia) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTransferencia", transferenciaEntidad.IdTransferencia);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(TransferenciaEntidad transferenciaEntidad)
        {
            string sql = @"Select  IdTransferencia,IdProducto,IdSucursal,Estado  from  Transferencia 
            Where (IdTransferencia = @IdTransferencia) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTransferencia", transferenciaEntidad.IdTransferencia);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdTransferencia,IdProducto,IdSucursal,Estado  from  Transferencia";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
