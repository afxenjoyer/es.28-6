using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorsoLibrary;

namespace WinFormUI
{
    public partial class frmGestoreCorso : Form
    {
        private Corso corso;
        public frmGestoreCorso(Corso corsoSelezionato)
        {
            InitializeComponent();
            corso = corsoSelezionato;

            this.Text = corsoSelezionato.ToString();
            lstLezioni.DataSource = corso.Lezioni;
            lstStudenti.DataSource = corso.Studenti;
        }

        private void btnAggiungiLezione_Click(object sender, EventArgs e)
        {
            var aggiungiLezione = new frmAggiungiLezione(corso.Lezioni);
            aggiungiLezione.ShowDialog();

            lstLezioni.DataSource = null;
            lstLezioni.DataSource = corso.Lezioni;
        }

        private void btnAggiungiStudente_Click(object sender, EventArgs e)
        {
            var aggiungiStudente = new frmAggiungiStudente(corso);
            aggiungiStudente.ShowDialog();

            lstStudenti.DataSource = null;
            lstStudenti.DataSource = corso.Studenti;
        }

        private void btnRimuoviLezione_Click(object sender, EventArgs e)
        {
            if (lstLezioni.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessuna lezione",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            corso.Lezioni.Remove(corso.Lezioni[lstLezioni.SelectedIndex]);
            lstLezioni.DataSource = null;
            lstLezioni.DataSource = corso.Lezioni;

            MessageBox.Show("La lezione è stata rimossa",
                "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDatiLezione_Click(object sender, EventArgs e)
        {

        }
    }
}
