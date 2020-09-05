using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class ProveedorProductoProductoDatos
    {
        public void insertar(ProveedorProductoEntidad proveedorProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Insert into ProveedorProducto_Producto(IdProvedorProducto,IdProducto) values (@IdProvedorProducto,@IdProducto)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", proveedorProductoEntidad.IdProveedor);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void actualizar(ProveedorProductoEntidad proveedorProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Update  ProveedorProducto_Producto SET 
            IdProvedorProducto = @IdProvedorProducto ,IdProducto = @IdProducto  Where (@IdProvedorProducto ="+proveedorProductoEntidad.IdProveedor+") AND (@IdProducto ="+productoEntidad.IdProducto+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", proveedorProductoEntidad.IdProveedor);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void eliminar(ProveedorProductoEntidad proveedorProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Delete from  ProveedorProducto_Producto 
            Where (@IdProvedorProducto = IdProvedorProducto) AND (@IdProducto = IdProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", proveedorProductoEntidad.IdProveedor);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(ProveedorProductoEntidad proveedorProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Select  IdProvedorProducto,IdProducto  from  ProveedorProducto_Producto 
            Where (IdProvedorProducto = @IdProvedorProducto) AND (IdProducto = @IdProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", proveedorProductoEntidad.IdProveedor);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdProvedorProducto,IdProducto  from  ProveedorProducto_Producto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
