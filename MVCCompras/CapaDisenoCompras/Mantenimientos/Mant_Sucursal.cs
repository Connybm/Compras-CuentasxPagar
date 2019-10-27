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
    public partial class Mant_Sucursal : Form
    {
        string usuario = "";
        public Mant_Sucursal()
        {
            InitializeComponent();
            usuario = "admin";
            string[] alias = { "Cod", "Sucursal", "Direccion", "Estado" };
            Nav_Mant_Sucursal.asignarAlias(alias);
            Nav_Mant_Sucursal.asignarAyuda("1");
            Nav_Mant_Sucursal.asignarSalida(this);
            Nav_Mant_Sucursal.asignarColorFondo(Color.White);
            Nav_Mant_Sucursal.asignarColorFuente(Color.Black);
            Nav_Mant_Sucursal.asignarTabla("Tbl_Sucursal");
            Nav_Mant_Sucursal.asignarNombreForm("SUCURSAL");
            Nav_Mant_Sucursal.obtenerIdModulo(1);
            Nav_Mant_Sucursal.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Sucursal_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Sucursal.ObtenerIdUsuario(usuario);
            Nav_Mant_Sucursal.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Sucursal.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
