namespace HilosGraficadores
{
    partial class FrmGrafica
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
            this.TxtCalificacion = new System.Windows.Forms.TextBox();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.TextArea = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCalificacion
            // 
            this.TxtCalificacion.Location = new System.Drawing.Point(532, 66);
            this.TxtCalificacion.Name = "TxtCalificacion";
            this.TxtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtCalificacion.TabIndex = 0;
            this.TxtCalificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtCalificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCalificacion_KeyPress);
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(552, 108);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(75, 60);
            this.BtnGraficar.TabIndex = 3;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextArea
            // 
            this.TextArea.FormattingEnabled = true;
            this.TextArea.Location = new System.Drawing.Point(532, 207);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(120, 173);
            this.TextArea.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0 - 69";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "70 - 79";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "80 - 89";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "90 - 100";
            // 
            // FrmGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.BtnGraficar);
            this.Controls.Add(this.TxtCalificacion);
            this.Name = "FrmGrafica";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.FrmGrafica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCalificacion;
        private System.Windows.Forms.Button BtnGraficar;
        private System.Windows.Forms.ListBox TextArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

