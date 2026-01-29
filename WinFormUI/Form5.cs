using CorsoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmSelezionaCorso : Form
    {
        private List<Corso> corsiDaElencare;
        public Corso corsoSelezionato;
        public frmSelezionaCorso(List<Corso> corsi)
        {
            InitializeComponent();
            corsiDaElencare = corsi;
        }

        private void frmSelezionaCorso_Load(object sender, EventArgs e)
        {
            lstSelezioneCorso.DataSource = corsiDaElencare;
        }

        private void lstSelezioneCorso_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstSelezioneCorso.SelectedIndex != -1)
            {
                corsoSelezionato = (Corso)lstSelezioneCorso.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
