using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class CategoriaProductoDatos
    {
        public void insertar(CategoriaProductoEntidad categoriaProductoEntidad)
        {
            string sql = @"Insert into CategoriaProducto(NombreCategoriaProducto,Estado) values (@NombreCategoriaProducto,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@NombreCategoriaProducto", categoriaProductoEntidad.NombreCategoriaProducto);
            cmd.Parameters.AddWithValue("@Estado", categoriaProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(CategoriaProductoEntidad categoriaProductoEntidad)
        {
            string sql = @"Update  CategoriaProducto SET 
            NombreCategoriaProducto = @NombreCategoriaProducto ,Estado = @Estado  Where (@IdCategoriaProducto ="+categoriaProductoEntidad.IdCategoriaProducto+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdCategoriaProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.Parameters.AddWithValue("@NombreCategoriaProducto", categoriaProductoEntidad.NombreCategoriaProducto);
            cmd.Parameters.AddWithValue("@Estado", categoriaProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(CategoriaProductoEntidad categoriaProductoEntidad)
        {
            string sql = @"Delete from  CategoriaProducto 
            Where (@IdCategoriaProducto = IdCategoriaProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdCategoriaProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(CategoriaProductoEntidad categoriaProductoEntidad)
        {
            string sql = @"Select  IdCategoriaProducto,NombreCategoriaProducto,Estado  from  CategoriaProducto 
            Where (IdCategoriaProducto = @IdCategoriaProducto) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdCategoriaProducto", categoriaProductoEntidad.IdCategoriaProducto);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdCategoriaProducto,NombreCategoriaProducto,Estado  from  CategoriaProducto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
