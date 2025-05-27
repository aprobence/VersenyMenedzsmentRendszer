namespace VersenyMenedzsmentRendszer;

internal class Kerekpar : Verseny
{
    public Kerekpar(string nev, string kategoria, int maxIndulo) : base(nev, kategoria, maxIndulo)
    {
        
    }
    
    public string KiirUtasitas()
    {
        return "A versenyzők 5 kör kerékpározással kezdik a versenyt.";
    }
}