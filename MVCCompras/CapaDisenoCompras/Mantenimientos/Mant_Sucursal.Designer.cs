namespace CapaDisenoCompras.Mantenimientos
{
    partial class Mant_Sucursal
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
            this.Nav_Mant_Sucursal = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Sucursal
            // 
            this.Nav_Mant_Sucursal.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Sucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Sucursal.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Sucursal.Name = "Nav_Mant_Sucursal";
            this.Nav_Mant_Sucursal.Size = new System.Drawing.Size(1196, 662);
            this.Nav_Mant_Sucursal.TabIndex = 0;
            this.Nav_Mant_Sucursal.Load += new System.EventHandler(this.Nav_Mant_Sucursal_Load);
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 662);
            this.Controls.Add(this.Nav_Mant_Sucursal);
            this.Name = "Sucursal";
            this.Text = "Sucursal";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Sucursal;
    }
}