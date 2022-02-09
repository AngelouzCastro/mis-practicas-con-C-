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
            this.TxtMembresia = new System.Windows.Forms.TextBox();
            this.TblMembresia = new System.Windows.Forms.DataGridView();
            this.BtnModificarMembresia = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregarMembresia = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre membresia:";
            // 
            // TxtMembresia
            // 
            this.TxtMembresia.Location = new System.Drawing.Point(130, 35);
            this.TxtMembresia.Name = "TxtMembresia";
            this.TxtMembresia.Size = new System.Drawing.Size(272, 20);
            this.TxtMembresia.TabIndex = 1;
            this.TxtMembresia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TblMembresia
            // 
            this.TblMembresia.AllowUserToAddRows = false;
            this.TblMembresia.AllowUserToDeleteRows = false;
            this.TblMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMembresia.Location = new System.Drawing.Point(27, 78);
            this.TblMembresia.Name = "TblMembresia";
            this.TblMembresia.ReadOnly = true;
            this.TblMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblMembresia.Size = new System.Drawing.Size(368, 150);
            this.TblMembresia.TabIndex = 2;
            this.TblMembresia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
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
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(431, 30);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // FrmControlMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 348);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAgregarMembresia);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificarMembresia);
            this.Controls.Add(this.TblMembresia);
            this.Controls.Add(this.TxtMembresia);
            this.Controls.Add(this.label1);
            this.Name = "FrmControlMembresia";
            this.Text = "FrmControlMembresia";
            this.Load += new System.EventHandler(this.FrmControlMembresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblMembresia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMembresia;
        private System.Windows.Forms.DataGridView TblMembresia;
        private System.Windows.Forms.Button BtnModificarMembresia;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregarMembresia;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnActualizar;
    }
}