namespace VersenyMenedzsmentRendszer;

internal class Eredmeny
{
    public string VersenyNev { get; set; }
    public TimeSpan Ido { get; set; }
    public int Helyezes { get; set; }
    
    public Eredmeny(string versenyNev, TimeSpan ido, int helyezes)
    {
        VersenyNev = versenyNev;
        Ido = ido;
        Helyezes = helyezes;
    }
}