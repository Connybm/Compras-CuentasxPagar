namespace CapaDisenoCuentasxPagar.Mantenimietos
{
    partial class Mant_Servicio
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
            this.Nav_Mant_Servicio = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Servicio
            // 
            this.Nav_Mant_Servicio.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Servicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Servicio.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Servicio.Name = "Nav_Mant_Servicio";
            this.Nav_Mant_Servicio.Size = new System.Drawing.Size(1172, 654);
            this.Nav_Mant_Servicio.TabIndex = 0;
            this.Nav_Mant_Servicio.Load += new System.EventHandler(this.Nav_Mant_Servicio_Load);
            // 
            // Mant_Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 654);
            this.Controls.Add(this.Nav_Mant_Servicio);
            this.Name = "Mant_Servicio";
            this.Text = "Mant_Servicio";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Servicio;
    }
}