namespace MCAJ_Sufamelico
{
    partial class FrmSufamelico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSufamelico));
            this.sufamelico1 = new ComponenteSufamelico.Sufamelico();
            this.SuspendLayout();
            // 
            // sufamelico1
            // 
            this.sufamelico1.Location = new System.Drawing.Point(8, 12);
            this.sufamelico1.Name = "sufamelico1";
            this.sufamelico1.Size = new System.Drawing.Size(150, 128);
            this.sufamelico1.TabIndex = 0;
            this.sufamelico1.valor = true;
            this.sufamelico1.Load += new System.EventHandler(this.sufamelico1_Load);
            // 
            // FrmSufamelico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 154);
            this.Controls.Add(this.sufamelico1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSufamelico";
            this.Text = "Sufamelico";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponenteSufamelico.Sufamelico sufamelico1;
    }
}

