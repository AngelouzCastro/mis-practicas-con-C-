namespace Diseño_Gym_Hulk
{
    partial class FrmPrincipal
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
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnControlCliente = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(490, 215);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(110, 66);
            this.BtnReporte.TabIndex = 0;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Location = new System.Drawing.Point(383, 53);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(117, 66);
            this.BtnVenta.TabIndex = 1;
            this.BtnVenta.Text = "Registrar visita";
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnControlCliente
            // 
            this.BtnControlCliente.Location = new System.Drawing.Point(230, 53);
            this.BtnControlCliente.Name = "BtnControlCliente";
            this.BtnControlCliente.Size = new System.Drawing.Size(118, 66);
            this.BtnControlCliente.TabIndex = 2;
            this.BtnControlCliente.Text = "Control de cliente";
            this.BtnControlCliente.UseVisualStyleBackColor = true;
            this.BtnControlCliente.Click += new System.EventHandler(this.BtnControlCliente_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Control de membresia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 318);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnControlCliente);
            this.Controls.Add(this.BtnVenta);
            this.Controls.Add(this.BtnReporte);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnControlCliente;
        private System.Windows.Forms.Button button4;
    }
}