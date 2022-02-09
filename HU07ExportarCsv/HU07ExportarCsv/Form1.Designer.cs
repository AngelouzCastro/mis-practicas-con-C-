
namespace HU07ExportarCsv
{
    partial class FrmArchivoCsv
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BWayuda = new System.ComponentModel.BackgroundWorker();
            this.PBCarga = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // PBCarga
            // 
            this.PBCarga.Location = new System.Drawing.Point(12, 23);
            this.PBCarga.Name = "PBCarga";
            this.PBCarga.Size = new System.Drawing.Size(240, 23);
            this.PBCarga.TabIndex = 0;
            // 
            // FrmArchivoCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 75);
            this.Controls.Add(this.PBCarga);
            this.Name = "FrmArchivoCsv";
            this.Text = "Exportando datos a CSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BWayuda;
        private System.Windows.Forms.ProgressBar PBCarga;
    }
}

