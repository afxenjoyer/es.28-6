namespace CorsoLibrary;

public class Docente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string TitoloStudio { get; set; }

    public Docente() {}
    public Docente(string nome, string cognome, string titoloStudio)
    {
        Nome = nome;
        Cognome = cognome;
        TitoloStudio = titoloStudio;
    }

    public override string ToString()
    {
        return $"{Nome} {Cognome} {TitoloStudio}";
    }
}