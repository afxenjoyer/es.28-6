namespace CorsoLibrary;

public class Aula
{
    public int Capienza { get; set; }
    public string Nome { get; set; }
    public List<string> Risorse { get; set; } = new List<string>();

    public Aula(int capienza, string nome)
    {
        Capienza = capienza;
        Nome = nome;
    }

    public override string ToString()
    {
        return $"{Nome} Capienza:{Capienza}";
    }
}