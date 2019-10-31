namespace CapaDisenoCompras.Mantenimientos
{
    partial class Mant_Acreedor
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
            this.Nav_Mant_Acreedor = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Acreedor
            // 
            this.Nav_Mant_Acreedor.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Acreedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Acreedor.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Acreedor.Name = "Nav_Mant_Acreedor";
            this.Nav_Mant_Acreedor.Size = new System.Drawing.Size(1185, 663);
            this.Nav_Mant_Acreedor.TabIndex = 0;
            this.Nav_Mant_Acreedor.Load += new System.EventHandler(this.Nav_Mant_Acreedor_Load);
            // 
            // Mant_Acreedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 663);
            this.Controls.Add(this.Nav_Mant_Acreedor);
            this.Name = "Mant_Acreedor";
            this.Text = "Mant_Acreedor";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Acreedor;
    }
}