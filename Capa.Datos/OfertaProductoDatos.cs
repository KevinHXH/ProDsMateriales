using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class OfertaProductoDatos
    {
        public void insertar(OfertaProductoEntidad ofertaProductoEntidad)
        {
            string sql = @"Insert into OfertaProducto(IdProducto,IdSucursal,Descuento,FechaOferta,DiasOferta,Descripcion,Estado) values (@IdProducto,@IdSucursal,@Descuento,@FechaOferta,@DiasOferta,@Descripcion,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", ofertaProductoEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdSucursal", ofertaProductoEntidad.sucursal.IdSucursal);
            cmd.Parameters.AddWithValue("@Descuento",  ofertaProductoEntidad.Descuento);
            cmd.Parameters.AddWithValue("@FechaOferta", ofertaProductoEntidad.FechaOferta);
            cmd.Parameters.AddWithValue("@DiasOferta", ofertaProductoEntidad.DiasOferta);
            cmd.Parameters.AddWithValue("@Descripcion", ofertaProductoEntidad.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", ofertaProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(OfertaProductoEntidad ofertaProductoEntidad)
        {
            string sql = @"Update  OfertaProducto SET 
            IdProducto = @IdProducto ,IdSucursal = @IdSucursal ,Descuento = @Descuento ,FechaOferta = @FechaOferta ,DiasOferta = @DiasOferta ,Descripcion = @Descripcion ,Estado = @Estado  Where (@IdOferta ="+ofertaProductoEntidad.IdOferta+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdOferta", ofertaProductoEntidad.IdOferta);
            cmd.Parameters.AddWithValue("@IdProducto", ofertaProductoEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdSucursal", ofertaProductoEntidad.sucursal.IdSucursal);
            cmd.Parameters.AddWithValue("@Descuento", ofertaProductoEntidad.Descuento);
            cmd.Parameters.AddWithValue("@FechaOferta", ofertaProductoEntidad.FechaOferta);
            cmd.Parameters.AddWithValue("@DiasOferta", ofertaProductoEntidad.DiasOferta);
            cmd.Parameters.AddWithValue("@Descripcion", ofertaProductoEntidad.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", ofertaProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(OfertaProductoEntidad ofertaProductoEntidad)
        {
            string sql = @"Delete from  OfertaProducto 
            Where (@IdOferta = IdOferta) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdOferta", ofertaProductoEntidad.IdOferta);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(OfertaProductoEntidad ofertaProductoEntidad)
        {
            string sql = @"Select  IdOferta,IdProducto,IdSucursal,Descuento,FechaOferta,DiasOferta,Descripcion,Estado  from  OfertaProducto 
            Where (IdOferta = @IdOferta) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdOferta", ofertaProductoEntidad.IdOferta);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdOferta,IdProducto,IdSucursal,Descuento,FechaOferta,DiasOferta,Descripcion,Estado  from  OfertaProducto ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
