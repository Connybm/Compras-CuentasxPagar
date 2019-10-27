using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosCuentasxPagar.Entity
{
    public class Contacto
    {
        public int  CONTACTO { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string telefono { get; set; }
        public string EMAIL { get; set; }
        public int ESTADO { get; set; }
    }
}
