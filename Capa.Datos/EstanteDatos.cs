using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class EstanteDatos
    {
        public void insertar(EstanteEntidad estanteEntidad)
        {
            string sql = @"Insert into Estante(NombreEstante,IdProducto,Estado) values (@NombreEstante,@IdProducto,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@NombreEstante", estanteEntidad.NombreEstante);
            cmd.Parameters.AddWithValue("@IdProducto", estanteEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@Estado", estanteEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(EstanteEntidad estanteEntidad)
        {
            string sql = @"Update  Estante SET 
            NombreEstante = @NombreEstante ,IdProducto = @IdProducto ,Estado = @Estado  Where (@IdEstante ="+estanteEntidad.IdEstante+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdEstante", estanteEntidad.IdEstante);
            cmd.Parameters.AddWithValue("@NombreEstante", estanteEntidad.NombreEstante);
            cmd.Parameters.AddWithValue("@IdProducto", estanteEntidad.productoEntidad.IdProducto);
            cmd.Parameters.AddWithValue("@Estado", estanteEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(EstanteEntidad estanteEntidad)
        {
            string sql = @"Delete from  Estante 
            Where (@IdEstante = IdEstante) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdEstante", estanteEntidad.IdEstante);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(EstanteEntidad estanteEntidad)
        {
            string sql = @"Select  IdEstante,NombreEstante,IdProducto,Estado  from  Estante 
            Where (IdEstante = @IdEstante) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdEstante", estanteEntidad.IdEstante);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdEstante,NombreEstante,IdProducto,Estado  from  Estante";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
