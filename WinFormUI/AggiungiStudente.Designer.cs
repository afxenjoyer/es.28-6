namespace WinFormUI
{
    partial class frmAggiungiStudente
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
            lblNomeStudente = new Label();
            txtNomeStudente = new TextBox();
            lblCognomeStudente = new Label();
            txtCognomeStudente = new TextBox();
            lblMatricolaStudente = new Label();
            nudMatricolaStudente = new NumericUpDown();
            btnAggiungiStudente = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMatricolaStudente).BeginInit();
            SuspendLayout();
            // 
            // lblNomeStudente
            // 
            lblNomeStudente.AutoSize = true;
            lblNomeStudente.Location = new Point(12, 9);
            lblNomeStudente.Name = "lblNomeStudente";
            lblNomeStudente.Size = new Size(93, 15);
            lblNomeStudente.TabIndex = 0;
            lblNomeStudente.Text = "Nome Studente:";
            // 
            // txtNomeStudente
            // 
            txtNomeStudente.Location = new Point(12, 27);
            txtNomeStudente.Name = "txtNomeStudente";
            txtNomeStudente.Size = new Size(217, 23);
            txtNomeStudente.TabIndex = 1;
            // 
            // lblCognomeStudente
            // 
            lblCognomeStudente.AutoSize = true;
            lblCognomeStudente.Location = new Point(12, 64);
            lblCognomeStudente.Name = "lblCognomeStudente";
            lblCognomeStudente.Size = new Size(113, 15);
            lblCognomeStudente.TabIndex = 2;
            lblCognomeStudente.Text = "Cognome Studente:";
            // 
            // txtCognomeStudente
            // 
            txtCognomeStudente.Location = new Point(12, 82);
            txtCognomeStudente.Name = "txtCognomeStudente";
            txtCognomeStudente.Size = new Size(217, 23);
            txtCognomeStudente.TabIndex = 3;
            // 
            // lblMatricolaStudente
            // 
            lblMatricolaStudente.AutoSize = true;
            lblMatricolaStudente.Location = new Point(13, 118);
            lblMatricolaStudente.Name = "lblMatricolaStudente";
            lblMatricolaStudente.Size = new Size(110, 15);
            lblMatricolaStudente.TabIndex = 4;
            lblMatricolaStudente.Text = "Matricola Studente:";
            // 
            // nudMatricolaStudente
            // 
            nudMatricolaStudente.Location = new Point(13, 136);
            nudMatricolaStudente.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMatricolaStudente.Name = "nudMatricolaStudente";
            nudMatricolaStudente.Size = new Size(216, 23);
            nudMatricolaStudente.TabIndex = 5;
            // 
            // btnAggiungiStudente
            // 
            btnAggiungiStudente.Location = new Point(51, 168);
            btnAggiungiStudente.Name = "btnAggiungiStudente";
            btnAggiungiStudente.Size = new Size(138, 23);
            btnAggiungiStudente.TabIndex = 6;
            btnAggiungiStudente.Text = "Aggiungi Studente";
            btnAggiungiStudente.UseVisualStyleBackColor = true;
            btnAggiungiStudente.Click += btnAggiungiStudente_Click;
            // 
            // frmAggiungiStudente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 203);
            Controls.Add(btnAggiungiStudente);
            Controls.Add(nudMatricolaStudente);
            Controls.Add(lblMatricolaStudente);
            Controls.Add(txtCognomeStudente);
            Controls.Add(lblCognomeStudente);
            Controls.Add(txtNomeStudente);
            Controls.Add(lblNomeStudente);
            Name = "frmAggiungiStudente";
            Text = "Aggiungi Studente";
            ((System.ComponentModel.ISupportInitialize)nudMatricolaStudente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeStudente;
        private TextBox txtNomeStudente;
        private Label lblCognomeStudente;
        private TextBox txtCognomeStudente;
        private Label lblMatricolaStudente;
        private NumericUpDown nudMatricolaStudente;
        private Button btnAggiungiStudente;
    }
}