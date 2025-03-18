namespace Könyvtar_kolcsonzesOOP;

class Program
{
    static void Main(string[] args)
    {

            Konyvtar konyvtar = new Konyvtar();
            konyvtar.Konyvek = Fajlkezelo.KonyvekBetoltese();
        
            Felhasznalo felhasznalo = new Felhasznalo("Teszt Elek");
        
            Konyv ujKonyv = new Konyv("C# alapok", "Koczka", "1234567890");
            konyvtar.HozzaadKonyv(ujKonyv);
        
            konyvtar.ListazKonyveket();
        
            Konyv konyv = konyvtar.KeresKonyv("1234567890");
            if (konyv != null)
            {
                felhasznalo.Kolcsonoz(konyv);
            }
            Fajlkezelo.KonyvekMentese(konyvtar.Konyvek);
        
            konyvtar.ListazKonyveket();
        
    }
}
