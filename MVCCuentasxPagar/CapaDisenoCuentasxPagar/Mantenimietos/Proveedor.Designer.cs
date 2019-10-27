namespace CapaDisenoCuentasxPagar.Mantenimietos
{
    partial class Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nav_Mant_Proveedor = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Proveedor
            // 
            this.Nav_Mant_Proveedor.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Proveedor.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Proveedor.Name = "Nav_Mant_Proveedor";
            this.Nav_Mant_Proveedor.Size = new System.Drawing.Size(1177, 659);
            this.Nav_Mant_Proveedor.TabIndex = 0;
            this.Nav_Mant_Proveedor.Load += new System.EventHandler(this.Nav_Mant_Proveedor_Load);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 659);
            this.Controls.Add(this.Nav_Mant_Proveedor);
            this.MaximumSize = new System.Drawing.Size(1193, 698);
            this.MinimumSize = new System.Drawing.Size(1193, 698);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Proveedor;
    }
}