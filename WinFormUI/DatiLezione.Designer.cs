namespace WinFormUI
{
    partial class frmDatiLezione
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
            lstStudentiPresenti = new ListBox();
            lblDescrizione = new Label();
            txtDescrizione = new TextBox();
            lblData = new Label();
            txtData = new TextBox();
            txtCognomeDocente = new TextBox();
            txtNomeDocente = new TextBox();
            txtDurata = new TextBox();
            txtOraInizio = new TextBox();
            lblOraInizio = new Label();
            lblDurata = new Label();
            txtTitoloStudio = new TextBox();
            txtNomeAula = new TextBox();
            txtCapienzaAula = new TextBox();
            txtRisorseAula = new TextBox();
            lblNomeDocente = new Label();
            lblCognomeDocente = new Label();
            lblTitoloStudio = new Label();
            lblNomeAula = new Label();
            lblCapienzaAula = new Label();
            lblRisorseAula = new Label();
            lblStudentiPresenti = new Label();
            btnStudentiAssenti = new Button();
            txtMediaPresenti = new TextBox();
            lblMediaPresenti = new Label();
            SuspendLayout();
            // 
            // lstStudentiPresenti
            // 
            lstStudentiPresenti.FormattingEnabled = true;
            lstStudentiPresenti.ItemHeight = 15;
            lstStudentiPresenti.Location = new Point(448, 24);
            lstStudentiPresenti.Name = "lstStudentiPresenti";
            lstStudentiPresenti.Size = new Size(153, 124);
            lstStudentiPresenti.TabIndex = 0;
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(12, 6);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(70, 15);
            lblDescrizione.TabIndex = 1;
            lblDescrizione.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(12, 24);
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.ReadOnly = true;
            txtDescrizione.Size = new Size(131, 23);
            txtDescrizione.TabIndex = 2;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 50);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 3;
            lblData.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Location = new Point(12, 68);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(131, 23);
            txtData.TabIndex = 4;
            // 
            // txtCognomeDocente
            // 
            txtCognomeDocente.Location = new Point(149, 68);
            txtCognomeDocente.Name = "txtCognomeDocente";
            txtCognomeDocente.ReadOnly = true;
            txtCognomeDocente.Size = new Size(131, 23);
            txtCognomeDocente.TabIndex = 5;
            // 
            // txtNomeDocente
            // 
            txtNomeDocente.Location = new Point(149, 24);
            txtNomeDocente.Name = "txtNomeDocente";
            txtNomeDocente.ReadOnly = true;
            txtNomeDocente.Size = new Size(131, 23);
            txtNomeDocente.TabIndex = 6;
            // 
            // txtDurata
            // 
            txtDurata.Location = new Point(12, 154);
            txtDurata.Name = "txtDurata";
            txtDurata.ReadOnly = true;
            txtDurata.Size = new Size(131, 23);
            txtDurata.TabIndex = 7;
            // 
            // txtOraInizio
            // 
            txtOraInizio.Location = new Point(12, 112);
            txtOraInizio.Name = "txtOraInizio";
            txtOraInizio.ReadOnly = true;
            txtOraInizio.Size = new Size(131, 23);
            txtOraInizio.TabIndex = 8;
            // 
            // lblOraInizio
            // 
            lblOraInizio.AutoSize = true;
            lblOraInizio.Location = new Point(12, 94);
            lblOraInizio.Name = "lblOraInizio";
            lblOraInizio.Size = new Size(60, 15);
            lblOraInizio.TabIndex = 9;
            lblOraInizio.Text = "Ora Inizio:";
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(12, 138);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(45, 15);
            lblDurata.TabIndex = 10;
            lblDurata.Text = "Durata:";
            // 
            // txtTitoloStudio
            // 
            txtTitoloStudio.Location = new Point(149, 112);
            txtTitoloStudio.Name = "txtTitoloStudio";
            txtTitoloStudio.ReadOnly = true;
            txtTitoloStudio.Size = new Size(131, 23);
            txtTitoloStudio.TabIndex = 11;
            // 
            // txtNomeAula
            // 
            txtNomeAula.Location = new Point(286, 24);
            txtNomeAula.Name = "txtNomeAula";
            txtNomeAula.ReadOnly = true;
            txtNomeAula.Size = new Size(131, 23);
            txtNomeAula.TabIndex = 12;
            // 
            // txtCapienzaAula
            // 
            txtCapienzaAula.Location = new Point(286, 68);
            txtCapienzaAula.Name = "txtCapienzaAula";
            txtCapienzaAula.ReadOnly = true;
            txtCapienzaAula.Size = new Size(131, 23);
            txtCapienzaAula.TabIndex = 13;
            // 
            // txtRisorseAula
            // 
            txtRisorseAula.Location = new Point(286, 112);
            txtRisorseAula.Name = "txtRisorseAula";
            txtRisorseAula.ReadOnly = true;
            txtRisorseAula.Size = new Size(131, 23);
            txtRisorseAula.TabIndex = 14;
            // 
            // lblNomeDocente
            // 
            lblNomeDocente.AutoSize = true;
            lblNomeDocente.Location = new Point(149, 6);
            lblNomeDocente.Name = "lblNomeDocente";
            lblNomeDocente.Size = new Size(90, 15);
            lblNomeDocente.TabIndex = 15;
            lblNomeDocente.Text = "Nome Docente:";
            // 
            // lblCognomeDocente
            // 
            lblCognomeDocente.AutoSize = true;
            lblCognomeDocente.Location = new Point(149, 50);
            lblCognomeDocente.Name = "lblCognomeDocente";
            lblCognomeDocente.Size = new Size(110, 15);
            lblCognomeDocente.TabIndex = 16;
            lblCognomeDocente.Text = "Cognome Docente:";
            // 
            // lblTitoloStudio
            // 
            lblTitoloStudio.AutoSize = true;
            lblTitoloStudio.Location = new Point(149, 94);
            lblTitoloStudio.Name = "lblTitoloStudio";
            lblTitoloStudio.Size = new Size(124, 15);
            lblTitoloStudio.TabIndex = 17;
            lblTitoloStudio.Text = "Titolo Studio Docente:";
            // 
            // lblNomeAula
            // 
            lblNomeAula.AutoSize = true;
            lblNomeAula.Location = new Point(286, 6);
            lblNomeAula.Name = "lblNomeAula";
            lblNomeAula.Size = new Size(70, 15);
            lblNomeAula.TabIndex = 18;
            lblNomeAula.Text = "Nome Aula:";
            // 
            // lblCapienzaAula
            // 
            lblCapienzaAula.AutoSize = true;
            lblCapienzaAula.Location = new Point(286, 50);
            lblCapienzaAula.Name = "lblCapienzaAula";
            lblCapienzaAula.Size = new Size(85, 15);
            lblCapienzaAula.TabIndex = 19;
            lblCapienzaAula.Text = "Capienza Aula:";
            // 
            // lblRisorseAula
            // 
            lblRisorseAula.AutoSize = true;
            lblRisorseAula.Location = new Point(286, 94);
            lblRisorseAula.Name = "lblRisorseAula";
            lblRisorseAula.Size = new Size(74, 15);
            lblRisorseAula.TabIndex = 20;
            lblRisorseAula.Text = "Risorse Aula:";
            // 
            // lblStudentiPresenti
            // 
            lblStudentiPresenti.AutoSize = true;
            lblStudentiPresenti.Location = new Point(448, 6);
            lblStudentiPresenti.Name = "lblStudentiPresenti";
            lblStudentiPresenti.Size = new Size(99, 15);
            lblStudentiPresenti.TabIndex = 21;
            lblStudentiPresenti.Text = "Studenti Presenti:";
            // 
            // btnStudentiAssenti
            // 
            btnStudentiAssenti.Location = new Point(448, 154);
            btnStudentiAssenti.Name = "btnStudentiAssenti";
            btnStudentiAssenti.Size = new Size(153, 23);
            btnStudentiAssenti.TabIndex = 22;
            btnStudentiAssenti.Text = "Segna Studente Assente";
            btnStudentiAssenti.UseVisualStyleBackColor = true;
            btnStudentiAssenti.Click += btnStudentiAssenti_Click;
            // 
            // txtMediaPresenti
            // 
            txtMediaPresenti.Location = new Point(149, 154);
            txtMediaPresenti.Name = "txtMediaPresenti";
            txtMediaPresenti.ReadOnly = true;
            txtMediaPresenti.Size = new Size(131, 23);
            txtMediaPresenti.TabIndex = 23;
            // 
            // lblMediaPresenti
            // 
            lblMediaPresenti.AutoSize = true;
            lblMediaPresenti.Location = new Point(149, 138);
            lblMediaPresenti.Name = "lblMediaPresenti";
            lblMediaPresenti.Size = new Size(135, 15);
            lblMediaPresenti.TabIndex = 24;
            lblMediaPresenti.Text = "Media Studenti Presenti:";
            // 
            // frmDatiLezione
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 190);
            Controls.Add(lblMediaPresenti);
            Controls.Add(txtMediaPresenti);
            Controls.Add(btnStudentiAssenti);
            Controls.Add(lblStudentiPresenti);
            Controls.Add(lblRisorseAula);
            Controls.Add(lblCapienzaAula);
            Controls.Add(lblNomeAula);
            Controls.Add(lblTitoloStudio);
            Controls.Add(lblCognomeDocente);
            Controls.Add(lblNomeDocente);
            Controls.Add(txtRisorseAula);
            Controls.Add(txtCapienzaAula);
            Controls.Add(txtNomeAula);
            Controls.Add(txtTitoloStudio);
            Controls.Add(lblDurata);
            Controls.Add(lblOraInizio);
            Controls.Add(txtOraInizio);
            Controls.Add(txtDurata);
            Controls.Add(txtNomeDocente);
            Controls.Add(txtCognomeDocente);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(txtDescrizione);
            Controls.Add(lblDescrizione);
            Controls.Add(lstStudentiPresenti);
            Name = "frmDatiLezione";
            Text = "Dati Lezione";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstStudentiPresenti;
        private Label lblDescrizione;
        private TextBox txtDescrizione;
        private Label lblData;
        private TextBox txtData;
        private TextBox txtCognomeDocente;
        private TextBox txtNomeDocente;
        private TextBox txtDurata;
        private TextBox txtOraInizio;
        private Label lblOraInizio;
        private Label lblDurata;
        private TextBox txtTitoloStudio;
        private TextBox txtNomeAula;
        private TextBox txtCapienzaAula;
        private TextBox txtRisorseAula;
        private Label lblNomeDocente;
        private Label lblCognomeDocente;
        private Label lblTitoloStudio;
        private Label lblNomeAula;
        private Label lblCapienzaAula;
        private Label lblRisorseAula;
        private Label lblStudentiPresenti;
        private Button btnStudentiAssenti;
        private TextBox txtMediaPresenti;
        private Label lblMediaPresenti;
    }
}