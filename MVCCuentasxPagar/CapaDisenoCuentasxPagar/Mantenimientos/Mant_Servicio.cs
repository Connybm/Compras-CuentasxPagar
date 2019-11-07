using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenoCuentasxPagar.Mantenimientos
{
    public partial class Mant_Servicio : Form
    {
        string usuario = "";
        public Mant_Servicio(string user)
        {
            InitializeComponent();
            /// parametros
            usuario = user;
            string[] alias = { "Cod", "Servicio", "Descripcion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.BorderStyle = BorderStyle.Fixed3D;
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("Tbl_Servicio");
            navegador1.asignarNombreForm("Servicio");
        }

        private void Navegador1_Load_1(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);

        }
    }

}
