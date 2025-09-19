public class Elektriratas : ISõiduk
{
    private double akuKulu; // kWh/100km
    private double teepikkus;

    public Elektriratas(double akuKulu, double teepikkus)
    {
        this.akuKulu = akuKulu;
        this.teepikkus = teepikkus;
    }

    public double ArvutaKulu()
    {
        return akuKulu;
    }

    public double ArvutaVahemaa()
    {
        return teepikkus;
    }

    public override string ToString()
    {
        return $"Elektriratas, kulu: {ArvutaKulu()}, Teepikkus: {ArvutaVahemaa()} km";
    }
}