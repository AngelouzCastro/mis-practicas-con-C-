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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMVentaMembresia));
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
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TblClientes = new System.Windows.Forms.DataGridView();
            this.TblMembresia = new System.Windows.Forms.DataGridView();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.LblMem = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtMembresia = new System.Windows.Forms.TextBox();
            this.LblIdMembresia = new System.Windows.Forms.Label();
            this.TxtDinero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).BeginInit();
            this.SuspendLayout();
            // 
            // RbdSemana
            // 
            this.RbdSemana.AutoSize = true;
            this.RbdSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdSemana.Location = new System.Drawing.Point(435, 178);
            this.RbdSemana.Name = "RbdSemana";
            this.RbdSemana.Size = new System.Drawing.Size(70, 17);
            this.RbdSemana.TabIndex = 2;
            this.RbdSemana.TabStop = true;
            this.RbdSemana.Text = "Semana";
            this.RbdSemana.UseVisualStyleBackColor = true;
            this.RbdSemana.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.RbdSemana.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdSemana_MouseClick);
            // 
            // Rbd15dias
            // 
            this.Rbd15dias.AutoSize = true;
            this.Rbd15dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbd15dias.Location = new System.Drawing.Point(435, 201);
            this.Rbd15dias.Name = "Rbd15dias";
            this.Rbd15dias.Size = new System.Drawing.Size(68, 17);
            this.Rbd15dias.TabIndex = 3;
            this.Rbd15dias.TabStop = true;
            this.Rbd15dias.Text = "15 días";
            this.Rbd15dias.UseVisualStyleBackColor = true;
            this.Rbd15dias.CheckedChanged += new System.EventHandler(this.Rbd15dias_CheckedChanged);
            this.Rbd15dias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Rbd15dias_MouseClick);
            // 
            // RbdMes
            // 
            this.RbdMes.AutoSize = true;
            this.RbdMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdMes.Location = new System.Drawing.Point(529, 155);
            this.RbdMes.Name = "RbdMes";
            this.RbdMes.Size = new System.Drawing.Size(48, 17);
            this.RbdMes.TabIndex = 4;
            this.RbdMes.TabStop = true;
            this.RbdMes.Text = "Mes";
            this.RbdMes.UseVisualStyleBackColor = true;
            this.RbdMes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdMes_MouseClick);
            // 
            // RbdAnio
            // 
            this.RbdAnio.AutoSize = true;
            this.RbdAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdAnio.Location = new System.Drawing.Point(529, 178);
            this.RbdAnio.Name = "RbdAnio";
            this.RbdAnio.Size = new System.Drawing.Size(47, 17);
            this.RbdAnio.TabIndex = 5;
            this.RbdAnio.TabStop = true;
            this.RbdAnio.Text = "Año";
            this.RbdAnio.UseVisualStyleBackColor = true;
            this.RbdAnio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdAnio_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione fecha de inicio: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(430, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total:  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha fin:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(560, 437);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(642, 437);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione catidad de tiempo";
            // 
            // RbdDia
            // 
            this.RbdDia.AutoSize = true;
            this.RbdDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbdDia.Location = new System.Drawing.Point(435, 155);
            this.RbdDia.Name = "RbdDia";
            this.RbdDia.Size = new System.Drawing.Size(46, 17);
            this.RbdDia.TabIndex = 14;
            this.RbdDia.TabStop = true;
            this.RbdDia.Text = "Día";
            this.RbdDia.UseVisualStyleBackColor = true;
            this.RbdDia.CheckedChanged += new System.EventHandler(this.RbdDia_CheckedChanged);
            this.RbdDia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RbdDia_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo de Membresia:";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCliente.Location = new System.Drawing.Point(581, 59);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(125, 15);
            this.LblNombreCliente.TabIndex = 19;
            this.LblNombreCliente.Text = "Seleccione cliente";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(581, 81);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(125, 15);
            this.LblApellido.TabIndex = 20;
            this.LblApellido.Text = "Seleccione cliente";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(524, 361);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(24, 25);
            this.LblTotal.TabIndex = 22;
            this.LblTotal.Text = "0";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaInicio.Location = new System.Drawing.Point(435, 270);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaInicio.TabIndex = 23;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.CustomFormat = "yyyy/MM/dd";
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaFin.Location = new System.Drawing.Point(435, 328);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFin.TabIndex = 24;
            // 
            // TblClientes
            // 
            this.TblClientes.AllowUserToAddRows = false;
            this.TblClientes.AllowUserToDeleteRows = false;
            this.TblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblClientes.Location = new System.Drawing.Point(12, 68);
            this.TblClientes.Name = "TblClientes";
            this.TblClientes.ReadOnly = true;
            this.TblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblClientes.Size = new System.Drawing.Size(384, 150);
            this.TblClientes.TabIndex = 25;
            this.TblClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TblClientes_MouseClick);
            // 
            // TblMembresia
            // 
            this.TblMembresia.AllowUserToAddRows = false;
            this.TblMembresia.AllowUserToDeleteRows = false;
            this.TblMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMembresia.Location = new System.Drawing.Point(12, 273);
            this.TblMembresia.Name = "TblMembresia";
            this.TblMembresia.ReadOnly = true;
            this.TblMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblMembresia.Size = new System.Drawing.Size(384, 150);
            this.TblMembresia.TabIndex = 26;
            this.TblMembresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblMembresia_CellContentClick);
            this.TblMembresia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TblMembresia_MouseClick);
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdCliente.Location = new System.Drawing.Point(581, 35);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(125, 15);
            this.LblIdCliente.TabIndex = 27;
            this.LblIdCliente.Text = "Seleccione cliente";
            // 
            // LblMem
            // 
            this.LblMem.AutoSize = true;
            this.LblMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMem.Location = new System.Drawing.Point(581, 107);
            this.LblMem.Name = "LblMem";
            this.LblMem.Size = new System.Drawing.Size(154, 15);
            this.LblMem.TabIndex = 28;
            this.LblMem.Text = "Seleccione membresia";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(143, 42);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(253, 20);
            this.TxtCliente.TabIndex = 29;
            this.TxtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TxtMembresia
            // 
            this.TxtMembresia.Location = new System.Drawing.Point(143, 236);
            this.TxtMembresia.Name = "TxtMembresia";
            this.TxtMembresia.Size = new System.Drawing.Size(253, 20);
            this.TxtMembresia.TabIndex = 30;
            this.TxtMembresia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMembresia_KeyPress);
            // 
            // LblIdMembresia
            // 
            this.LblIdMembresia.AutoSize = true;
            this.LblIdMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMembresia.Location = new System.Drawing.Point(564, 109);
            this.LblIdMembresia.Name = "LblIdMembresia";
            this.LblIdMembresia.Size = new System.Drawing.Size(15, 15);
            this.LblIdMembresia.TabIndex = 35;
            this.LblIdMembresia.Text = "0";
            // 
            // TxtDinero
            // 
            this.TxtDinero.Location = new System.Drawing.Point(435, 402);
            this.TxtDinero.Name = "TxtDinero";
            this.TxtDinero.Size = new System.Drawing.Size(100, 20);
            this.TxtDinero.TabIndex = 36;
            this.TxtDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDinero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Nombre de cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Nombre membresia:";
            // 
            // FRMVentaMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 469);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtDinero);
            this.Controls.Add(this.LblIdMembresia);
            this.Controls.Add(this.TxtMembresia);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.LblMem);
            this.Controls.Add(this.LblIdCliente);
            this.Controls.Add(this.TblMembresia);
            this.Controls.Add(this.TblClientes);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombreCliente);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMVentaMembresia";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FRMVentaMembresia_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRMVentaMembresia_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.DataGridView TblClientes;
        private System.Windows.Forms.DataGridView TblMembresia;
        private System.Windows.Forms.Label LblIdCliente;
        private System.Windows.Forms.Label LblMem;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtMembresia;
        private System.Windows.Forms.Label LblIdMembresia;
        private System.Windows.Forms.TextBox TxtDinero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

