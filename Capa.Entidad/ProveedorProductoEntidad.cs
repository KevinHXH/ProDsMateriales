using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class ProveedorProductoEntidad
    {
        public int IdProveedor { set; get; }
        public string NombreProveedor { set; get; }
        public int Identificacion { set; get; }
        public string CorreoElectronico { set; get; }
        public string Provincia { set; get; }
        public int CodigoPostal { set; get; }
        public int Telefono { set; get; }
        public DateTime FechaRegistro { set; get; }
        public string Descripcion { set; get; }
        public bool Estado { set; get; }
        public ProveedorProductoEntidad()
        {
        }
        public ProveedorProductoEntidad(int idProveedor, string nombreProveedor, int identificacion, string correoElectronico, string provincia, int codigoPostal, int telefono, DateTime fechaRegistro, string descripcion, bool estado)
        {
            IdProveedor = idProveedor;
            NombreProveedor = nombreProveedor;
            Identificacion = identificacion;
            CorreoElectronico = correoElectronico;
            Provincia = provincia;
            CodigoPostal = codigoPostal;
            Telefono = telefono;
            FechaRegistro = fechaRegistro;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
