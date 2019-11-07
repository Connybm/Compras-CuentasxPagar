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
    public partial class Mant_Acreedor : Form
    {
        string usuario = "";
        public Mant_Acreedor(string user)
        {
            InitializeComponent();
            /// parametros
            usuario = user;
            string[] alias = { "Cod", "Acreedor",  "Decripcion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("3");
            navegador1.asignarTabla("Tbl_Acreedor");
            navegador1.asignarNombreForm("Acreedor");
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
