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
            lblSelezionaCorso = new Label();
            lstSelezioneCorso = new ListBox();
            btnSelezionaCorso = new Button();
            SuspendLayout();
            // 
            // lblSelezionaCorso
            // 
            lblSelezionaCorso.AutoSize = true;
            lblSelezionaCorso.Font = new Font("Segoe UI", 14.25F);
            lblSelezionaCorso.Location = new Point(41, 9);
            lblSelezionaCorso.Name = "lblSelezionaCorso";
            lblSelezionaCorso.Size = new Size(176, 25);
            lblSelezionaCorso.TabIndex = 0;
            lblSelezionaCorso.Text = "Seleziona Un Corso";
            // 
            // lstSelezioneCorso
            // 
            lstSelezioneCorso.FormattingEnabled = true;
            lstSelezioneCorso.ItemHeight = 15;
            lstSelezioneCorso.Location = new Point(12, 37);
            lstSelezioneCorso.Name = "lstSelezioneCorso";
            lstSelezioneCorso.Size = new Size(248, 364);
            lstSelezioneCorso.TabIndex = 1;
            // 
            // btnSelezionaCorso
            // 
            btnSelezionaCorso.Location = new Point(12, 415);
            btnSelezionaCorso.Name = "btnSelezionaCorso";
            btnSelezionaCorso.Size = new Size(248, 23);
            btnSelezionaCorso.TabIndex = 2;
            btnSelezionaCorso.Text = "Seleziona questo Corso";
            btnSelezionaCorso.UseVisualStyleBackColor = true;
            btnSelezionaCorso.Click += btnSelezionaCorso_Click;
            // 
            // frmSelezionaCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 450);
            Controls.Add(btnSelezionaCorso);
            Controls.Add(lstSelezioneCorso);
            Controls.Add(lblSelezionaCorso);
            Name = "frmSelezionaCorso";
            Text = "Selezione Corso";
            Load += frmSelezionaCorso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelezionaCorso;
        private ListBox lstSelezioneCorso;
        private Button btnSelezionaCorso;
    }
}