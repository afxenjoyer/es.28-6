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
    public partial class frmDatiLezione : Form
    {
        private Lezione Lezione;
        public frmDatiLezione(Lezione lezione, int numStudentiCorso)
        {
            InitializeComponent();
            Lezione = lezione;

            txtDescrizione.Text = Lezione.Descrizione;
            txtData.Text = Lezione.Data.ToShortDateString();
            txtOraInizio.Text = Lezione.OraInizio.TimeOfDay.ToString("hh\\.mm\\:ss");
            txtDurata.Text = Lezione.Durata.ToString("hh\\.mm\\:ss");
            txtNomeDocente.Text = Lezione.DocenteAssegnato.Nome;
            txtCognomeDocente.Text = Lezione.DocenteAssegnato.Cognome;
            txtTitoloStudio.Text = Lezione.DocenteAssegnato.TitoloStudio;
            txtNomeAula.Text = Lezione.AulaAssegnata.Nome;
            txtCapienzaAula.Text = Lezione.AulaAssegnata.Capienza.ToString();

            txtMediaPresenti.Text = ((float)Lezione.StudentiPresenti.Count / (float)numStudentiCorso).ToString("0.00");

            lstStudentiPresenti.DataSource = Lezione.StudentiPresenti;
        }

        private void btnStudentiAssenti_Click(object sender, EventArgs e)
        {
            if (lstStudentiPresenti.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessuno studente",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lezione.StudentiPresenti.RemoveAt(lstStudentiPresenti.SelectedIndex);

            lstStudentiPresenti.DataSource = null;
            lstStudentiPresenti.DataSource = Lezione.StudentiPresenti;

            MessageBox.Show("Lo studente è stato segnato assente",
                "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
