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
        private Corso Corso;
        public frmGestoreCorso(Corso corsoSelezionato)
        {
            InitializeComponent();
            Corso = corsoSelezionato;

            this.Text = corsoSelezionato.ToString();
            lstLezioni.DataSource = Corso.Lezioni;
            lstStudenti.DataSource = Corso.Studenti;
        }

        private void btnAggiungiLezione_Click(object sender, EventArgs e)
        {
            var aggiungiLezione = new frmAggiungiLezione(Corso.Lezioni);
            aggiungiLezione.ShowDialog();

            lstLezioni.DataSource = null;
            lstLezioni.DataSource = Corso.Lezioni;
        }

        private void btnAggiungiStudente_Click(object sender, EventArgs e)
        {
            var aggiungiStudente = new frmAggiungiStudente(Corso);
            aggiungiStudente.ShowDialog();

            lstStudenti.DataSource = null;
            lstStudenti.DataSource = Corso.Studenti;
        }

        private void btnRimuoviLezione_Click(object sender, EventArgs e)
        {
            if (lstLezioni.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessuna lezione",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Corso.Lezioni.Remove(Corso.Lezioni[lstLezioni.SelectedIndex]);
            lstLezioni.DataSource = null;
            lstLezioni.DataSource = Corso.Lezioni;

            MessageBox.Show("La lezione è stata rimossa",
                "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDatiLezione_Click(object sender, EventArgs e)
        {
            if (lstLezioni.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessuna lezione",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var datiLezione = new frmDatiLezione(Corso.Lezioni[lstLezioni.SelectedIndex], Corso.Studenti.Count);
            datiLezione.ShowDialog();
        }

        private void btnMediaPresentiCorso_Click(object sender, EventArgs e)
        {
            if (Corso.Lezioni.Count == 0)
            {
                MessageBox.Show("Non ci sono lezioni nel corso",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Corso.Studenti.Count == 0)
            {
                MessageBox.Show("Non ci sono Studenti nel corso",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show
                ($"La media degli studenti presenti del corso è {Corso.MediaStudentiPresenti():0.00}",
                    "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
