namespace MCAJ_Graficoyo
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PtbMaquina = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbMaquina
            // 
            this.PtbMaquina.Image = global::MCAJ_Graficoyo.Properties.Resources.favicon;
            this.PtbMaquina.Location = new System.Drawing.Point(30, 22);
            this.PtbMaquina.Name = "PtbMaquina";
            this.PtbMaquina.Size = new System.Drawing.Size(100, 50);
            this.PtbMaquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbMaquina.TabIndex = 0;
            this.PtbMaquina.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(443, 364);
            this.Controls.Add(this.PtbMaquina);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbMaquina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbMaquina;
    }
}

