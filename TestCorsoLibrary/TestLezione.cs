using CorsoLibrary;

namespace TestCorsoLibrary
{
    [TestClass]
    public class TestLezione
    {
        [TestMethod]
        public void TestSegnaStudenteAssente()
        {
            var corso = new Corso("Corso", 2);
            var docente = new Docente("Tizio", "Caio", "Laurea");
            var lezione = new Lezione
                ("Lezione", DateTime.Today, DateTime.Now, TimeSpan.FromHours(2),
                    docente, new Aula(30, "Neumann"));

            var studente = new Studente("Pierino", "Piero", 123456);
            corso.AggiungiStudente(studente.Nome, studente.Cognome, studente.Matricola);
            corso.AggiungiStudente("Pierino II", "Piero", 090909);

            corso.AggiungiLezione(lezione);

            bool segnalazioneRiuscita = lezione.SegnaStudenteAssente(090909);
            Assert.AreEqual(corso.Lezioni[0].StudentiPresenti[0].Matricola, studente.Matricola);
            Assert.AreEqual(segnalazioneRiuscita, true);
        }

        [TestMethod]
        public void TestSegnaStudenteAssenteException()
        {
            var corso = new Corso("Corso", 2);
            var docente = new Docente("Tizio", "Caio", "Laurea");
            var lezione = new Lezione
            ("Lezione", DateTime.Today, DateTime.Now, TimeSpan.FromHours(2),
                docente, new Aula(30, "Neumann"));

            corso.AggiungiStudente("Pierino", "Piero", 123456);
            corso.AggiungiLezione(lezione);

            bool segnalazioneRiuscita = lezione.SegnaStudenteAssente(090909);
            Assert.AreEqual(segnalazioneRiuscita, false);
        }
    }
}