namespace VersenyMenedzsmentRendszer;

class Program
{
    static void Main(string[] args)
    {
        {
            VersenyMenet rendszer = new VersenyMenet();

            // Például hozzunk létre versenyeket
            VersenyMenet.VersenyHozzaadas(new Futas("Futás", "futás", 3));
            VersenyMenet.VersenyHozzaadas(new Uszas("Úszás", "úszás", 2));
            VersenyMenet.VersenyHozzaadas(new Kerekpar("Kerékpározás", "kerékpár", 4));

            // Versenyzők létrehozása
            Versenyzo v1 = new Versenyzo("Kiss Anna", 20, "nő");
            Versenyzo v2 = new Versenyzo("Nagy Péter", 25, "férfi");
            Versenyzo v3 = new Versenyzo("Szabó László", 30, "férfi");
            Versenyzo v4 = new Versenyzo("Tóth Eszter", 22, "nő");
            Versenyzo v5 = new Versenyzo("Kovács Gábor", 28, "férfi"); 
            Versenyzo v6 = new Versenyzo("Molnár Júlia", 19, "nő");

            // Eredmények hozzáadása
            v1.Eredmenyek.Add(new Eredmeny("Futás", TimeSpan.FromMinutes(15), 1));
            v2.Eredmenyek.Add(new Eredmeny("Futás", TimeSpan.FromMinutes(17), 2));
            v3.Eredmenyek.Add(new Eredmeny("Úszás", TimeSpan.FromMinutes(18), 2));
            v4.Eredmenyek.Add(new Eredmeny("Úszás", TimeSpan.FromMinutes(14), 1));
            v5.Eredmenyek.Add(new Eredmeny("Kerékpározás", TimeSpan.FromMinutes(30), 1));
            v6.Eredmenyek.Add(new Eredmeny("Kerékpározás", TimeSpan.FromMinutes(32), 2));

            // Versenyzők hozzáadása a versenyhez
            VersenyMenet.Versenyek[0].HozzaadVersenyzo(v1);
            VersenyMenet.Versenyek[0].HozzaadVersenyzo(v2);
            VersenyMenet.Versenyek[1].HozzaadVersenyzo(v3);
            VersenyMenet.Versenyek[1].HozzaadVersenyzo(v4);
            VersenyMenet.Versenyek[2].HozzaadVersenyzo(v5);
            VersenyMenet.Versenyek[2].HozzaadVersenyzo(v6);

            // Tesztelés
            VersenyMenet.VersenyekListazasa();
            VersenyMenet.VersenyEredmenyekKiirasa();
        }
    }
}