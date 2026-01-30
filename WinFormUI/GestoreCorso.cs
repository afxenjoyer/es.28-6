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
    }
}
