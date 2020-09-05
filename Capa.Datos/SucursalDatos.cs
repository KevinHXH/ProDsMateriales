using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class SucursalDatos
    {
        // Insertar
        public void insertar(SucursalEntidad sucursal) {
            string sql = @"Insert into Sucursal(NombreProvincia,CorreoElectronico,Ubicacion,Telefono,Estado) values (@NombreProvincia,@CorreoElectronico,@Ubicacion,@Telefono,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@NombreProvincia", sucursal.NombreProvincia);
            cmd.Parameters.AddWithValue("@CorreoElectronico", sucursal.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Ubicacion", sucursal.Ubicacion);
            cmd.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
            cmd.Parameters.AddWithValue("@Estado", sucursal.Estado);
            cmd.CommandText = sql;
        }
        //Actualizar
        public void actualizar(SucursalEntidad sucursal)
        {
            string sql = @"Update  Sucursal SET 
            NombreProvincia = @NombreProvincia ,CorreoElectronico = @CorreoElectronico ,Ubicacion = @Ubicacion ,Telefono = @Telefono ,Estado = @Estado  Where (@IdSucursal=" + sucursal.IdSucursal + ")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
            cmd.Parameters.AddWithValue("@NombreProvincia", sucursal.NombreProvincia);
            cmd.Parameters.AddWithValue("@CorreoElectronico", sucursal.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Ubicacion", sucursal.Ubicacion);
            cmd.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
            cmd.Parameters.AddWithValue("@Estado", sucursal.Estado);
            cmd.CommandText = sql;
        }
        //Eliminar
        public void eliminar(SucursalEntidad sucursal)
        {
            string sql = @"Delete from  Sucursal 
            Where (@IdSucursal = IdSucursal) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
            cmd.CommandText = sql;
        }
        //Seleccionar por id
        public void seleccionarPorId(SucursalEntidad sucursal)
        {
            string sql = @"Select  IdSucursal,NombreProvincia,CorreoElectronico,Ubicacion,Telefono,Estado  from  Sucursal 
            Where (IdSucursal = @IdSucursal) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
            cmd.CommandText = sql;
        }
        // Select ALL 
        public void seleccionarTodos()
        {
            string sql = @"Select  IdSucursal,NombreProvincia,CorreoElectronico,Ubicacion,Telefono,Estado  from  Sucursal";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
