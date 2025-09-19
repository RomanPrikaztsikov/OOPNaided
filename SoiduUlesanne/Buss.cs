using System;

public class Buss : ISõiduk
{
    public double KütuseKulu { get; set; }
    public double Teepikkus { get; set; }
    public int ReisijateArv { get; set; }

    public Buss(double kütuseKulu, double teepikkus, int reisijateArv)
    {
        KütuseKulu = kütuseKulu;
        Teepikkus = teepikkus;
        ReisijateArv = reisijateArv;
    }

    public double ArvutaKulu()
    {
        return KütuseKulu / ReisijateArv;
    }

    public double ArvutaVahemaa()
    {
        return Teepikkus;
    }
}
