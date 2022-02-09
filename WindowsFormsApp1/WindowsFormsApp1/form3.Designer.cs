namespace WindowsFormsApp1
{
    partial class form3
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
            this.TxtNumeraso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNumeraso
            // 
            this.TxtNumeraso.Location = new System.Drawing.Point(58, 54);
            this.TxtNumeraso.Name = "TxtNumeraso";
            this.TxtNumeraso.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeraso.TabIndex = 0;
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 227);
            this.Controls.Add(this.TxtNumeraso);
            this.Name = "form3";
            this.Text = "form3";
            this.Load += new System.EventHandler(this.form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumeraso;
    }
}