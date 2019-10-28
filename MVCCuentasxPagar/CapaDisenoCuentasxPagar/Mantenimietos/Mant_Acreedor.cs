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
    public partial class Mant_Acreedor : Form
    {
        string usuario = "";
        public Mant_Acreedor()
        {
            InitializeComponent();
            //Parametros del Navegador
            usuario = "admin";
            string[] alias = { "Cod", "Acreedor", "Descripcion", "estado" };
            Nav_Mant_Acreedor.asignarAlias(alias);
            Nav_Mant_Acreedor.asignarAyuda("1");
            Nav_Mant_Acreedor.asignarSalida(this);
            Nav_Mant_Acreedor.asignarColorFondo(Color.White);
            Nav_Mant_Acreedor.asignarColorFuente(Color.Black);
            Nav_Mant_Acreedor.asignarTabla("Tbl_Acreedor");
            Nav_Mant_Acreedor.asignarNombreForm("ACREEDOR");
            Nav_Mant_Acreedor.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Acreedor_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Acreedor.ObtenerIdUsuario(usuario);
            Nav_Mant_Acreedor.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Acreedor.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
