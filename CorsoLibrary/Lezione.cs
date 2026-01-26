using System.Text;

namespace CorsoLibrary;

public class Lezione
{
    public string Descrizione { get; set; }
    public DateTime Data { get; set; }
    public DateTime OraInizio { get; set; }
    public TimeSpan Durata { get; set; }
    public Docente DocenteAssegnato { get; set; }
    public Aula AulaAssegnata { get; set; }
    public List<Studente> StudentiPresenti { get; set; } = new List<Studente>();

    public Lezione(string desc, DateTime data, DateTime oraInizio, 
        TimeSpan durata, Docente docenteAssegnato, Aula aulaAssegnata)
    {
        Descrizione = desc;
        Data = data;
        OraInizio = oraInizio;
        Durata = durata;
        DocenteAssegnato = docenteAssegnato;
        AulaAssegnata = aulaAssegnata;
    }

    public override string ToString()
    {
        return $"{Descrizione} {Data:d} {OraInizio:t} {Durata:g} {DocenteAssegnato} {AulaAssegnata}";
    }

    public bool SegnaStudenteAssente(int matricola)
    {
        foreach (var studente in StudentiPresenti)
        {
            if (matricola == studente.Matricola)
            {
                StudentiPresenti.Remove(studente);
                return true;
            }
        }

        return false;
        // throw new Exception("La matricola inserita non corrisponde a nessuno studente nella lista");
    }

    public string ElencaStudentiPresenti()
    {
        if (StudentiPresenti.Count == 0)
        {
            return String.Empty;
        }

        StringBuilder elencoPresenti = new StringBuilder();
        for (int i = 0; i < StudentiPresenti.Count; i++)
        {
            elencoPresenti.Append($"{i + 1}|{StudentiPresenti[i].ToString()}\n");
        }
        return elencoPresenti.ToString();
    }
}