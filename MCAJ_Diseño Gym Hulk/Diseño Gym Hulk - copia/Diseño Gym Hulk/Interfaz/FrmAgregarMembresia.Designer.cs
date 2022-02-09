namespace Diseño_Gym_Hulk
{
    partial class FrmAgregarMembresia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtPrecioDia = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtPrecioSemana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrecio15dias = new System.Windows.Forms.TextBox();
            this.TxtPreciomes = new System.Windows.Forms.TextBox();
            this.TxtPrecioAnio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio por dia:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(136, 52);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(145, 20);
            this.TxtDescripcion.TabIndex = 4;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // TxtPrecioDia
            // 
            this.TxtPrecioDia.Location = new System.Drawing.Point(136, 78);
            this.TxtPrecioDia.Name = "TxtPrecioDia";
            this.TxtPrecioDia.Size = new System.Drawing.Size(145, 20);
            this.TxtPrecioDia.TabIndex = 5;
            this.TxtPrecioDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioDia_KeyPress);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(152, 261);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 31);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar y salir";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(46, 261);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 31);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtPrecioSemana
            // 
            this.TxtPrecioSemana.Location = new System.Drawing.Point(136, 107);
            this.TxtPrecioSemana.Name = "TxtPrecioSemana";
            this.TxtPrecioSemana.Size = new System.Drawing.Size(145, 20);
            this.TxtPrecioSemana.TabIndex = 9;
            this.TxtPrecioSemana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioSemana_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio por semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio por 15 dias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio por mes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio por año:";
            // 
            // TxtPrecio15dias
            // 
            this.TxtPrecio15dias.Location = new System.Drawing.Point(136, 136);
            this.TxtPrecio15dias.Name = "TxtPrecio15dias";
            this.TxtPrecio15dias.Size = new System.Drawing.Size(145, 20);
            this.TxtPrecio15dias.TabIndex = 15;
            this.TxtPrecio15dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio15dias_KeyPress);
            // 
            // TxtPreciomes
            // 
            this.TxtPreciomes.Location = new System.Drawing.Point(136, 162);
            this.TxtPreciomes.Name = "TxtPreciomes";
            this.TxtPreciomes.Size = new System.Drawing.Size(145, 20);
            this.TxtPreciomes.TabIndex = 16;
            this.TxtPreciomes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreciomes_KeyPress);
            // 
            // TxtPrecioAnio
            // 
            this.TxtPrecioAnio.Location = new System.Drawing.Point(136, 189);
            this.TxtPrecioAnio.Name = "TxtPrecioAnio";
            this.TxtPrecioAnio.Size = new System.Drawing.Size(145, 20);
            this.TxtPrecioAnio.TabIndex = 17;
            this.TxtPrecioAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioAnio_KeyPress);
            // 
            // FrmAgregarMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 349);
            this.Controls.Add(this.TxtPrecioAnio);
            this.Controls.Add(this.TxtPreciomes);
            this.Controls.Add(this.TxtPrecio15dias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPrecioSemana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtPrecioDia);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmAgregarMembresia";
            this.Text = "FrmAgregarMembresia";
            this.Load += new System.EventHandler(this.FrmAgregarMembresia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtPrecioDia;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtPrecioSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrecio15dias;
        private System.Windows.Forms.TextBox TxtPreciomes;
        private System.Windows.Forms.TextBox TxtPrecioAnio;
    }
}