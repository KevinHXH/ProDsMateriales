using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class MedidaProductoDatos
    {
        public void insertar(MedidaProductoEntidad medidaProductoEntidad)
        {
            string sql = @"Insert into MedidaProducto(NombreMedida,Estado) values (@NombreMedida,@Estado)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@NombreMedida", medidaProductoEntidad.NombreMedida);
            cmd.Parameters.AddWithValue("@Estado", medidaProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void actualizar(MedidaProductoEntidad medidaProductoEntidad)
        {
            string sql = @"Update  MedidaProducto SET 
            NombreMedida = @NombreMedida ,Estado = @Estado  Where (@IdMedida ="+medidaProductoEntidad.IdMedida+")";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdMedida", medidaProductoEntidad.IdMedida);
            cmd.Parameters.AddWithValue("@NombreMedida", medidaProductoEntidad.NombreMedida);
            cmd.Parameters.AddWithValue("@Estado", medidaProductoEntidad.Estado);
            cmd.CommandText = sql;
        }
        public void eliminar(MedidaProductoEntidad medidaProductoEntidad)
        {
            string sql = @"Delete from  MedidaProducto 
            Where (@IdMedida = IdMedida) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdMedida", medidaProductoEntidad.IdMedida);
            cmd.CommandText = sql;
        }
        public void seleccionarPorId(MedidaProductoEntidad medidaProductoEntidad)
        {
            string sql = @"Select  IdMedida,NombreMedida,Estado  from  MedidaProducto 
 n          Where (IdMedida = @IdMedida) ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdMedida", medidaProductoEntidad.IdMedida);
            cmd.CommandText = sql;
        }
        public void seleccionarTodos()
        {
            string sql = @"Select  IdMedida,NombreMedida,Estado  from  MedidaProducto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
        }
    }
}
