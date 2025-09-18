namespace OOPNaided.inimene;

public class Töötaja : Inimene
{
    public string Ametikoht = "Politseinik";

    public void Töötan()
    {
        Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
    }
}
