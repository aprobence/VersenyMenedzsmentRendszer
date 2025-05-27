namespace VersenyMenedzsmentRendszer;

internal class Verseny
{
    public string Nev { get; set; }
    public string Kategoria { get; set; }
    public int MaxIndulo { get; set; }
    public List<Versenyzo> Indulok { get; set; }
    
    public Verseny(string nev, string kategoria, int maxIndulo)
    {
        Nev = nev;
        Kategoria = kategoria;
        MaxIndulo = maxIndulo;
        Indulok = new List<Versenyzo>();
    }
    
    public void HozzaadVersenyzo(Versenyzo versenyzo)
    {
        if (Indulok.Count < MaxIndulo)
        {
            Indulok.Add(versenyzo);
        }
        else
        {
            throw new InvalidOperationException("A verseny elérte a maximális indulók számát.");
        }
    }
}