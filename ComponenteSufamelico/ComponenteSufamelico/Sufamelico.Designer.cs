namespace ComponenteSufamelico
{
    partial class Sufamelico
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.feliz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.feliz)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(50, 13);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 0;
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            this.Txt1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt1_KeyUp);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(47, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // feliz
            // 
            this.feliz.Image = global::ComponenteSufamelico.Properties.Resources.happy_icon_icons_com_67810;
            this.feliz.Location = new System.Drawing.Point(13, 13);
            this.feliz.Name = "feliz";
            this.feliz.Size = new System.Drawing.Size(31, 20);
            this.feliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feliz.TabIndex = 2;
            this.feliz.TabStop = false;
            // 
            // Sufamelico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feliz);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Txt1);
            this.Name = "Sufamelico";
            this.Size = new System.Drawing.Size(183, 71);
            this.Load += new System.EventHandler(this.Sufamelico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feliz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox feliz;
    }
}
