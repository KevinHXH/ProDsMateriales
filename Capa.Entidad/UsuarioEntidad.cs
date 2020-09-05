using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class UsuarioEntidad
    {
        public int IdUsuario { set; get; }
        public TipoUsuarioEntidad tipoUsuarioEntidad { set; get; }
        public SucursalEntidad sucursalEntidad { set; get; }
        public string CorreoElectronico { set; get; }
        public string Password { set; get; }
        public int Identificacion { set; get; }
        public string NombreUsuario { set; get; }
        public string ApellidoUsuario { set; get; }
        public int Telefono { set; get; }
        public string Genero { set; get; }
        public int Edad { set; get; }
        public bool Estado { set; get; }
        public UsuarioEntidad()
        {
        }
        public UsuarioEntidad(int idUsuario, int idTipoUsuario, int idSucursal, string correoElectronico, string password, int identificacion, string nombreUsuario, string apellidoUsuario, int telefono, string genero, int edad, bool estado)
        {
            IdUsuario = idUsuario;
            tipoUsuarioEntidad.IdTipoUsuario = idTipoUsuario;
            sucursalEntidad.IdSucursal = idSucursal;
            CorreoElectronico = correoElectronico;
            Password = password;
            Identificacion = identificacion;
            NombreUsuario = nombreUsuario;
            ApellidoUsuario = apellidoUsuario;
            Telefono = telefono;
            Genero = genero;
            Edad = edad;
            Estado = estado;
        }
    }
}
