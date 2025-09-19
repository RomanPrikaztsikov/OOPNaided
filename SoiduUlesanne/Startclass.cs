using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        List<ISõiduk> sõidukid = new List<ISõiduk>();
        double koguKulu = 0;

        while (true)
        {
            Console.WriteLine("Palun valite sõiduk? 1(auto), 2(jalgrattas), 3(buss), 4(elektriratas), 5(lõpeta)");
            string valik = Console.ReadLine();

            if (valik == "5")
                break;

            if (valik == "1")
            {
                Console.WriteLine("Mis on teie kütusekulu? ");
                double kütuseKulu = Convert.ToDouble(Console.ReadLine());

                Console.Write("Mis on teie teepikkus (km)? ");
                double teepikkus = Convert.ToDouble(Console.ReadLine());

                Auto auto = new Auto(kütuseKulu, teepikkus);
                sõidukid.Add(auto);
                koguKulu += auto.ArvutaKulu();
            }

            else if (valik == "2")
            {
                Console.Write("Mis on teie teepikkus (km)? ");
                double teepikkus = Convert.ToDouble(Console.ReadLine());

                Jalgratas jalgratas = new Jalgratas(teepikkus);
                sõidukid.Add(jalgratas);
            }

            else if (valik == "3")
            {
                Console.Write("Mis on teie kütusekulu? ");
                double kütuseKulu = Convert.ToDouble(Console.ReadLine());

                Console.Write("Mis on teie teepikkus? ");
                double teepikkus = Convert.ToDouble(Console.ReadLine());

                Console.Write("Mis on teie reisiarv? ");
                int reisijateArv = Convert.ToInt32(Console.ReadLine());

                Buss buss = new Buss(kütuseKulu, teepikkus, reisijateArv);
                sõidukid.Add(buss);
                koguKulu += buss.ArvutaKulu();
            }

            else if (valik == "4")
            {
                Console.Write("Mis on teie kütusekulu kw/h? ");
                double kütusekulu = Convert.ToDouble(Console.ReadLine());

                Console.Write("Mis on teie teepikkus? ");
                double teepikkus = Convert.ToDouble(Console.ReadLine());

                Elektriratas elektriratas = new Elektriratas(kütusekulu, teepikkus);
                sõidukid.Add(elektriratas);
                koguKulu += elektriratas.ArvutaKulu();
            }

            else
            {
                Console.WriteLine("Viga! Palun sisesta 1,2,3,4,5!");
            }

            Console.WriteLine("\nSõidu tulemused:");
            foreach (var sõiduk in sõidukid)
            {
                Console.WriteLine($"Tüüp: {sõiduk.GetType().Name}");
                Console.WriteLine($"Kütusekulu: {sõiduk.ArvutaKulu()} l/100km");
                Console.WriteLine($"Teepikkus: {sõiduk.ArvutaVahemaa()} km");
            }

            Console.WriteLine($"\nKogu kulu kõigi sõidukite peale kokku: {koguKulu} l/100km");
        }
    }
}
