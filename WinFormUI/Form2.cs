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
    public partial class frmAggiungiCorso : Form
    {
        public Corso outputCorso {get; set; }
        public frmAggiungiCorso()
        {
            InitializeComponent();
        }

        private void btnAggiungiCorso_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumEdizione.Text, out int numEdizione))
            {
                MessageBox.Show("Il numero di edizione non è un numero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            outputCorso = new Corso(txtNomeCorso.Text, numEdizione);
            DialogResult = DialogResult.OK;
        }
    }
}
