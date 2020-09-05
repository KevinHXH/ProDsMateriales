using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class MedidaProductoEntidad
    {
        public int IdMedida { set; get; }
        public string NombreMedida { set; get; }
        public bool Estado { set; get; }
        public MedidaProductoEntidad()
        {
        }
        public MedidaProductoEntidad(int idMedida, string nombreMedida, bool estado)
        {
            IdMedida = idMedida;
            NombreMedida = nombreMedida;
            Estado = estado;
        }
    }
}
