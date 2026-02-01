using System.Text;

namespace CorsoLibrary;

public class Corso
{ 
    public string Nome { get; set; } 
    public int NumEdizione { get; set; }
    public List<Lezione> Lezioni { get; set; } = new List<Lezione>();
    public List<Studente> Studenti { get; set; } = new List<Studente>();

    public Corso(){}
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
        lezione.StudentiPresenti.AddRange(Studenti);
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
        if (matricola < 0)
        {
            throw new Exception("La matricola non può essere un numero negativo");
        }
        var studenteDaAggiungere = new Studente(nome, cognome, matricola);

        foreach (var lezione in Lezioni)
        {
            lezione.StudentiPresenti.Add(studenteDaAggiungere);
        }
        Studenti.Add(studenteDaAggiungere);
    }

    public string ElencaLezioniCorso()
    {
        if (Lezioni.Count == 0)
        {
            return String.Empty;
        }

        StringBuilder elencoLezioni = new StringBuilder();
        for (int i = 0; i < Lezioni.Count; i++)
        {
            elencoLezioni.Append($"{i + 1}|{Lezioni[i]}");
        }

        return elencoLezioni.ToString();
    }

    public float MediaStudentiPresenti()
    {
        float somma = 0;
        foreach (var lezione in Lezioni)
        {
            somma += lezione.StudentiPresenti.Count;
        }

        return somma / Studenti.Count;
    }
}