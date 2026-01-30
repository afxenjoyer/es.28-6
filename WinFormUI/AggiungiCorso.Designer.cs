namespace WinFormUI
{
    partial class frmAggiungiCorso
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
            this.lblDescCorso = new System.Windows.Forms.Label();
            this.lblNumEdizione = new System.Windows.Forms.Label();
            this.txtNomeCorso = new System.Windows.Forms.TextBox();
            this.txtNumEdizione = new System.Windows.Forms.TextBox();
            this.btnAggiungiCorso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescCorso
            // 
            this.lblDescCorso.AutoSize = true;
            this.lblDescCorso.Location = new System.Drawing.Point(12, 9);
            this.lblDescCorso.Name = "lblDescCorso";
            this.lblDescCorso.Size = new System.Drawing.Size(77, 15);
            this.lblDescCorso.TabIndex = 0;
            this.lblDescCorso.Text = "Nome Corso:";
            // 
            // lblNumEdizione
            // 
            this.lblNumEdizione.AutoSize = true;
            this.lblNumEdizione.Location = new System.Drawing.Point(12, 76);
            this.lblNumEdizione.Name = "lblNumEdizione";
            this.lblNumEdizione.Size = new System.Drawing.Size(114, 15);
            this.lblNumEdizione.TabIndex = 1;
            this.lblNumEdizione.Text = "Numero di edizione:";
            // 
            // txtNomeCorso
            // 
            this.txtNomeCorso.Location = new System.Drawing.Point(12, 27);
            this.txtNomeCorso.Name = "txtNomeCorso";
            this.txtNomeCorso.Size = new System.Drawing.Size(197, 23);
            this.txtNomeCorso.TabIndex = 2;
            // 
            // txtNumEdizione
            // 
            this.txtNumEdizione.Location = new System.Drawing.Point(12, 94);
            this.txtNumEdizione.Name = "txtNumEdizione";
            this.txtNumEdizione.Size = new System.Drawing.Size(197, 23);
            this.txtNumEdizione.TabIndex = 3;
            // 
            // btnAggiungiCorso
            // 
            this.btnAggiungiCorso.Location = new System.Drawing.Point(11, 159);
            this.btnAggiungiCorso.Name = "btnAggiungiCorso";
            this.btnAggiungiCorso.Size = new System.Drawing.Size(209, 23);
            this.btnAggiungiCorso.TabIndex = 4;
            this.btnAggiungiCorso.Text = "Aggiungi nuovo corso";
            this.btnAggiungiCorso.UseVisualStyleBackColor = true;
            this.btnAggiungiCorso.Click += new System.EventHandler(this.btnAggiungiCorso_Click);
            // 
            // frmAggiungiCorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 195);
            this.Controls.Add(this.btnAggiungiCorso);
            this.Controls.Add(this.txtNumEdizione);
            this.Controls.Add(this.txtNomeCorso);
            this.Controls.Add(this.lblNumEdizione);
            this.Controls.Add(this.lblDescCorso);
            this.Name = "frmAggiungiCorso";
            this.Text = "Aggiungi Corso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDescCorso;
        private Label lblNumEdizione;
        private TextBox txtNomeCorso;
        private TextBox txtNumEdizione;
        private Button btnAggiungiCorso;
    }
}