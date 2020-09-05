using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class ProveedorProductoDatos
    {
        public void insertar(ProveedorProductoEntidad proveedorProductoEntidad)
        {
            string sql = @"Insert into ProveedorProducto(NombreProveedor,Identificacion,CorreoElectronico,Provincia,CodigoPostal,Telefono,FechaRegistro,Descripcion,Estado) values (@NombreProveedor,@Identificacion,@CorreoElectronico,@Provincia,@CodigoPostal,@Telefono,@FechaRegistro,@Descripcion,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@NombreProveedor", proveedorProductoEntidad.NombreProveedor);
            cmd.Parameters.AddWithValue("@Identificacion", proveedorProductoEntidad.Identificacion);
            cmd.Parameters.AddWithValue("@CorreoElectronico", proveedorProductoEntidad.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Provincia", proveedorProductoEntidad.Provincia);
            cmd.Parameters.AddWithValue("@CodigoPostal", proveedorProductoEntidad.CodigoPostal);
            cmd.Parameters.AddWithValue("@Telefono", proveedorProductoEntidad.Telefono);
            cmd.Parameters.AddWithValue("@FechaRegistro", proveedorProductoEntidad.FechaRegistro);
            cmd.Parameters.AddWithValue("@Descripcion", proveedorProductoEntidad.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", proveedorProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(ProveedorProductoEntidad proveedorProductoEntidad)
        {
            string sql = @"Update  ProveedorProducto SET 
            NombreProveedor = @NombreProveedor ,Identificacion = @Identificacion ,CorreoElectronico = @CorreoElectronico ,Provincia = @Provincia ,CodigoPostal = @CodigoPostal ,Telefono = @Telefono ,FechaRegistro = @FechaRegistro ,Descripcion = @Descripcion ,Estado = @Estado  Where (@IdProveedor ="+proveedorProductoEntidad.IdProveedor+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProveedor", proveedorProductoEntidad.IdProveedor);
            cmd.Parameters.AddWithValue("@NombreProveedor", proveedorProductoEntidad.NombreProveedor);
            cmd.Parameters.AddWithValue("@Identificacion", proveedorProductoEntidad.Identificacion);
            cmd.Parameters.AddWithValue("@CorreoElectronico", proveedorProductoEntidad.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Provincia", proveedorProductoEntidad.Provincia);
            cmd.Parameters.AddWithValue("@CodigoPostal", proveedorProductoEntidad.CodigoPostal);
            cmd.Parameters.AddWithValue("@Telefono", proveedorProductoEntidad.Telefono);
            cmd.Parameters.AddWithValue("@FechaRegistro", proveedorProductoEntidad.FechaRegistro);
            cmd.Parameters.AddWithValue("@Descripcion", proveedorProductoEntidad.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", proveedorProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(ProveedorProductoEntidad proveedorProductoEntidad)
        {
            string sql = @"Delete from  ProveedorProducto 
            Where (@IdProveedor = IdProveedor) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProveedor", proveedorProductoEntidad.IdProveedor);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(ProveedorProductoEntidad proveedorProductoEntidad)
        {
            string sql = @"Select  IdProveedor,NombreProveedor,Identificacion,CorreoElectronico,Provincia,CodigoPostal,Telefono,FechaRegistro,Descripcion,Estado  from  ProveedorProducto 
            Where (IdProveedor = @IdProveedor) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdProveedor", proveedorProductoEntidad.IdProveedor);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdProveedor,NombreProveedor,Identificacion,CorreoElectronico,Provincia,CodigoPostal,Telefono,FechaRegistro,Descripcion,Estado  from  ProveedorProducto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
