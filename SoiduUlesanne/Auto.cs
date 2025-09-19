using System;

public class Auto : ISõiduk
{
    public double KütuseKulu { get; set; }
    public double Teepikkus { get; set; }

    public Auto(double kütuseKulu, double teepikkus)
    {
        KütuseKulu = kütuseKulu;
        Teepikkus = teepikkus;
    }

    public double ArvutaKulu()
    {
        return KütuseKulu;
    }

    public double ArvutaVahemaa()
    {
        return Teepikkus;
    }
}
