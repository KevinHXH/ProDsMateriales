using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class SucursalEntidad
    {
        public int IdSucursal { set; get; }
        public string NombreProvincia { set; get; }
        public string CorreoElectronico { set; get; }
        public string Ubicacion { set; get; }
        public int Telefono { set; get; }
        public bool Estado { set; get; }
        public SucursalEntidad()
        {
        }
        public SucursalEntidad(int idSucursal, string nombreProvincia, string correoElectronico, string ubicacion, int telefono, bool estado)
        {
            IdSucursal = idSucursal;
            NombreProvincia = nombreProvincia;
            CorreoElectronico = correoElectronico;
            Ubicacion = ubicacion;
            Telefono = telefono;
            Estado = estado;
        }
    }
}
