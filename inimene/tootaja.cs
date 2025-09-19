namespace OOPNaided.inimene;

public class Töötaja : Inimene
{
    public string Ametikoht = "Keevitaja";
    public double Tunnitasu = 15.50;
    public int Tunnid {  get; set; }

    public void Töötan()
    {
        Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
    }

    public override void Mida_teeb()
    {
        Console.WriteLine($"{Nimi} töötab ametikohal.");
    }

    public double ArvutaPalk()
    {
        return Tunnitasu * Tunnid;
    }
}
