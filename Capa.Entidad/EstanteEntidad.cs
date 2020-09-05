using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class EstanteEntidad
    {
        public int IdEstante { set; get; }
        public string NombreEstante { set; get; }
        public ProductoEntidad productoEntidad { set; get; }
        public bool Estado { set; get; }
        public EstanteEntidad()
        {
        }
        public EstanteEntidad(int idEstante, string nombreEstante, int idProducto, bool estado)
        {
            IdEstante = idEstante;
            NombreEstante = nombreEstante;
            productoEntidad.IdProducto = idProducto;
            Estado = estado;
        }
    }
}
