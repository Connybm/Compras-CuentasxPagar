﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosCompras.Entity
{
    public class Proveedor
    {
        public int PROVEEDOR { get; set; }
        public Contacto CONTACTO { get; set; }
        public string NOMBRE { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string PAGINA { get; set; }
        public int ESTADO { get; set; }

    }
}