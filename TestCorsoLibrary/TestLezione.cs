using CorsoLibrary;

namespace TestCorsoLibrary
{
    [TestClass]
    public class TestLezione
    {
        [TestMethod]
        public void TestSegnaStudenteAssente()
        {
            var docente = new Docente("Tizio", "Caio", "Laurea");
            var lezione = new Lezione
                ("Lezione", DateTime.Today, DateTime.Now, TimeSpan.FromHours(2),
                    docente, new Aula(30, "Neumann"));

            var studente1 = new Studente("Pierino", "Piero", 123456);
            var studente2 = new Studente("Pierino II", "Piero", 090909);
            var studente3 = new Studente("Pierino III", "Piero", 679679);

            lezione.StudentiPresenti.Add(studente1);
            lezione.StudentiPresenti.Add(studente2);
            lezione.StudentiPresenti.Add(studente3);

            bool segnalazioneRiuscita = lezione.SegnaStudenteAssente(090909);
            Assert.IsTrue(lezione.StudentiPresenti[0] == studente1 && lezione.StudentiPresenti[1] == studente3 
                                                                   && segnalazioneRiuscita == true);
        }

        [TestMethod]
        public void TestSegnaStudenteAssenteException()
        {
            var docente = new Docente("Tizio", "Caio", "Laurea");
            var lezione = new Lezione
            ("Lezione", DateTime.Today, DateTime.Now, TimeSpan.FromHours(2),
                docente, new Aula(30, "Neumann"));

            var studente1 = new Studente("Pierino", "Piero", 123456);
            lezione.StudentiPresenti.Add(studente1);

            bool segnalazioneRiuscita = lezione.SegnaStudenteAssente(090909);
            Assert.IsFalse(segnalazioneRiuscita);
        }
    }
}