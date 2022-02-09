namespace MCAJ_AlarmaCumpleDany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnCorrer = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(78, 35);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // BtnCorrer
            // 
            this.BtnCorrer.Location = new System.Drawing.Point(30, 144);
            this.BtnCorrer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCorrer.Name = "BtnCorrer";
            this.BtnCorrer.Size = new System.Drawing.Size(87, 38);
            this.BtnCorrer.TabIndex = 1;
            this.BtnCorrer.Text = "Correr";
            this.BtnCorrer.UseVisualStyleBackColor = true;
            this.BtnCorrer.Click += new System.EventHandler(this.BtnCorrer_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.Location = new System.Drawing.Point(122, 144);
            this.BtnParar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(87, 38);
            this.BtnParar.TabIndex = 2;
            this.BtnParar.Text = "Parar";
            this.BtnParar.UseVisualStyleBackColor = true;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(80, 88);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::MCAJ_AlarmaCumpleDany.Properties.Resources.holochain_block;
            this.ClientSize = new System.Drawing.Size(243, 223);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnCorrer);
            this.Controls.Add(this.dateTimePicker);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCAJ_Alarma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button BtnCorrer;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Label lblStatus;
    }
}

