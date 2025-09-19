using OOPNaided.Pank;

public abstract class Inimene
{
    public string Nimi;
    public int Vanus;
    public Pank Konto {  get; set; } 

    public Inimene()
    {
        Konto = new Pank();
    }

    public Inimene(string nimi, int vanus)
    {
        Nimi = nimi;
        Vanus = vanus;
        Konto = new Pank();
    }

    public void Tervita()
    {
        Console.WriteLine("Tere! Mina olen " + Nimi);
    }

    public abstract void Mida_teeb();
}

