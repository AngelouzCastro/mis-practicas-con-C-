namespace MCAJ_Graficos
{
    partial class FrmPrincipal
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
            this.TxtPosX = new System.Windows.Forms.TextBox();
            this.TxtPosY = new System.Windows.Forms.TextBox();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.BtnAnimar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pos X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pos Y:";
            // 
            // TxtPosX
            // 
            this.TxtPosX.Location = new System.Drawing.Point(59, 15);
            this.TxtPosX.Name = "TxtPosX";
            this.TxtPosX.Size = new System.Drawing.Size(100, 20);
            this.TxtPosX.TabIndex = 2;
            // 
            // TxtPosY
            // 
            this.TxtPosY.Location = new System.Drawing.Point(59, 41);
            this.TxtPosY.Name = "TxtPosY";
            this.TxtPosY.Size = new System.Drawing.Size(100, 20);
            this.TxtPosY.TabIndex = 3;
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(190, 30);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(75, 23);
            this.BtnGraficar.TabIndex = 4;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // BtnAnimar
            // 
            this.BtnAnimar.Location = new System.Drawing.Point(190, 77);
            this.BtnAnimar.Name = "BtnAnimar";
            this.BtnAnimar.Size = new System.Drawing.Size(75, 23);
            this.BtnAnimar.TabIndex = 5;
            this.BtnAnimar.Text = "button1";
            this.BtnAnimar.UseVisualStyleBackColor = true;
            this.BtnAnimar.Click += new System.EventHandler(this.BtnAnimar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnAnimar);
            this.Controls.Add(this.BtnGraficar);
            this.Controls.Add(this.TxtPosY);
            this.Controls.Add(this.TxtPosX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPosX;
        private System.Windows.Forms.TextBox TxtPosY;
        private System.Windows.Forms.Button BtnGraficar;
        private System.Windows.Forms.Button BtnAnimar;
    }
}

