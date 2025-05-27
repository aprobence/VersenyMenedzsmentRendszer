namespace VersenyMenedzsmentRendszer;

internal class Uszas : Verseny
{
    public Uszas(string nev, string kategoria, int maxIndulo) : base(nev, kategoria, maxIndulo)
    {
        
    }
    
    public string KiirUtasitas()
    {
        return "A versenyzők 50 méteres úszással kezdik a versenyt.";
    }
}