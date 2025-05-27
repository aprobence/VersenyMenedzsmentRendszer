namespace VersenyMenedzsmentRendszer;

internal class Futas : Verseny
{
    public Futas(string nev, string kategoria, int maxIndulo) : base(nev, kategoria, maxIndulo)
    {
    }

    public string KiirUtasitas()
    {
        return "A versenyzők 3 kör futással kezdik a versenyt.";
    }
}