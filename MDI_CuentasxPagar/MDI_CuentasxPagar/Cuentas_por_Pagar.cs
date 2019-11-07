using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDisenoCuentasxPagar.Mantenimientos;

namespace MDI_CuentasxPagar
{
    public partial class Cuentas_por_Pagar : Form
    {
        string usuario = "admin";
        public Cuentas_por_Pagar()
        {
            InitializeComponent();
        }

        private void ProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Servicio servicio = new Mant_Servicio(usuario);
            servicio.TopLevel = false;
            servicio.Parent = this;
            servicio.Show();
        }

        private void PedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Pedido pedido = new Mant_Pedido(usuario);
            pedido.TopLevel = false;
            pedido.Parent = this;
            pedido.Show();
        }

        private void BancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Banco banco = new Mant_Banco(usuario);
            banco.TopLevel = false;
            banco.Parent = this;
            banco.Show();
        }
    }
}
