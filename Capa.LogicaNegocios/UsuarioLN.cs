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
    public class UsuarioLN
    {
        public static void Nuevo(UsuarioEntidad usuario)
        {
            UsuarioDatos.insertar(usuario);
        }


        public static List<UsuarioEntidad> ObtenerTodosUsuario()
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();

            DataSet ds = UsuarioDatos.seleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                UsuarioEntidad usuario = new UsuarioEntidad();
                usuario.IdUsuario = Convert.ToInt32(row["IdUsuario"]);
                usuario.tipoUsuarioEntidad = TipoUsuarioLN.Obtener(Convert.ToInt32(row["IdTipoUsuario"].ToString()));
                usuario.sucursalEntidad = SucursalLN.Obtener(Convert.ToInt32(row["IdSucursal"].ToString()));
                usuario.CorreoElectronico = row["CorreoElectronico"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.Identificacion = Convert.ToInt32(row["Identificacion"]);
                usuario.NombreUsuario = row["NombreUsuario"].ToString();
                usuario.ApellidoUsuario = row["ApellidoUsuario"].ToString();
                usuario.Telefono = Convert.ToInt32(row["Telefono"]);
                usuario.Genero = (row["Genero"].ToString());
                usuario.Edad = Convert.ToInt32(row["Edad"].ToString());
                usuario.Estado = Convert.ToBoolean(row["Estado"]);
                lista.Add(usuario);
            }
            return lista;
        }
        public static UsuarioEntidad Obtener(int idUsuario)
        {
            List<UsuarioEntidad> usuario = UsuarioLN.ObtenerTodosUsuario();
            UsuarioEntidad elemento = usuario.
                Where(x => x.IdUsuario == idUsuario).First();
            return elemento;
        }
    }
}
