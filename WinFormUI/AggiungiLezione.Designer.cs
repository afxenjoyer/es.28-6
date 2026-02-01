namespace WinFormUI
{
    partial class frmAggiungiLezione
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
            lblDescrizione = new Label();
            txtDescrizioneCorso = new TextBox();
            dtpDataLezione = new DateTimePicker();
            lblDataInizio = new Label();
            dtpOrarioLezione = new DateTimePicker();
            lblOraInizio = new Label();
            lblDurataLezione = new Label();
            lblNomeDocente = new Label();
            txtNomeDocente = new TextBox();
            txtCognomeDocente = new TextBox();
            lblCognomeDocente = new Label();
            txtTitoloStudio = new TextBox();
            lblTitoloDiStudio = new Label();
            nudCapienzaAula = new NumericUpDown();
            lblCapienzaAula = new Label();
            txtNomeAula = new TextBox();
            lblNomeAula = new Label();
            txtRisorseAula = new TextBox();
            lblRisorseAula = new Label();
            btnAggiungiLezione = new Button();
            dtpDurataLezione = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudCapienzaAula).BeginInit();
            SuspendLayout();
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(12, 9);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(141, 15);
            lblDescrizione.TabIndex = 0;
            lblDescrizione.Text = "Descrizione della Lezione:";
            // 
            // txtDescrizioneCorso
            // 
            txtDescrizioneCorso.Location = new Point(12, 27);
            txtDescrizioneCorso.Name = "txtDescrizioneCorso";
            txtDescrizioneCorso.Size = new Size(200, 23);
            txtDescrizioneCorso.TabIndex = 1;
            // 
            // dtpDataLezione
            // 
            dtpDataLezione.Location = new Point(12, 72);
            dtpDataLezione.Name = "dtpDataLezione";
            dtpDataLezione.Size = new Size(200, 23);
            dtpDataLezione.TabIndex = 2;
            // 
            // lblDataInizio
            // 
            lblDataInizio.AutoSize = true;
            lblDataInizio.Location = new Point(12, 54);
            lblDataInizio.Name = "lblDataInizio";
            lblDataInizio.Size = new Size(77, 15);
            lblDataInizio.TabIndex = 3;
            lblDataInizio.Text = "Data Lezione:";
            // 
            // dtpOrarioLezione
            // 
            dtpOrarioLezione.Format = DateTimePickerFormat.Time;
            dtpOrarioLezione.Location = new Point(12, 116);
            dtpOrarioLezione.Name = "dtpOrarioLezione";
            dtpOrarioLezione.Size = new Size(200, 23);
            dtpOrarioLezione.TabIndex = 4;
            // 
            // lblOraInizio
            // 
            lblOraInizio.AutoSize = true;
            lblOraInizio.Location = new Point(12, 98);
            lblOraInizio.Name = "lblOraInizio";
            lblOraInizio.Size = new Size(60, 15);
            lblOraInizio.TabIndex = 5;
            lblOraInizio.Text = "Ora Inizio:";
            // 
            // lblDurataLezione
            // 
            lblDurataLezione.AutoSize = true;
            lblDurataLezione.Location = new Point(12, 142);
            lblDurataLezione.Name = "lblDurataLezione";
            lblDurataLezione.Size = new Size(88, 15);
            lblDurataLezione.TabIndex = 6;
            lblDurataLezione.Text = "Durata Lezione:";
            // 
            // lblNomeDocente
            // 
            lblNomeDocente.AutoSize = true;
            lblNomeDocente.Location = new Point(234, 9);
            lblNomeDocente.Name = "lblNomeDocente";
            lblNomeDocente.Size = new Size(90, 15);
            lblNomeDocente.TabIndex = 7;
            lblNomeDocente.Text = "Nome Docente:";
            // 
            // txtNomeDocente
            // 
            txtNomeDocente.Location = new Point(234, 27);
            txtNomeDocente.Name = "txtNomeDocente";
            txtNomeDocente.Size = new Size(200, 23);
            txtNomeDocente.TabIndex = 8;
            // 
            // txtCognomeDocente
            // 
            txtCognomeDocente.Location = new Point(234, 72);
            txtCognomeDocente.Name = "txtCognomeDocente";
            txtCognomeDocente.Size = new Size(200, 23);
            txtCognomeDocente.TabIndex = 9;
            // 
            // lblCognomeDocente
            // 
            lblCognomeDocente.AutoSize = true;
            lblCognomeDocente.Location = new Point(234, 54);
            lblCognomeDocente.Name = "lblCognomeDocente";
            lblCognomeDocente.Size = new Size(110, 15);
            lblCognomeDocente.TabIndex = 10;
            lblCognomeDocente.Text = "Cognome Docente:";
            // 
            // txtTitoloStudio
            // 
            txtTitoloStudio.Location = new Point(234, 116);
            txtTitoloStudio.Name = "txtTitoloStudio";
            txtTitoloStudio.Size = new Size(200, 23);
            txtTitoloStudio.TabIndex = 11;
            // 
            // lblTitoloDiStudio
            // 
            lblTitoloDiStudio.AutoSize = true;
            lblTitoloDiStudio.Location = new Point(234, 98);
            lblTitoloDiStudio.Name = "lblTitoloDiStudio";
            lblTitoloDiStudio.Size = new Size(89, 15);
            lblTitoloDiStudio.TabIndex = 12;
            lblTitoloDiStudio.Text = "Titolo di studio:";
            // 
            // nudCapienzaAula
            // 
            nudCapienzaAula.Location = new Point(455, 27);
            nudCapienzaAula.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCapienzaAula.Name = "nudCapienzaAula";
            nudCapienzaAula.Size = new Size(120, 23);
            nudCapienzaAula.TabIndex = 13;
            // 
            // lblCapienzaAula
            // 
            lblCapienzaAula.AutoSize = true;
            lblCapienzaAula.Location = new Point(455, 9);
            lblCapienzaAula.Name = "lblCapienzaAula";
            lblCapienzaAula.Size = new Size(85, 15);
            lblCapienzaAula.TabIndex = 14;
            lblCapienzaAula.Text = "Capienza Aula:";
            // 
            // txtNomeAula
            // 
            txtNomeAula.Location = new Point(455, 72);
            txtNomeAula.Name = "txtNomeAula";
            txtNomeAula.Size = new Size(200, 23);
            txtNomeAula.TabIndex = 15;
            // 
            // lblNomeAula
            // 
            lblNomeAula.AutoSize = true;
            lblNomeAula.Location = new Point(455, 54);
            lblNomeAula.Name = "lblNomeAula";
            lblNomeAula.Size = new Size(70, 15);
            lblNomeAula.TabIndex = 16;
            lblNomeAula.Text = "Nome Aula:";
            // 
            // txtRisorseAula
            // 
            txtRisorseAula.Location = new Point(455, 116);
            txtRisorseAula.Name = "txtRisorseAula";
            txtRisorseAula.Size = new Size(200, 23);
            txtRisorseAula.TabIndex = 17;
            // 
            // lblRisorseAula
            // 
            lblRisorseAula.AutoSize = true;
            lblRisorseAula.Location = new Point(455, 98);
            lblRisorseAula.Name = "lblRisorseAula";
            lblRisorseAula.Size = new Size(71, 15);
            lblRisorseAula.TabIndex = 18;
            lblRisorseAula.Text = "Risorse Aula";
            // 
            // btnAggiungiLezione
            // 
            btnAggiungiLezione.Location = new Point(564, 145);
            btnAggiungiLezione.Name = "btnAggiungiLezione";
            btnAggiungiLezione.Size = new Size(91, 52);
            btnAggiungiLezione.TabIndex = 19;
            btnAggiungiLezione.Text = "Aggiungi Lezione";
            btnAggiungiLezione.UseVisualStyleBackColor = true;
            btnAggiungiLezione.Click += btnAggiungiLezione_Click;
            // 
            // dtpDurataLezione
            // 
            dtpDurataLezione.Format = DateTimePickerFormat.Time;
            dtpDurataLezione.Location = new Point(12, 160);
            dtpDurataLezione.Name = "dtpDurataLezione";
            dtpDurataLezione.Size = new Size(200, 23);
            dtpDurataLezione.TabIndex = 20;
            // 
            // frmAggiungiLezione
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 209);
            Controls.Add(dtpDurataLezione);
            Controls.Add(btnAggiungiLezione);
            Controls.Add(lblRisorseAula);
            Controls.Add(txtRisorseAula);
            Controls.Add(lblNomeAula);
            Controls.Add(txtNomeAula);
            Controls.Add(lblCapienzaAula);
            Controls.Add(nudCapienzaAula);
            Controls.Add(lblTitoloDiStudio);
            Controls.Add(txtTitoloStudio);
            Controls.Add(lblCognomeDocente);
            Controls.Add(txtCognomeDocente);
            Controls.Add(txtNomeDocente);
            Controls.Add(lblNomeDocente);
            Controls.Add(lblDurataLezione);
            Controls.Add(lblOraInizio);
            Controls.Add(dtpOrarioLezione);
            Controls.Add(lblDataInizio);
            Controls.Add(dtpDataLezione);
            Controls.Add(txtDescrizioneCorso);
            Controls.Add(lblDescrizione);
            Name = "frmAggiungiLezione";
            Text = "Aggiungi Lezione";
            ((System.ComponentModel.ISupportInitialize)nudCapienzaAula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescrizione;
        private TextBox txtDescrizioneCorso;
        private DateTimePicker dtpDataLezione;
        private Label lblDataInizio;
        private DateTimePicker dtpOrarioLezione;
        private Label lblOraInizio;
        private Label lblDurataLezione;
        private Label lblNomeDocente;
        private TextBox txtNomeDocente;
        private TextBox txtCognomeDocente;
        private Label lblCognomeDocente;
        private TextBox txtTitoloStudio;
        private Label lblTitoloDiStudio;
        private NumericUpDown nudCapienzaAula;
        private Label lblCapienzaAula;
        private TextBox txtNomeAula;
        private Label lblNomeAula;
        private TextBox txtRisorseAula;
        private Label lblRisorseAula;
        private Button btnAggiungiLezione;
        private DateTimePicker dtpDurataLezione;
    }
}