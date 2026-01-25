namespace CorsoLibrary;

public class Corso
{ 
    public string Nome { get; set; } 
    public int NumEdizione { get; set; }
    public List<Lezione> Lezioni { get; set; } = new List<Lezione>();
    public List<Studente> Studenti { get; set; } = new List<Studente>();

    public Corso(string nome, int numEdizione)
    {
        Nome = nome;
        NumEdizione = numEdizione;
    }

    public override string ToString()
    {
        return $"{Nome} {NumEdizione}°Edizione";
    }

    public void AggiungiLezione(Lezione lezione)
    {
        lezione.StudentiPresenti = Studenti;
        Lezioni.Add(lezione);
    }

    public bool MatricolaPresente(int matricola)
    {
        foreach (var studente in Studenti)
        {
            if (studente.Matricola == matricola)
            {
                return true;
            }
        }

        return false;
    }

    public void AggiungiStudente(string nome, string cognome, int matricola)
    {
        if (MatricolaPresente(matricola))
        {
            throw new Exception("Lo studente è gia nella lista degli studenti");
        }
        Studenti.Add(new Studente(nome, cognome, matricola));
    }
}