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
    public partial class Mant_Pedido : Form
    {
        string usuario = "";
        public Mant_Pedido(string user)
        {
            InitializeComponent();
            /// parametros
            usuario = user;
            string[] alias = { "Cod", "Pedido", "Documento", "Total", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("Tbl_proveedor", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_orden_compra_encabezado", "KidOrdenCompraEncabezado", 1);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("Tbl_Pedido");
            navegador1.asignarNombreForm("Pedido");
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
