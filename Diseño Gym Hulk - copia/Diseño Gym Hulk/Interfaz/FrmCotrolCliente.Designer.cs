namespace Diseño_Gym_Hulk
{
    partial class FrmCotrolCliente
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.TblClientes = new System.Windows.Forms.DataGridView();
            this.BtnEditarCliente = new System.Windows.Forms.Button();
            this.BtnBajaCliente = new System.Windows.Forms.Button();
            this.BtnAltaCliente = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnVerCliente = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de cliente:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(138, 42);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(288, 20);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // TblClientes
            // 
            this.TblClientes.AllowUserToAddRows = false;
            this.TblClientes.AllowUserToDeleteRows = false;
            this.TblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblClientes.Location = new System.Drawing.Point(42, 109);
            this.TblClientes.Name = "TblClientes";
            this.TblClientes.ReadOnly = true;
            this.TblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblClientes.Size = new System.Drawing.Size(384, 150);
            this.TblClientes.TabIndex = 2;
            this.TblClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblClientes_CellContentClick);
            this.TblClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TblMembresias_MouseClick);
            // 
            // BtnEditarCliente
            // 
            this.BtnEditarCliente.Location = new System.Drawing.Point(455, 165);
            this.BtnEditarCliente.Name = "BtnEditarCliente";
            this.BtnEditarCliente.Size = new System.Drawing.Size(91, 37);
            this.BtnEditarCliente.TabIndex = 3;
            this.BtnEditarCliente.Text = "Editar Cliente";
            this.BtnEditarCliente.UseVisualStyleBackColor = true;
            this.BtnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // BtnBajaCliente
            // 
            this.BtnBajaCliente.Location = new System.Drawing.Point(455, 211);
            this.BtnBajaCliente.Name = "BtnBajaCliente";
            this.BtnBajaCliente.Size = new System.Drawing.Size(91, 37);
            this.BtnBajaCliente.TabIndex = 5;
            this.BtnBajaCliente.Text = "Baja de cliente";
            this.BtnBajaCliente.UseVisualStyleBackColor = true;
            this.BtnBajaCliente.Click += new System.EventHandler(this.BtnBajaCliente_Click);
            // 
            // BtnAltaCliente
            // 
            this.BtnAltaCliente.Location = new System.Drawing.Point(552, 120);
            this.BtnAltaCliente.Name = "BtnAltaCliente";
            this.BtnAltaCliente.Size = new System.Drawing.Size(75, 126);
            this.BtnAltaCliente.TabIndex = 6;
            this.BtnAltaCliente.Text = "Alta de cliente";
            this.BtnAltaCliente.UseVisualStyleBackColor = true;
            this.BtnAltaCliente.Click += new System.EventHandler(this.BtnAltaCliente_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(42, 266);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnVerCliente
            // 
            this.BtnVerCliente.Location = new System.Drawing.Point(455, 122);
            this.BtnVerCliente.Name = "BtnVerCliente";
            this.BtnVerCliente.Size = new System.Drawing.Size(91, 37);
            this.BtnVerCliente.TabIndex = 4;
            this.BtnVerCliente.Text = "Ver Cliente";
            this.BtnVerCliente.UseVisualStyleBackColor = true;
            this.BtnVerCliente.Click += new System.EventHandler(this.BtnVerCliente_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(455, 42);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar tabla";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmCotrolCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 327);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAltaCliente);
            this.Controls.Add(this.BtnBajaCliente);
            this.Controls.Add(this.BtnVerCliente);
            this.Controls.Add(this.BtnEditarCliente);
            this.Controls.Add(this.TblClientes);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmCotrolCliente";
            this.Text = "FrmCotrolCliente";
            this.Load += new System.EventHandler(this.FrmCotrolCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView TblClientes;
        private System.Windows.Forms.Button BtnEditarCliente;
        private System.Windows.Forms.Button BtnBajaCliente;
        private System.Windows.Forms.Button BtnAltaCliente;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnVerCliente;
        private System.Windows.Forms.Button BtnActualizar;
    }
}