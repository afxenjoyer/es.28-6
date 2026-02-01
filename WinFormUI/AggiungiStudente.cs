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
    public partial class frmAggiungiStudente : Form
    {
        private Corso Corso;
        public frmAggiungiStudente(Corso corso)
        {
            InitializeComponent();
            Corso = corso;
        }

        private void btnAggiungiStudente_Click(object sender, EventArgs e)
        {
            try
            {
                Corso.AggiungiStudente(txtNomeStudente.Text,
                    txtCognomeStudente.Text, (int)nudMatricolaStudente.Value);

                this.Close();
                MessageBox.Show("La lezione è stata aggiunta",
                    "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
