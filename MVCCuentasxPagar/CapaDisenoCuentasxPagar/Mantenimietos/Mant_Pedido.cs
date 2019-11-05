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
    public partial class Mant_Pedido : Form
    {
        string usuario = "";
        public Mant_Pedido(string usr)
        {
            InitializeComponent();
            //Parametros del Navegador
            usuario = usr;
            string[] alias = { "Pedido", "Proveedor", "Compra", "Total", "estado" };
            Nav_Mant_Pedido.asignarAlias(alias);
            Nav_Mant_Pedido.asignarAyuda("1");
            Nav_Mant_Pedido.asignarSalida(this);
            Nav_Mant_Pedido.asignarColorFondo(Color.White);
            Nav_Mant_Pedido.asignarColorFuente(Color.Black);
            Nav_Mant_Pedido.asignarComboConTabla("tbl_proveedor", "nombre", 1);
            Nav_Mant_Pedido.asignarComboConTabla("Tbl_orden_compra_encabezado", "KidOrdenCompraEncabezado", 1);
            Nav_Mant_Pedido.asignarTabla("Tbl_Pedido");
            Nav_Mant_Pedido.asignarNombreForm("PEDIDO");
            Nav_Mant_Pedido.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Pedido_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Pedido.ObtenerIdUsuario(usuario);
            Nav_Mant_Pedido.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Pedido.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
