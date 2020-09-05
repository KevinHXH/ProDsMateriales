using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
    public class CategoriaProductoEntidad
    {
        public int IdCategoriaProducto { set; get; }
        public string NombreCategoriaProducto { set; get; }
        public bool Estado { set; get; }
        public CategoriaProductoEntidad()
        {
        }
        public CategoriaProductoEntidad(int idCategoriaProducto, string nombreCategoriaProducto, bool estado)
        {
            IdCategoriaProducto = idCategoriaProducto;
            NombreCategoriaProducto = nombreCategoriaProducto;
            Estado = estado;
        }
    }
}
