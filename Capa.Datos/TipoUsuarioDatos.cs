using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class TipoUsuarioDatos
    {
       public void insertar(TipoUsuarioEntidad tipoUsuario)
        {
            string sql = @"Insert into TipoUsuario(NombreTipoUsuario,Estado) values (@NombreTipoUsuario,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@NombreTipoUsuario", tipoUsuario.NombreTipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", tipoUsuario.Estado);
            cmd.CommandText = sql;
        }
       public void actualizar(TipoUsuarioEntidad tipoUsuario)
        {
            string sql = @"Update  TipoUsuario SET 
            NombreTipoUsuario = @NombreTipoUsuario ,Estado = @Estado  Where (@IdTipoUsuario ="+tipoUsuario.IdTipoUsuario+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTipoUsuario", tipoUsuario.IdTipoUsuario);
            cmd.Parameters.AddWithValue("@NombreTipoUsuario", tipoUsuario.NombreTipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", tipoUsuario.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(TipoUsuarioEntidad tipoUsuario)
        {
            string sql = @"Delete from  TipoUsuario 
            Where (@IdTipoUsuario = IdTipoUsuario) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTipoUsuario", tipoUsuario.IdTipoUsuario);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(TipoUsuarioEntidad tipoUsuario)
        {
            string sql = @"Select  IdTipoUsuario,NombreTipoUsuario,Estado  from  TipoUsuario 
            Where (IdTipoUsuario = @IdTipoUsuario) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTipoUsuario", tipoUsuario.IdTipoUsuario);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdTipoUsuario,NombreTipoUsuario,Estado  from  TipoUsuario";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
