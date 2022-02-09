namespace WindowsFormsApp1
{
    partial class Formulario2
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
            this.LblResultado2 = new System.Windows.Forms.Label();
            this.LblEnviado = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblResultado2
            // 
            this.LblResultado2.AutoSize = true;
            this.LblResultado2.Location = new System.Drawing.Point(184, 127);
            this.LblResultado2.Name = "LblResultado2";
            this.LblResultado2.Size = new System.Drawing.Size(35, 13);
            this.LblResultado2.TabIndex = 0;
            this.LblResultado2.Text = "label1";
            // 
            // LblEnviado
            // 
            this.LblEnviado.AutoSize = true;
            this.LblEnviado.Location = new System.Drawing.Point(248, 127);
            this.LblEnviado.Name = "LblEnviado";
            this.LblEnviado.Size = new System.Drawing.Size(35, 13);
            this.LblEnviado.TabIndex = 1;
            this.LblEnviado.Text = "label1";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(225, 210);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(35, 13);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "label1";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(228, 81);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(219, 269);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(35, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblEnviado);
            this.Controls.Add(this.LblResultado2);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            this.Load += new System.EventHandler(this.Formulario2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResultado2;
        private System.Windows.Forms.Label LblEnviado;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label1;
    }
}