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
    public partial class Mant_Proveedor : Form
    {
        string usuario = "";
        public Mant_Proveedor(string usr)
        {
            InitializeComponent();
            //Parametros del Navegador
            usuario = usr;
            string[] alias = { "Cod", "proveedor", "telefono", "direccion", "pagina", "estado" };
            Nav_Mant_Proveedor.asignarAlias(alias);
            Nav_Mant_Proveedor.asignarAyuda("1");
            Nav_Mant_Proveedor.asignarSalida(this);
            Nav_Mant_Proveedor.asignarColorFondo(Color.White);
            Nav_Mant_Proveedor.asignarColorFuente(Color.Black);
            Nav_Mant_Proveedor.asignarTabla("tbl_proveedor");
            Nav_Mant_Proveedor.asignarNombreForm("Proveedores");
            Nav_Mant_Proveedor.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Proveedor_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Proveedor.ObtenerIdUsuario(usuario);
            Nav_Mant_Proveedor.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Proveedor.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
