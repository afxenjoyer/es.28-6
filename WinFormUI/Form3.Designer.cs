namespace WinFormUI
{
    partial class frmElencoCorsi
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
            this.lstCorsi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCorsi
            // 
            this.lstCorsi.FormattingEnabled = true;
            this.lstCorsi.ItemHeight = 15;
            this.lstCorsi.Location = new System.Drawing.Point(12, 12);
            this.lstCorsi.Name = "lstCorsi";
            this.lstCorsi.Size = new System.Drawing.Size(321, 424);
            this.lstCorsi.TabIndex = 0;
            // 
            // frmElencoCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.lstCorsi);
            this.Name = "frmElencoCorsi";
            this.Text = "Elenco Corsi";
            this.Load += new System.EventHandler(this.frmElencoCorsi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstCorsi;
    }
}