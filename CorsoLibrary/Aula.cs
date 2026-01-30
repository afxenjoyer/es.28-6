namespace CorsoLibrary;

public class Aula
{
    public int Capienza { get; set; }
    public string Nome { get; set; }
    public string Risorse { get; set; }

    public Aula() {}
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