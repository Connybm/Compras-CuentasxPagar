using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenoCuentasxPagar.Mantenimietos
{
    public partial class Mant_Servicio : Form
    {
        string usuario = "";
        public Mant_Servicio(string usr)
        {
            InitializeComponent();
            //Parametros del Navegador
            usuario = usr;
            string[] alias = { "Cod", "Servicio", "Descripcion", "estado" };
            Nav_Mant_Servicio.asignarAlias(alias);
            Nav_Mant_Servicio.asignarAyuda("1");
            Nav_Mant_Servicio.asignarSalida(this);
            Nav_Mant_Servicio.asignarColorFondo(Color.White);
            Nav_Mant_Servicio.asignarColorFuente(Color.Black);
            Nav_Mant_Servicio.asignarTabla("Tbl_Servicio");
            Nav_Mant_Servicio.asignarNombreForm("SERVICIO");
            Nav_Mant_Servicio.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Servicio_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Servicio.ObtenerIdUsuario(usuario);
            Nav_Mant_Servicio.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Servicio.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
