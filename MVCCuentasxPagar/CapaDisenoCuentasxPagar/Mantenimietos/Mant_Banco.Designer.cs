namespace CapaDisenoCuentasxPagar.Mantenimietos
{
    partial class Mant_Banco
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
            this.Nav_Mant_Banco = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Banco
            // 
            this.Nav_Mant_Banco.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Banco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Banco.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Banco.Name = "Nav_Mant_Banco";
            this.Nav_Mant_Banco.Size = new System.Drawing.Size(1182, 660);
            this.Nav_Mant_Banco.TabIndex = 0;
            this.Nav_Mant_Banco.Load += new System.EventHandler(this.Nav_Mant_Banco_Load);
            // 
            // Mant_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 660);
            this.Controls.Add(this.Nav_Mant_Banco);
            this.Name = "Mant_Banco";
            this.Text = "Mant_Banco";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Banco;
    }
}