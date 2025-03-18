namespace Könyvtar_kolcsonzesOOP;

internal class Konyv
{
    public string Cim { get; private set; }
    public string Szerzo { get; private set; }
    public string ISBN { get; private set; }
    public bool Kolcsonozheto  { get; private set; }
    //true: elérhető, false: nem elérhető

    public Konyv(string cim, string szerzo, string isbn)
    {
        Cim = cim;
        Szerzo = szerzo;
        ISBN = isbn;
        Kolcsonozheto = true;
    }

    public void Kolcsonzes()
    {
        Kolcsonozheto = false;
    }

    public void Visszahoz()
    {
        Kolcsonozheto= true;
    }

    public override string ToString()
    {
        return $"{Cim} - {Szerzo}(ISBN: {ISBN}) - {(Kolcsonozheto ? "Elérhető" : "Kikölcsönözve")}";
    }
}