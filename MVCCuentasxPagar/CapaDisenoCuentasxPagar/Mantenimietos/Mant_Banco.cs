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
    public partial class Mant_Banco : Form
    {
        string usuario = "";
        public Mant_Banco()
        {
            InitializeComponent();
            //Parametros del Navegador
            usuario = "admin";
            string[] alias = { "Cod", "Banco", "Descripcion", "estado" };
            Nav_Mant_Banco.asignarAlias(alias);
            Nav_Mant_Banco.asignarAyuda("1");
            Nav_Mant_Banco.asignarSalida(this);
            Nav_Mant_Banco.asignarColorFondo(Color.White);
            Nav_Mant_Banco.asignarColorFuente(Color.Black);
            Nav_Mant_Banco.asignarTabla("Tbl_Bancos");
            Nav_Mant_Banco.asignarNombreForm("BANCOS");
            Nav_Mant_Banco.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Banco_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Banco.ObtenerIdUsuario(usuario);
            Nav_Mant_Banco.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Banco.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
