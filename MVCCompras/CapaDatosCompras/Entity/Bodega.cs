using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosCompras.Entity
{
    public class Bodega
    {
        public int BODEGA { get; set; }
        public Sucursal SUCURSAL { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string DIRECCION { get; set; }
        public int MAXSTOCK { get; set; }
        public int MIMSTOCK { get; set; }
        public string STATUS { get; set; }
        public int ESTADO { get; set; }

    }
}