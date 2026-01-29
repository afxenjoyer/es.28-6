using System.Xml.Serialization;
using CorsoLibrary;

namespace WinFormUI
{
    public partial class frmMain : Form
    {
        private List<Corso> corsi = new List<Corso>(); 
        public frmMain()
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
            var serializer = new XmlSerializer(typeof(List<Corso>));
            var writer = new StreamWriter(".\\corsi.xml");

            serializer.Serialize(writer, corsi);
            writer.Close();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Corso>));
            
            var reader = new StreamReader(".\\corsi.xml");
            corsi = (List<Corso>)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}