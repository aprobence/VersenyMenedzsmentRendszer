namespace VersenyMenedzsmentRendszer;

internal class Versenyzo
{
    public string Nev { get; set; }
    public int Kor { get; set; }
    public string Nem { get; set; }
    public List<Eredmeny> Eredmenyek { get; set; }
    
    public Versenyzo(string nev, int kor, string nem)
    {
        Nev = nev;
        Kor = kor;
        Nem = nem;
        Eredmenyek = new List<Eredmeny>();
    }
}