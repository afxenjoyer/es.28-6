namespace WinFormUI
{
    partial class frmSelezionaCorso
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
            this.lblSelezionaCorso = new System.Windows.Forms.Label();
            this.lstSelezioneCorso = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSelezionaCorso
            // 
            this.lblSelezionaCorso.AutoSize = true;
            this.lblSelezionaCorso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelezionaCorso.Location = new System.Drawing.Point(41, 9);
            this.lblSelezionaCorso.Name = "lblSelezionaCorso";
            this.lblSelezionaCorso.Size = new System.Drawing.Size(176, 25);
            this.lblSelezionaCorso.TabIndex = 0;
            this.lblSelezionaCorso.Text = "Seleziona Un Corso";
            // 
            // lstSelezioneCorso
            // 
            this.lstSelezioneCorso.FormattingEnabled = true;
            this.lstSelezioneCorso.ItemHeight = 15;
            this.lstSelezioneCorso.Location = new System.Drawing.Point(12, 37);
            this.lstSelezioneCorso.Name = "lstSelezioneCorso";
            this.lstSelezioneCorso.Size = new System.Drawing.Size(248, 394);
            this.lstSelezioneCorso.TabIndex = 1;
            this.lstSelezioneCorso.SelectedValueChanged += new System.EventHandler(this.lstSelezioneCorso_SelectedValueChanged);
            // 
            // frmSelezionaCorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.lstSelezioneCorso);
            this.Controls.Add(this.lblSelezionaCorso);
            this.Name = "frmSelezionaCorso";
            this.Text = "Selezione Corso";
            this.Load += new System.EventHandler(this.frmSelezionaCorso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelezionaCorso;
        private ListBox lstSelezioneCorso;
    }
}