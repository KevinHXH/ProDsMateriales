using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class TipoUsuarioEntidad
    {
        public int IdTipoUsuario { set; get; }
        public string NombreTipoUsuario { set; get; }
        public bool Estado { set; get; }
        public TipoUsuarioEntidad()
        {
        }
        public TipoUsuarioEntidad(int idTipoUsuario, string nombreTipoUsuario, bool estado)
        {
            IdTipoUsuario = idTipoUsuario;
            NombreTipoUsuario = nombreTipoUsuario;
            Estado = estado;
        }
    }
}
