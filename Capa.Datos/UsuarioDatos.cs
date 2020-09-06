using Capa.Entidad;
using ProyectoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class UsuarioDatos
    {
        public static DataSet insertar(UsuarioEntidad usuarioEntidad)
        {
            Database db = DatabaseFactory.CreateDatabase("default");
            string sql = @"Insert into Usuario(IdTipoUsuario,IdSucursal,CorreoElectronico,Password,Identificacion,NombreUsuario,ApellidoUsuario,Telefono,Genero,Edad,Estado) values (@IdTipoUsuario,@IdSucursal,@CorreoElectronico,@Password,@Identificacion,@NombreUsuario,@ApellidoUsuario,@Telefono,@Genero,@Edad,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdTipoUsuario", usuarioEntidad.tipoUsuarioEntidad.IdTipoUsuario);
            cmd.Parameters.AddWithValue("@IdSucursal", usuarioEntidad.sucursalEntidad.IdSucursal);
            cmd.Parameters.AddWithValue("@CorreoElectronico", usuarioEntidad.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Password", usuarioEntidad.Password);
            cmd.Parameters.AddWithValue("@Identificacion", usuarioEntidad.Identificacion);
            cmd.Parameters.AddWithValue("@NombreUsuario", usuarioEntidad.NombreUsuario);
            cmd.Parameters.AddWithValue("@ApellidoUsuario", usuarioEntidad.ApellidoUsuario);
            cmd.Parameters.AddWithValue("@Telefono", usuarioEntidad.Telefono);
            cmd.Parameters.AddWithValue("@Genero", usuarioEntidad.Genero);
            cmd.Parameters.AddWithValue("@Edad", usuarioEntidad.Edad);
            cmd.Parameters.AddWithValue("@Estado", usuarioEntidad.Estado);
            cmd.CommandText = sql;
            DataSet ds = db.ExecuteReader(cmd, "Usuario");
            return ds;
        }
        public void actualizar(UsuarioEntidad usuarioEntidad)
        {
            string sql = @"Update  Usuario SET 
            IdTipoUsuario = @IdTipoUsuario ,IdSucursal = @IdSucursal ,CorreoElectronico = @CorreoElectronico ,Password = @Password ,Identificacion = @Identificacion ,NombreUsuario = @NombreUsuario ,ApellidoUsuario = @ApellidoUsuario ,Telefono = @Telefono ,Genero = @Genero ,Edad = @Edad ,Estado = @Estado  Where (@IdUsuario"+usuarioEntidad.IdUsuario+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdUsuario", usuarioEntidad.IdUsuario);
            cmd.Parameters.AddWithValue("@IdTipoUsuario", usuarioEntidad.tipoUsuarioEntidad.IdTipoUsuario);
            cmd.Parameters.AddWithValue("@IdSucursal", usuarioEntidad.sucursalEntidad.IdSucursal);
            cmd.Parameters.AddWithValue("@CorreoElectronico", usuarioEntidad.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Password", usuarioEntidad.Password);
            cmd.Parameters.AddWithValue("@Identificacion", usuarioEntidad.Identificacion);
            cmd.Parameters.AddWithValue("@NombreUsuario", usuarioEntidad.NombreUsuario);
            cmd.Parameters.AddWithValue("@ApellidoUsuario", usuarioEntidad.ApellidoUsuario);
            cmd.Parameters.AddWithValue("@Telefono", usuarioEntidad.Telefono);
            cmd.Parameters.AddWithValue("@Genero", usuarioEntidad.Genero);
            cmd.Parameters.AddWithValue("@Edad", usuarioEntidad.Edad);
            cmd.Parameters.AddWithValue("@Estado", usuarioEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(UsuarioEntidad usuarioEntidad)
        {
            string sql = @"Delete from  Usuario 
            Where (@IdUsuario = IdUsuario) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdUsuario", usuarioEntidad.IdUsuario);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(UsuarioEntidad usuarioEntidad)
        {
            string sql = @"Select  IdUsuario,IdTipoUsuario,IdSucursal,CorreoElectronico,Password,Identificacion,NombreUsuario,ApellidoUsuario,Telefono,Genero,Edad,Estado  from  Usuario 
            Where (IdUsuario = @IdUsuario) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdUsuario", usuarioEntidad.IdUsuario);
            cmd.CommandText = sql;
        }
        public static DataSet seleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("default");
            string sql = @"Select  IdUsuario,IdTipoUsuario,IdSucursal,CorreoElectronico,Password,Identificacion,NombreUsuario,ApellidoUsuario,Telefono,Genero,Edad,Estado  from  Usuario";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            DataSet ds = db.ExecuteReader(cmd, "Usuario");
            return ds;
        }
    }
}
