namespace Könyvtar_kolcsonzesOOP;

internal class Felhasznalo
{
    public string Nev { get; private set; }
    public List<Konyv> KolcsonzesLista { get; private set; }

    public Felhasznalo(string nev)
    {
        Nev = nev;
        KolcsonzesLista = new List<Konyv>();
    }

    public void Kolcsonoz(Konyv konyv)
    {
        if (!konyv.Kolcsonozheto)
        {
            Console.WriteLine("A könyv jelenleg nem elérhető");
        }

        if (KolcsonzesLista.Count >= 3)
        {
            Console.WriteLine("Maximum 3 könyvet kölcsönözhetsz egyszerre");
        }

        KolcsonzesLista.Add(konyv);
        konyv.Kolcsonzes();
        Console.WriteLine($"{Nev} kikölcsönözte a könyvet: {konyv.Cim}");
    }

    public void Visszabisz(Konyv konyv)
    {
        if (KolcsonzesLista.Contains(konyv))
        {
            KolcsonzesLista.Remove(konyv);
            konyv.Visszahoz();
            Console.WriteLine($"{Nev} sikeresen visszahozta:{konyv.Cim} ");
        }
        else
        {
            Console.WriteLine("Ez a könyv nem szerepel a kölcsönzés listában");
        }
    }

    public override string ToString()
    {
        return $"{Nev} - Kölcsönzött könyvek: {KolcsonzesLista.Count}";
    }
}

