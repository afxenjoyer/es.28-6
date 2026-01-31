using System.Xml.Serialization;
using CorsoLibrary;

namespace WinFormUI
{
    public partial class MenuPrincipale : Form
    {
        private List<Corso> corsi = new List<Corso>();
        public MenuPrincipale()
        {
            InitializeComponent();
        }

        private void btnAggiungiCorso_Click(object sender, EventArgs e)
        {
            var dialogAggiungi = new frmAggiungiCorso();
            dialogAggiungi.ShowDialog();

            if (dialogAggiungi.DialogResult == DialogResult.OK)
            {
                corsi.Add(dialogAggiungi.outputCorso);
                MessageBox.Show("Il corso è stato aggiunto", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelezionaCorso_Click(object sender, EventArgs e)
        {
            if (corsi.Count == 0)
            {
                MessageBox.Show("Non ci sono corsi da selezionare", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selezionaCorso = new frmSelezionaCorso(corsi);
            selezionaCorso.ShowDialog();

            if (selezionaCorso.DialogResult == DialogResult.OK)
            {
                var corsoSelezionato = selezionaCorso.corsoSelezionato;
                // Dopo dovrebbe lanciare un nuovo Form per gestire il corso selezionato (Aggiungere lezioni/studenti, ecc.)
                var gestoreCorso = new frmGestoreCorso(corsoSelezionato);
                gestoreCorso.ShowDialog();
            }
        }

        private void btnElencaCorsi_Click(object sender, EventArgs e)
        {
            if (corsi.Count == 0)
            {
                MessageBox.Show("Non ci sono corsi da elencare", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var elencoCorsi = new frmElencoCorsi(corsi);
            elencoCorsi.ShowDialog();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            sfdSerializzazione.ShowDialog();
        }

        private void sfdSerializzazione_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Corso>));
            var fileDaSerializzare = sfdSerializzazione.OpenFile();
            serializer.Serialize(fileDaSerializzare, corsi);

            fileDaSerializzare.Close();

            MessageBox.Show("I corsi sono stati salvati",
                "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            ofdDeserializzazione.ShowDialog();
        }

        private void ofdDeserializzazione_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Corso>));
            var fileDaDeserializzare = ofdDeserializzazione.OpenFile();
            corsi = (List<Corso>)serializer.Deserialize(fileDaDeserializzare);

            fileDaDeserializzare.Close();

            MessageBox.Show("I corsi sono stati caricati",
                "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}