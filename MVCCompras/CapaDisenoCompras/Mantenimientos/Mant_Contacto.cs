using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenoCompras.Mantenimientos
{
    public partial class Mant_Contacto : Form
    {
        string usuario = "";
        public Mant_Contacto()
        {
            InitializeComponent();
            usuario = "admin";
            string[] alias = { "Cod", "Proveedor", "Nombre", "Telefono", "Email", "estado" };
            Nav_Mant_Contacto.asignarAlias(alias);
            Nav_Mant_Contacto.asignarAyuda("1");
            Nav_Mant_Contacto.asignarSalida(this);
            Nav_Mant_Contacto.asignarColorFondo(Color.White);
            Nav_Mant_Contacto.asignarColorFuente(Color.Black);
            Nav_Mant_Contacto.asignarComboConTabla("Tbl_proveedor", "nombre");
            Nav_Mant_Contacto.asignarTabla("tbl_contacto");
            Nav_Mant_Contacto.asignarNombreForm("CONTACTO");
            Nav_Mant_Contacto.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Contacto_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Contacto.ObtenerIdUsuario(usuario);
            Nav_Mant_Contacto.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Contacto.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
