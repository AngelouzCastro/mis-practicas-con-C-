namespace MCAJ_Aeropuerto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoleto = new System.Windows.Forms.TextBox();
            this.TxtMaleta = new System.Windows.Forms.TextBox();
            this.DtgTabla = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblTotalPeso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDinero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boleto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maleta:";
            // 
            // TxtBoleto
            // 
            this.TxtBoleto.Location = new System.Drawing.Point(103, 53);
            this.TxtBoleto.Name = "TxtBoleto";
            this.TxtBoleto.Size = new System.Drawing.Size(100, 20);
            this.TxtBoleto.TabIndex = 2;
            // 
            // TxtMaleta
            // 
            this.TxtMaleta.Location = new System.Drawing.Point(103, 80);
            this.TxtMaleta.Name = "TxtMaleta";
            this.TxtMaleta.Size = new System.Drawing.Size(100, 20);
            this.TxtMaleta.TabIndex = 3;
            // 
            // DtgTabla
            // 
            this.DtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTabla.Location = new System.Drawing.Point(53, 151);
            this.DtgTabla.Name = "DtgTabla";
            this.DtgTabla.Size = new System.Drawing.Size(344, 150);
            this.DtgTabla.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(103, 107);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblTotalPeso
            // 
            this.LblTotalPeso.AutoSize = true;
            this.LblTotalPeso.Location = new System.Drawing.Point(88, 324);
            this.LblTotalPeso.Name = "LblTotalPeso";
            this.LblTotalPeso.Size = new System.Drawing.Size(13, 13);
            this.LblTotalPeso.TabIndex = 6;
            this.LblTotalPeso.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Peso Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PrecioExtra:";
            // 
            // LblDinero
            // 
            this.LblDinero.AutoSize = true;
            this.LblDinero.Location = new System.Drawing.Point(91, 341);
            this.LblDinero.Name = "LblDinero";
            this.LblDinero.Size = new System.Drawing.Size(13, 13);
            this.LblDinero.TabIndex = 9;
            this.LblDinero.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "GRAFICA-PESO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "kg.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDinero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTotalPeso);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DtgTabla);
            this.Controls.Add(this.TxtMaleta);
            this.Controls.Add(this.TxtBoleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoleto;
        private System.Windows.Forms.TextBox TxtMaleta;
        private System.Windows.Forms.DataGridView DtgTabla;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblTotalPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDinero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

