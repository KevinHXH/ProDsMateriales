using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class ProductoDatos
    {
        public void insertar(ProductoEntidad productoEntidad)
        {
            string sql = @"Insert into Producto(IdSucursal,IdMedida,NombreProducto,Precio,Impuesto,Cantidad,Imagen,FechaVencimiento,Descripcion,Estado) values (@IdSucursal,@IdMedida,@NombreProducto,@Precio,@Impuesto,@Cantidad,@Imagen,@FechaVencimiento,@Descripcion,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdSucursal", productoEntidad.sucursalEntidad.IdSucursal);
            cmd.Parameters.AddWithValue("@IdMedida", productoEntidad.medidaProductoEntidad.IdMedida);
            cmd.Parameters.AddWithValue("@NombreProducto", productoEntidad.NombreProducto);
            cmd.Parameters.AddWithValue("@Precio", productoEntidad.Precio);
            cmd.Parameters.AddWithValue("@Impuesto", productoEntidad.Impuesto);
            cmd.Parameters.AddWithValue("@Cantidad", productoEntidad.Cantidad);
            cmd.Parameters.AddWithValue("@Imagen", productoEntidad.Imagen);
            cmd.Parameters.AddWithValue("@FechaVencimiento", productoEntidad.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Descripcion", productoEntidad.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", productoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(ProductoEntidad productoEntidad)
        {
            string sql = @"Update  Producto SET 
            IdSucursal = @IdSucursal ,IdMedida = @IdMedida ,NombreProducto = @NombreProducto ,Precio = @Precio ,Impuesto = @Impuesto ,Cantidad = @Cantidad ,Imagen = @Imagen ,FechaVencimiento = @FechaVencimiento ,Descripcion = @Descripcion ,Estado = @Estado  Where (@IdProducto ="+productoEntidad.IdProducto+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@IdSucursal", productoEntidad.sucursalEntidad.IdSucursal);
            cmd.Parameters.AddWithValue("@IdMedida", productoEntidad.medidaProductoEntidad.IdMedida);
            cmd.Parameters.AddWithValue("@NombreProducto", productoEntidad.NombreProducto);
            cmd.Parameters.AddWithValue("@Precio", productoEntidad.Precio);
            cmd.Parameters.AddWithValue("@Impuesto", productoEntidad.Impuesto);
            cmd.Parameters.AddWithValue("@Cantidad", productoEntidad.Cantidad);
            cmd.Parameters.AddWithValue("@Imagen", productoEntidad.Imagen);
            cmd.Parameters.AddWithValue("@FechaVencimiento", productoEntidad.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Descripcion", productoEntidad.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", productoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(ProductoEntidad productoEntidad)
        {
            string sql = @"Delete from  Producto 
            Where (@IdProducto = IdProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(ProductoEntidad productoEntidad)
        {
            string sql = @"Select  IdProducto,IdSucursal,IdMedida,NombreProducto,Precio,Impuesto,Cantidad,Imagen,FechaVencimiento,Descripcion,Estado  from  Producto 
            Where (IdProducto = @IdProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdProducto,IdSucursal,IdMedida,NombreProducto,Precio,Impuesto,Cantidad,Imagen,FechaVencimiento,Descripcion,Estado  from  Producto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
