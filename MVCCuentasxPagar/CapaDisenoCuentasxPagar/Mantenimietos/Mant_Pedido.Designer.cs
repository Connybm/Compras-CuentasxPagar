namespace CapaDisenoCuentasxPagar.Mantenimietos
{
    partial class Mant_Pedido
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
            this.Nav_Mant_Pedido = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // Nav_Mant_Pedido
            // 
            this.Nav_Mant_Pedido.BackColor = System.Drawing.Color.White;
            this.Nav_Mant_Pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nav_Mant_Pedido.Location = new System.Drawing.Point(0, 0);
            this.Nav_Mant_Pedido.Name = "Nav_Mant_Pedido";
            this.Nav_Mant_Pedido.Size = new System.Drawing.Size(1173, 659);
            this.Nav_Mant_Pedido.TabIndex = 0;
            this.Nav_Mant_Pedido.Load += new System.EventHandler(this.Nav_Mant_Pedido_Load);
            // 
            // Mant_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 659);
            this.Controls.Add(this.Nav_Mant_Pedido);
            this.Name = "Mant_Pedido";
            this.Text = "Mant_Pedido";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador Nav_Mant_Pedido;
    }
}