namespace VersenyMenedzsmentRendszer;

internal class VersenyMenet
{
    public static List<Verseny> Versenyek { get; set; }
    
    public VersenyMenet()
    {
        Versenyek = new List<Verseny>();
    }
    
    public static void VersenyHozzaadas(Verseny verseny)
    {
        Versenyek.Add(verseny);
    }
    
    public static void VersenyekListazasa()
    {
        if (Versenyek.Count == 0)
        {
            Console.WriteLine("Nincsenek versenyek.");
            return;
        }
        
        foreach (var verseny in Versenyek)
        {
            Console.WriteLine($"Verseny: {verseny.Nev}, Kategória: {verseny.Kategoria}, Max Induló: {verseny.MaxIndulo}");
            foreach (var indulok in verseny.Indulok)
            {
                Console.WriteLine($"  Versenyző: {indulok.Nev}, Kor: {indulok.Kor}, Nem: {indulok.Nem}");
            }
        }
    }

    public static void VersenyEredmenyekKiirasa()
    {
        if (Versenyek.Count == 0)
        {
            Console.WriteLine("Nincsenek versenyek.");
            return;
        }
        
        foreach (var verseny in Versenyek)
        {
            Console.WriteLine($"Eredmények a(z) {verseny.Nev} versenyen:");
            foreach (var versenyzo in verseny.Indulok)
            {
                Console.WriteLine($"  Versenyző: {versenyzo.Nev}, Eredmények:");
                foreach (var eredmeny in versenyzo.Eredmenyek)
                {
                    Console.WriteLine($"    Verseny: {eredmeny.VersenyNev}, Idő: {eredmeny.Ido}, Helyezés: {eredmeny.Helyezes}");
                }
            }
        }
    }
}