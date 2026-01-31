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
    public partial class frmAggiungiLezione : Form
    {
        private List<Lezione> Lezioni;
        public frmAggiungiLezione(List<Lezione> listaLezioni)
        {
            InitializeComponent();
            Lezioni = listaLezioni;
        }

        private void btnAggiungiLezione_Click(object sender, EventArgs e)
        {
            var aula = new Aula((int)nudCapienzaAula.Value, txtNomeAula.Text);
            var docente = new Docente(txtNomeDocente.Text,
                txtCognomeDocente.Text, txtTitoloStudio.Text);

            var lezioneDaAggiungere = new Lezione(txtDescrizioneCorso.Text,
                dtpDataLezione.Value, dtpOrarioLezione.Value, TimeSpan.Zero, docente, aula);

            Lezioni.Add(lezioneDaAggiungere);
            this.Close();
        }
    }
}
