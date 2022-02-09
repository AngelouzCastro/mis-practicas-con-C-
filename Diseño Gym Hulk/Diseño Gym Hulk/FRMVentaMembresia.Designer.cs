namespace Diseño_Gym_Hulk
{
    partial class FRMVentaMembresia
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
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.RbdSemana = new System.Windows.Forms.RadioButton();
            this.Rbd15dias = new System.Windows.Forms.RadioButton();
            this.RbdMes = new System.Windows.Forms.RadioButton();
            this.RbdAnio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RbdDia = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboMembresias = new System.Windows.Forms.ComboBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblFechafin = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(121, 25);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(115, 20);
            this.TxtIdCliente.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(52, 201);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // RbdSemana
            // 
            this.RbdSemana.AutoSize = true;
            this.RbdSemana.Location = new System.Drawing.Point(54, 98);
            this.RbdSemana.Name = "RbdSemana";
            this.RbdSemana.Size = new System.Drawing.Size(64, 17);
            this.RbdSemana.TabIndex = 2;
            this.RbdSemana.TabStop = true;
            this.RbdSemana.Text = "Semana";
            this.RbdSemana.UseVisualStyleBackColor = true;
            this.RbdSemana.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rbd15dias
            // 
            this.Rbd15dias.AutoSize = true;
            this.Rbd15dias.Location = new System.Drawing.Point(54, 121);
            this.Rbd15dias.Name = "Rbd15dias";
            this.Rbd15dias.Size = new System.Drawing.Size(59, 17);
            this.Rbd15dias.TabIndex = 3;
            this.Rbd15dias.TabStop = true;
            this.Rbd15dias.Text = "15 dias";
            this.Rbd15dias.UseVisualStyleBackColor = true;
            // 
            // RbdMes
            // 
            this.RbdMes.AutoSize = true;
            this.RbdMes.Location = new System.Drawing.Point(54, 144);
            this.RbdMes.Name = "RbdMes";
            this.RbdMes.Size = new System.Drawing.Size(45, 17);
            this.RbdMes.TabIndex = 4;
            this.RbdMes.TabStop = true;
            this.RbdMes.Text = "Mes";
            this.RbdMes.UseVisualStyleBackColor = true;
            // 
            // RbdAnio
            // 
            this.RbdAnio.AutoSize = true;
            this.RbdAnio.Location = new System.Drawing.Point(148, 98);
            this.RbdAnio.Name = "RbdAnio";
            this.RbdAnio.Size = new System.Drawing.Size(44, 17);
            this.RbdAnio.TabIndex = 5;
            this.RbdAnio.TabStop = true;
            this.RbdAnio.Text = "Año";
            this.RbdAnio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione fecha de inicio: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "idCliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha fin:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(171, 434);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(253, 434);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione catidad de tiempo";
            // 
            // RbdDia
            // 
            this.RbdDia.AutoSize = true;
            this.RbdDia.Location = new System.Drawing.Point(148, 122);
            this.RbdDia.Name = "RbdDia";
            this.RbdDia.Size = new System.Drawing.Size(43, 17);
            this.RbdDia.TabIndex = 14;
            this.RbdDia.TabStop = true;
            this.RbdDia.Text = "Día";
            this.RbdDia.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "idMembresia:";
            // 
            // ComboMembresias
            // 
            this.ComboMembresias.FormattingEnabled = true;
            this.ComboMembresias.Location = new System.Drawing.Point(121, 51);
            this.ComboMembresias.Name = "ComboMembresias";
            this.ComboMembresias.Size = new System.Drawing.Size(121, 21);
            this.ComboMembresias.TabIndex = 18;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(277, 82);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(35, 13);
            this.LblNombreCliente.TabIndex = 19;
            this.LblNombreCliente.Text = "label9";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(280, 99);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(41, 13);
            this.LblApellido.TabIndex = 20;
            this.LblApellido.Text = "label10";
            // 
            // LblFechafin
            // 
            this.LblFechafin.AutoSize = true;
            this.LblFechafin.Location = new System.Drawing.Point(114, 376);
            this.LblFechafin.Name = "LblFechafin";
            this.LblFechafin.Size = new System.Drawing.Size(35, 13);
            this.LblFechafin.TabIndex = 21;
            this.LblFechafin.Text = "label9";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(89, 407);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(35, 13);
            this.LblTotal.TabIndex = 22;
            this.LblTotal.Text = "label9";
            // 
            // FRMVentaMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 469);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblFechafin);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombreCliente);
            this.Controls.Add(this.ComboMembresias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RbdDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbdAnio);
            this.Controls.Add(this.RbdMes);
            this.Controls.Add(this.Rbd15dias);
            this.Controls.Add(this.RbdSemana);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TxtIdCliente);
            this.Name = "FRMVentaMembresia";
            this.Text = "Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton RbdSemana;
        private System.Windows.Forms.RadioButton Rbd15dias;
        private System.Windows.Forms.RadioButton RbdMes;
        private System.Windows.Forms.RadioButton RbdAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RbdDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboMembresias;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblFechafin;
        private System.Windows.Forms.Label LblTotal;
    }
}

