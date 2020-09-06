using Capa.Datos;
using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.LogicaNegocios
{
    public class SucursalLN
    {
        public static List<SucursalEntidad> ObtenerTodosSucursal()
        {
            List<SucursalEntidad> lista = new List<SucursalEntidad>();

            DataSet ds = SucursalDatos.seleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                SucursalEntidad sucursal = new SucursalEntidad();
                sucursal.IdSucursal = Convert.ToInt32(row["IdSucursal"]);
                sucursal.NombreProvincia = row["NombreProvincia"].ToString();
                sucursal.CorreoElectronico = row["CorreoElectronico"].ToString();
                sucursal.Telefono = Convert.ToInt32(row["Telefono"].ToString());
                sucursal.Ubicacion = row["Ubicacion"].ToString();
                sucursal.Estado = Convert.ToBoolean(row["Estado"]);
                lista.Add(sucursal);
            }
            return lista;
        }
        public static SucursalEntidad Obtener(int idSucursal)
        {
            List<SucursalEntidad> sucursal = SucursalLN.ObtenerTodosSucursal();
            SucursalEntidad elemento = sucursal.
                Where(x => x.IdSucursal == idSucursal).First();
            return elemento;
        }
    }
}
