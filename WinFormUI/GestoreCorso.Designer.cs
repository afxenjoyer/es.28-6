namespace WinFormUI
{
    partial class frmGestoreCorso
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
            lstLezioni = new ListBox();
            lstStudenti = new ListBox();
            lblLezioni = new Label();
            lblStudenti = new Label();
            btnAggiungiLezione = new Button();
            btnRimuoviLezione = new Button();
            btnDatiLezione = new Button();
            btnAggiungiStudente = new Button();
            SuspendLayout();
            // 
            // lstLezioni
            // 
            lstLezioni.FormattingEnabled = true;
            lstLezioni.HorizontalScrollbar = true;
            lstLezioni.ItemHeight = 15;
            lstLezioni.Location = new Point(12, 32);
            lstLezioni.Name = "lstLezioni";
            lstLezioni.Size = new Size(146, 184);
            lstLezioni.TabIndex = 0;
            // 
            // lstStudenti
            // 
            lstStudenti.FormattingEnabled = true;
            lstStudenti.HorizontalScrollbar = true;
            lstStudenti.ItemHeight = 15;
            lstStudenti.Location = new Point(190, 32);
            lstStudenti.Name = "lstStudenti";
            lstStudenti.Size = new Size(146, 184);
            lstStudenti.TabIndex = 2;
            // 
            // lblLezioni
            // 
            lblLezioni.AutoSize = true;
            lblLezioni.Location = new Point(12, 14);
            lblLezioni.Name = "lblLezioni";
            lblLezioni.Size = new Size(47, 15);
            lblLezioni.TabIndex = 3;
            lblLezioni.Text = "Lezioni:";
            // 
            // lblStudenti
            // 
            lblStudenti.AutoSize = true;
            lblStudenti.Location = new Point(190, 14);
            lblStudenti.Name = "lblStudenti";
            lblStudenti.Size = new Size(88, 15);
            lblStudenti.TabIndex = 4;
            lblStudenti.Text = "Studenti Corso:";
            // 
            // btnAggiungiLezione
            // 
            btnAggiungiLezione.Location = new Point(12, 224);
            btnAggiungiLezione.Name = "btnAggiungiLezione";
            btnAggiungiLezione.Size = new Size(146, 23);
            btnAggiungiLezione.TabIndex = 5;
            btnAggiungiLezione.Text = "Aggiungi Lezione";
            btnAggiungiLezione.UseVisualStyleBackColor = true;
            btnAggiungiLezione.Click += btnAggiungiLezione_Click;
            // 
            // btnRimuoviLezione
            // 
            btnRimuoviLezione.Location = new Point(12, 253);
            btnRimuoviLezione.Name = "btnRimuoviLezione";
            btnRimuoviLezione.Size = new Size(146, 23);
            btnRimuoviLezione.TabIndex = 6;
            btnRimuoviLezione.Text = "Rimuovi Lezione";
            btnRimuoviLezione.UseVisualStyleBackColor = true;
            btnRimuoviLezione.Click += btnRimuoviLezione_Click;
            // 
            // btnDatiLezione
            // 
            btnDatiLezione.Location = new Point(12, 282);
            btnDatiLezione.Name = "btnDatiLezione";
            btnDatiLezione.Size = new Size(146, 23);
            btnDatiLezione.TabIndex = 7;
            btnDatiLezione.Text = "Dati Lezione";
            btnDatiLezione.UseVisualStyleBackColor = true;
            btnDatiLezione.Click += btnDatiLezione_Click;
            // 
            // btnAggiungiStudente
            // 
            btnAggiungiStudente.Location = new Point(190, 224);
            btnAggiungiStudente.Name = "btnAggiungiStudente";
            btnAggiungiStudente.Size = new Size(146, 23);
            btnAggiungiStudente.TabIndex = 8;
            btnAggiungiStudente.Text = "Aggiungi Studente";
            btnAggiungiStudente.UseVisualStyleBackColor = true;
            btnAggiungiStudente.Click += btnAggiungiStudente_Click;
            // 
            // frmGestoreCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 323);
            Controls.Add(btnAggiungiStudente);
            Controls.Add(btnDatiLezione);
            Controls.Add(btnRimuoviLezione);
            Controls.Add(btnAggiungiLezione);
            Controls.Add(lblStudenti);
            Controls.Add(lblLezioni);
            Controls.Add(lstStudenti);
            Controls.Add(lstLezioni);
            Name = "frmGestoreCorso";
            Text = "Gestore Corso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLezioni;
        private ListBox lstStudenti;
        private Label lblLezioni;
        private Label lblStudenti;
        private Button btnAggiungiLezione;
        private Button btnRimuoviLezione;
        private Button btnDatiLezione;
        private Button btnAggiungiStudente;
    }
}