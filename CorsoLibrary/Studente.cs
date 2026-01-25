namespace CorsoLibrary;

public class Studente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Matricola { get; set; }

    public Studente(string nome, string cognome, int matricola)
    {
        Nome = nome;
        Cognome = cognome;
        Matricola = matricola;
    }

    public override string ToString()
    {
        return $"{Nome} {Cognome} {Matricola}";
    }
}