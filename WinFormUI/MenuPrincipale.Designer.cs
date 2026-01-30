namespace WinFormUI
{
    partial class MenuPrincipale
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
            btnAggiungiCorso = new Button();
            btnSelezionaCorso = new Button();
            btnElencaCorsi = new Button();
            btnSalva = new Button();
            lblMenuPrincipale = new Label();
            btnCarica = new Button();
            sfdSerializzazione = new SaveFileDialog();
            ofdDeserializzazione = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnAggiungiCorso
            // 
            btnAggiungiCorso.Location = new Point(88, 77);
            btnAggiungiCorso.Name = "btnAggiungiCorso";
            btnAggiungiCorso.Size = new Size(208, 68);
            btnAggiungiCorso.TabIndex = 0;
            btnAggiungiCorso.Text = "Aggiungi un corso";
            btnAggiungiCorso.UseVisualStyleBackColor = true;
            btnAggiungiCorso.Click += btnAggiungiCorso_Click;
            // 
            // btnSelezionaCorso
            // 
            btnSelezionaCorso.Location = new Point(88, 151);
            btnSelezionaCorso.Name = "btnSelezionaCorso";
            btnSelezionaCorso.Size = new Size(208, 68);
            btnSelezionaCorso.TabIndex = 1;
            btnSelezionaCorso.Text = "Seleziona un corso";
            btnSelezionaCorso.UseVisualStyleBackColor = true;
            btnSelezionaCorso.Click += btnSelezionaCorso_Click;
            // 
            // btnElencaCorsi
            // 
            btnElencaCorsi.Location = new Point(88, 225);
            btnElencaCorsi.Name = "btnElencaCorsi";
            btnElencaCorsi.Size = new Size(208, 68);
            btnElencaCorsi.TabIndex = 2;
            btnElencaCorsi.Text = "Elenca i Corsi";
            btnElencaCorsi.UseVisualStyleBackColor = true;
            btnElencaCorsi.Click += btnElencaCorsi_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(12, 339);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(169, 32);
            btnSalva.TabIndex = 3;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // lblMenuPrincipale
            // 
            lblMenuPrincipale.AutoSize = true;
            lblMenuPrincipale.Font = new Font("Segoe UI", 36F);
            lblMenuPrincipale.Location = new Point(12, 9);
            lblMenuPrincipale.Name = "lblMenuPrincipale";
            lblMenuPrincipale.Size = new Size(369, 65);
            lblMenuPrincipale.TabIndex = 4;
            lblMenuPrincipale.Text = "Menù Principale";
            // 
            // btnCarica
            // 
            btnCarica.Location = new Point(212, 339);
            btnCarica.Name = "btnCarica";
            btnCarica.Size = new Size(169, 32);
            btnCarica.TabIndex = 5;
            btnCarica.Text = "Carica";
            btnCarica.UseVisualStyleBackColor = true;
            btnCarica.Click += btnCarica_Click;
            // 
            // sfdSerializzazione
            // 
            sfdSerializzazione.Filter = "FIle XML(*.xml)|*.xml|All Files (*.*)|*.*";
            sfdSerializzazione.FileOk += sfdSerializzazione_FileOk;
            // 
            // ofdDeserializzazione
            // 
            ofdDeserializzazione.FileOk += ofdDeserializzazione_FileOk;
            // 
            // MenuPrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 383);
            Controls.Add(btnCarica);
            Controls.Add(lblMenuPrincipale);
            Controls.Add(btnSalva);
            Controls.Add(btnElencaCorsi);
            Controls.Add(btnSelezionaCorso);
            Controls.Add(btnAggiungiCorso);
            Name = "MenuPrincipale";
            Text = "Gestore Corsi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAggiungiCorso;
        private Button btnSelezionaCorso;
        private Button btnElencaCorsi;
        private Button btnSalva;
        private Label lblMenuPrincipale;
        private Button btnCarica;
        private SaveFileDialog sfdSerializzazione;
        private OpenFileDialog ofdDeserializzazione;
    }
}