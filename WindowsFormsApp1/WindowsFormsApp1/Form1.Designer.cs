namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnFormulario2 = new System.Windows.Forms.Button();
            this.TxtEnviado = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnFormulario3 = new System.Windows.Forms.Button();
            this.TxtNumerin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(224, 71);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(143, 33);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(100, 20);
            this.TxtN.TabIndex = 2;
            // 
            // TxtN1
            // 
            this.TxtN1.Location = new System.Drawing.Point(262, 33);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(100, 20);
            this.TxtN1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(387, 36);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(13, 13);
            this.LblResultado.TabIndex = 5;
            this.LblResultado.Text = "0";
            // 
            // BtnFormulario2
            // 
            this.BtnFormulario2.Location = new System.Drawing.Point(224, 100);
            this.BtnFormulario2.Name = "BtnFormulario2";
            this.BtnFormulario2.Size = new System.Drawing.Size(75, 23);
            this.BtnFormulario2.TabIndex = 6;
            this.BtnFormulario2.Text = "Formulario2";
            this.BtnFormulario2.UseVisualStyleBackColor = true;
            this.BtnFormulario2.Click += new System.EventHandler(this.BtnFormulario2_Click);
            // 
            // TxtEnviado
            // 
            this.TxtEnviado.Location = new System.Drawing.Point(305, 103);
            this.TxtEnviado.Name = "TxtEnviado";
            this.TxtEnviado.Size = new System.Drawing.Size(100, 20);
            this.TxtEnviado.TabIndex = 7;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(248, 252);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 8;
            // 
            // BtnFormulario3
            // 
            this.BtnFormulario3.Location = new System.Drawing.Point(66, 364);
            this.BtnFormulario3.Name = "BtnFormulario3";
            this.BtnFormulario3.Size = new System.Drawing.Size(75, 23);
            this.BtnFormulario3.TabIndex = 9;
            this.BtnFormulario3.Text = "button1";
            this.BtnFormulario3.UseVisualStyleBackColor = true;
            this.BtnFormulario3.Click += new System.EventHandler(this.BtnFormulario3_Click);
            // 
            // TxtNumerin
            // 
            this.TxtNumerin.Location = new System.Drawing.Point(159, 366);
            this.TxtNumerin.Name = "TxtNumerin";
            this.TxtNumerin.Size = new System.Drawing.Size(100, 20);
            this.TxtNumerin.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNumerin);
            this.Controls.Add(this.BtnFormulario3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtEnviado);
            this.Controls.Add(this.BtnFormulario2);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnFormulario2;
        private System.Windows.Forms.TextBox TxtEnviado;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnFormulario3;
        private System.Windows.Forms.TextBox TxtNumerin;
    }
}

