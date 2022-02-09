namespace MCAJ_UsoComponente
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
            this.cajaDoble1 = new MCAJ_EjemploComponentes.CajaDoble();
            this.SuspendLayout();
            // 
            // cajaDoble1
            // 
            this.cajaDoble1.Location = new System.Drawing.Point(33, 31);
            this.cajaDoble1.Name = "cajaDoble1";
            this.cajaDoble1.Size = new System.Drawing.Size(110, 52);
            this.cajaDoble1.TabIndex = 0;
            this.cajaDoble1.VecesRepeticion = 1000;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 139);
            this.Controls.Add(this.cajaDoble1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MCAJ_EjemploComponentes.CajaDoble cajaDoble1;
    }
}

