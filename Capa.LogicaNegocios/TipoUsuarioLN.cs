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
    public class TipoUsuarioLN
    {
        public static List<TipoUsuarioEntidad> ObtenerTodosTipoUsuario()
        {
            List<TipoUsuarioEntidad> lista = new List<TipoUsuarioEntidad>();

            DataSet ds = TipoUsuarioDatos.seleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                TipoUsuarioEntidad tipoUsuario = new TipoUsuarioEntidad();
                tipoUsuario.IdTipoUsuario = Convert.ToInt32(row["IdTipoUsuario"]);
                tipoUsuario.NombreTipoUsuario = row["NombreTipoUsuario"].ToString();
                tipoUsuario.Estado = Convert.ToBoolean(row["Estado"]);
                lista.Add(tipoUsuario);
            }
            return lista;
        }
        public static TipoUsuarioEntidad Obtener(int idTipoUsuario)
        {
            List<TipoUsuarioEntidad> tipoUsuario = TipoUsuarioLN.ObtenerTodosTipoUsuario();
            TipoUsuarioEntidad elemento = tipoUsuario.
                Where(x => x.IdTipoUsuario == idTipoUsuario).First();
            return elemento;
        }
    }
}
