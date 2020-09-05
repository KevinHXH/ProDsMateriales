using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class CategoriaProductoProductoDatos
    {
        public void insertar(CategoriaProductoEntidad categoriaProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Insert into CategoriaProducto_Producto(IdCategoriaProducto,IdProducto) values (@IdCategoriaProducto,@IdProducto)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void actualizar(CategoriaProductoEntidad categoriaProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Update  CategoriaProducto_Producto SET 
            IdCategoriaProducto = @IdCategoriaProducto ,IdProducto = @IdProducto  Where (@IdCategoriaProducto ="+categoriaProductoEntidad.IdCategoriaProducto+") AND (@IdProducto="+productoEntidad.IdProducto+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void eliminar(CategoriaProductoEntidad categoriaProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Delete from  CategoriaProducto_Producto 
            Where (@IdCategoriaProducto = IdCategoriaProducto) AND (@IdProducto = IdProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(CategoriaProductoEntidad categoriaProductoEntidad, ProductoEntidad productoEntidad)
        {
            string sql = @"Select  IdCategoriaProducto,IdProducto  from  CategoriaProducto_Producto 
            Where (IdCategoriaProducto = @IdCategoriaProducto) AND (IdProducto = @IdProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProvedorProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.Parameters.AddWithValue("@IdProducto", productoEntidad.IdProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdCategoriaProducto,IdProducto  from  CategoriaProducto_Producto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
