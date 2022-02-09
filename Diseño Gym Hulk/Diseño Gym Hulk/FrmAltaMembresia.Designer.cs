namespace Diseño_Gym_Hulk
{
    partial class FrmControlMembresia
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnModificarMembresia = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregarMembresia = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnModificarMembresia
            // 
            this.BtnModificarMembresia.Location = new System.Drawing.Point(431, 147);
            this.BtnModificarMembresia.Name = "BtnModificarMembresia";
            this.BtnModificarMembresia.Size = new System.Drawing.Size(98, 47);
            this.BtnModificarMembresia.TabIndex = 3;
            this.BtnModificarMembresia.Text = "Modificar";
            this.BtnModificarMembresia.UseVisualStyleBackColor = true;
            this.BtnModificarMembresia.Click += new System.EventHandler(this.BtnModificarMembresia_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(430, 200);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 47);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAgregarMembresia
            // 
            this.BtnAgregarMembresia.Location = new System.Drawing.Point(430, 78);
            this.BtnAgregarMembresia.Name = "BtnAgregarMembresia";
            this.BtnAgregarMembresia.Size = new System.Drawing.Size(99, 63);
            this.BtnAgregarMembresia.TabIndex = 5;
            this.BtnAgregarMembresia.Text = "Agregar nueva membresia";
            this.BtnAgregarMembresia.UseVisualStyleBackColor = true;
            this.BtnAgregarMembresia.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(27, 234);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(104, 47);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmControlMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 348);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregarMembresia);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificarMembresia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmControlMembresia";
            this.Text = "FrmControlMembresia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnModificarMembresia;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregarMembresia;
        private System.Windows.Forms.Button BtnCerrar;
    }
}