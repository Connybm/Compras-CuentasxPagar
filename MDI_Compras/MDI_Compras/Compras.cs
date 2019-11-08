using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDisenoCompras.Mantenimientos;

namespace MDI_Compras
{
    public partial class Compras : Form
    {
        string usuario = "admin";
        public Compras()
        {
            InitializeComponent();
        }

        private void AcreedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Acreedor acreedor = new Mant_Acreedor(usuario);
            acreedor.TopLevel = false;
            acreedor.Parent = this;
            acreedor.Show();
        }

        private void ContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Contacto contacto = new Mant_Contacto(usuario);
            contacto.TopLevel = false;
            contacto.Parent = this;
            contacto.Show();
        }

        private void ProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Proveedor proveedor = new Mant_Proveedor(usuario);
            proveedor.TopLevel = false;
            proveedor.Parent = this;
            proveedor.Show();
        }
    }
}
