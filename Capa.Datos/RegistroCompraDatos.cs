using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class RegistroCompraDatos
    {
        public void insertar(RegistroCompraEntidad registroCompraEntidad)
        {
            string sql = @"Insert into RegistroCompra(IdProducto,NombreCliente,TotalImpuesto,SubTotal,Total,Estado) values (@IdProducto,@NombreCliente,@TotalImpuesto,@SubTotal,@Total,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", registroCompraEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@NombreCliente", registroCompraEntidad.NombreCliente);
            cmd.Parameters.AddWithValue("@TotalImpuesto", registroCompraEntidad.TotalImpuesto);
            cmd.Parameters.AddWithValue("@SubTotal", registroCompraEntidad.SubTotal);
            cmd.Parameters.AddWithValue("@Total", registroCompraEntidad.Total);
            cmd.Parameters.AddWithValue("@Estado", registroCompraEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(RegistroCompraEntidad registroCompraEntidad)
        {
            string sql = @"Update  RegistroCompra SET 
            IdProducto = @IdProducto ,NombreCliente = @NombreCliente ,TotalImpuesto = @TotalImpuesto ,SubTotal = @SubTotal ,Total = @Total ,Estado = @Estado  Where (@IdRegistroCompra ="+registroCompraEntidad.IdRegistroCompra+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdRegistroCompra", registroCompraEntidad.IdRegistroCompra);
            cmd.Parameters.AddWithValue("@IdProducto", registroCompraEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@NombreCliente", registroCompraEntidad.NombreCliente);
            cmd.Parameters.AddWithValue("@TotalImpuesto", registroCompraEntidad.TotalImpuesto);
            cmd.Parameters.AddWithValue("@SubTotal", registroCompraEntidad.SubTotal);
            cmd.Parameters.AddWithValue("@Total", registroCompraEntidad.Total);
            cmd.Parameters.AddWithValue("@Estado", registroCompraEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(RegistroCompraEntidad registroCompraEntidad)
        {
            string sql = @"Delete from  RegistroCompra 
            Where (@IdRegistroCompra = IdRegistroCompra) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdRegistroCompra", registroCompraEntidad.IdRegistroCompra);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(RegistroCompraEntidad registroCompraEntidad)
        {
            string sql = @"Select  IdRegistroCompra,IdProducto,NombreCliente,TotalImpuesto,SubTotal,Total,Estado  from  RegistroCompra 
            Where (IdRegistroCompra = @IdRegistroCompra) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdRegistroCompra", registroCompraEntidad.IdRegistroCompra);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdRegistroCompra,IdProducto,NombreCliente,TotalImpuesto,SubTotal,Total,Estado  from  RegistroCompra";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
