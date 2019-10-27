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
    public partial class Mant_Bodega : Form
    {
        string usuario = "";
        public Mant_Bodega()
        {
            InitializeComponent();
            usuario = "admin";
            string[] alias = { "Cod", "Sucursal", "Nombre", "Descripcion","Direccion","MaxStock", "MimStock", "Status", "estado" };
            Nav_Mant_Bodega.asignarAlias(alias);
            Nav_Mant_Bodega.asignarAyuda("1");
            Nav_Mant_Bodega.asignarSalida(this);
            Nav_Mant_Bodega.asignarColorFondo(Color.White);
            Nav_Mant_Bodega.asignarColorFuente(Color.Black);
            Nav_Mant_Bodega.asignarComboConTabla("Tbl_sucursal", "nombre");
            Nav_Mant_Bodega.asignarTabla("Tbl_bodega");
            Nav_Mant_Bodega.asignarNombreForm("BODEGA");
            Nav_Mant_Bodega.obtenerIdModulo(1);
            Nav_Mant_Bodega.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Bodega_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Bodega.ObtenerIdUsuario(usuario);
            Nav_Mant_Bodega.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Bodega.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
