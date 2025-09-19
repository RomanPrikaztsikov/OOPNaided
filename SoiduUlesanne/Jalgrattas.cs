using System;

public class Jalgratas : ISõiduk
{
    public double Teepikkus { get; set; }

    public Jalgratas(double teepikkus)
    {
        Teepikkus = teepikkus;
    }

    public double ArvutaKulu()
    {
        return 0;
    }

    public double ArvutaVahemaa()
    {
        return Teepikkus;
    }
}
