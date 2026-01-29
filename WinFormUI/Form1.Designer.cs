namespace WinFormUI
{
    partial class frmMain
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
            this.btnAggiungiCorso = new System.Windows.Forms.Button();
            this.btnSelezionaCorso = new System.Windows.Forms.Button();
            this.btnElencaCorsi = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.lblMenuPrincipale = new System.Windows.Forms.Label();
            this.btnCarica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAggiungiCorso
            // 
            this.btnAggiungiCorso.Location = new System.Drawing.Point(88, 77);
            this.btnAggiungiCorso.Name = "btnAggiungiCorso";
            this.btnAggiungiCorso.Size = new System.Drawing.Size(208, 68);
            this.btnAggiungiCorso.TabIndex = 0;
            this.btnAggiungiCorso.Text = "Aggiungi un corso";
            this.btnAggiungiCorso.UseVisualStyleBackColor = true;
            this.btnAggiungiCorso.Click += new System.EventHandler(this.btnAggiungiCorso_Click);
            // 
            // btnSelezionaCorso
            // 
            this.btnSelezionaCorso.Location = new System.Drawing.Point(88, 151);
            this.btnSelezionaCorso.Name = "btnSelezionaCorso";
            this.btnSelezionaCorso.Size = new System.Drawing.Size(208, 68);
            this.btnSelezionaCorso.TabIndex = 1;
            this.btnSelezionaCorso.Text = "Seleziona un corso";
            this.btnSelezionaCorso.UseVisualStyleBackColor = true;
            this.btnSelezionaCorso.Click += new System.EventHandler(this.btnSelezionaCorso_Click);
            // 
            // btnElencaCorsi
            // 
            this.btnElencaCorsi.Location = new System.Drawing.Point(88, 225);
            this.btnElencaCorsi.Name = "btnElencaCorsi";
            this.btnElencaCorsi.Size = new System.Drawing.Size(208, 68);
            this.btnElencaCorsi.TabIndex = 2;
            this.btnElencaCorsi.Text = "Elenca i Corsi";
            this.btnElencaCorsi.UseVisualStyleBackColor = true;
            this.btnElencaCorsi.Click += new System.EventHandler(this.btnElencaCorsi_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(12, 339);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(169, 32);
            this.btnSalva.TabIndex = 3;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblMenuPrincipale
            // 
            this.lblMenuPrincipale.AutoSize = true;
            this.lblMenuPrincipale.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipale.Location = new System.Drawing.Point(12, 9);
            this.lblMenuPrincipale.Name = "lblMenuPrincipale";
            this.lblMenuPrincipale.Size = new System.Drawing.Size(369, 65);
            this.lblMenuPrincipale.TabIndex = 4;
            this.lblMenuPrincipale.Text = "Menù Principale";
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(212, 339);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(169, 32);
            this.btnCarica.TabIndex = 5;
            this.btnCarica.Text = "Carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 383);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.lblMenuPrincipale);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnElencaCorsi);
            this.Controls.Add(this.btnSelezionaCorso);
            this.Controls.Add(this.btnAggiungiCorso);
            this.Name = "frmMain";
            this.Text = "Gestore Corsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAggiungiCorso;
        private Button btnSelezionaCorso;
        private Button btnElencaCorsi;
        private Button btnSalva;
        private Label lblMenuPrincipale;
        private Button btnCarica;
    }
}