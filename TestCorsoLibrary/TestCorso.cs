using System.Xml.Serialization;
using CorsoLibrary;

namespace TestCorsoLibrary;

[TestClass]
public class TestCorso
{
    [TestMethod]
    // La funzione MatricolaPresente() deve ritornare vero, dato che lo studente è nella lista
    public void TestMatricolaPresente()
    {
        var corso = new Corso("Corso", 2);
        corso.AggiungiStudente("Tizio","Caio", 123456);
        corso.AggiungiStudente("Pierino", "Piero", 090909);

        Assert.IsTrue(corso.MatricolaPresente(123456));
    }

    [TestMethod]
    // La funzione MatricolaPresente() deve ritornare falso, perché lo studente non è nella lista
    public void TestMatricolaPresenteException()
    {
        var corso = new Corso("Corso", 2);
        corso.AggiungiStudente("Tizio", "Caio", 123456);
        corso.AggiungiStudente("Pierino", "Piero", 090909);

        Assert.IsFalse(corso.MatricolaPresente(679679));
    }

    [TestMethod]
    // La funzione AggiungiStudente() deve essere in grado di aggiungere uno studente alla lista degli studenti
    public void TestAggiungiStudente()
    {
        var corso = new Corso("Corso", 2);
        corso.AggiungiStudente("Tizio", "Caio", 123456);

        Assert.AreEqual(123456, corso.Studenti[0].Matricola);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), "Lo studente è gia nella lista degli studenti")]
    // La funzione AggiungiStudente() deve lanciare un Exception perché esiste già uno studente con quella matricola
    public void TestAggiungiStudenteException()
    {
        var corso = new Corso("Corso", 2);
        corso.Studenti.Add(new Studente("Tizio", "Caio", 123456));

        corso.AggiungiStudente("Tizio", "Caio", 123456);
    }

    [TestMethod]
    // La funzione MediaStudentiPresenti() deve ritornare 1,0
    public void TestMediaStudentiPresenti()
    {
        var corso = new Corso("Corso", 2);
        corso.AggiungiStudente("Tizio", "Caio", 123456);
        corso.AggiungiStudente("Pierino", "Piero", 090909);

        var docente = new Docente("Tizio", "Caio", "Laurea");
        var lezione = new Lezione
        ("Lezione", DateTime.Today, DateTime.Now, TimeSpan.FromHours(2),
            docente, new Aula(30, "Neumann"));

        corso.AggiungiLezione(lezione);
        float media = corso.MediaStudentiPresenti();
        Assert.AreEqual(1.0, media);
    }

    [TestMethod]
    // 
    public void TestSerializzazione()
    {
        var corso = new Corso("Corso", 2);
        corso.AggiungiStudente("Tizio", "Caio", 123456);
        corso.AggiungiStudente("Pierino", "Piero", 090909);

        var docente = new Docente("Tizio", "Caio", "Laurea");
        var lezione = new Lezione
        ("Lezione", DateTime.Today, DateTime.Now, TimeSpan.FromHours(2),
            docente, new Aula(30, "Neumann"));

        corso.AggiungiLezione(lezione);

        var serializer = new XmlSerializer(typeof(Corso));
        var writer = new StreamWriter(".\\corso.xml");

        serializer.Serialize(writer, corso);
        writer.Close();

        Assert.IsTrue(File.Exists(".\\corso.xml"));
        Assert.IsFalse(string.IsNullOrEmpty(File.ReadAllText(".\\corso.xml")));
    }

    [TestMethod]
    // Questo test deve essere eseguito dopo il test TestSerializzazione() per funzionare
    public void TestDeserializzazione()
    {
        var corso = new Corso();

        var serializer = new XmlSerializer(typeof(Corso));
        var reader = new StreamReader(".\\corso.xml");

        corso = (Corso)serializer.Deserialize(reader);
        Assert.AreEqual(2, corso.NumEdizione);
    }
}