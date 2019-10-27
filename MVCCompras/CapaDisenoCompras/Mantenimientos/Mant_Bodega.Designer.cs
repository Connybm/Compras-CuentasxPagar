namespace CapaDisenoCompras.Mantenimientos
{
    partial class Mant_Bodega
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
            this.Nav_Mant_Bodega = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Bodega
            // 
            this.Nav_Mant_Bodega.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Bodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Bodega.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Bodega.Name = "Nav_Mant_Bodega";
            this.Nav_Mant_Bodega.Size = new System.Drawing.Size(1174, 654);
            this.Nav_Mant_Bodega.TabIndex = 0;
            this.Nav_Mant_Bodega.Load += new System.EventHandler(this.Nav_Mant_Bodega_Load);
            // 
            // Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 654);
            this.Controls.Add(this.Nav_Mant_Bodega);
            this.Name = "Bodega";
            this.Text = "Bodega";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Bodega;
    }
}