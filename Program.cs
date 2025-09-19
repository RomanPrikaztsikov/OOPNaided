using OOPNaided.inimene;
using System;

namespace OOPNaided
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Õpilane inimene1 = new Õpilane("TAR42", "TTHK", "Kati", 28);
            inimene1.Nimi = "Juku";
            inimene1.Vanus = 12;
            inimene1.Tervita();

            Õpilane inimene2 = new Õpilane("TAR42", "TTHK", "Kati", 28);
            inimene2.Mida_teeb();


            Traktor traktor1 = new Traktor();
            traktor1.Varv = "red";
            traktor1.Number = 666;
            traktor1.Firma = "PoldsaarOU";
            traktor1.BipBop();
            traktor1.KuvaInfo();
            traktor1.Liigu();

            SportAuto sportauto1 = new SportAuto();
            sportauto1.Varv = "purple";
            sportauto1.Number = 112;
            sportauto1.Kiirus = 399;
            sportauto1.BipBop();
            sportauto1.KuvaInfo();
            sportauto1.Liigu();



            Töötaja töötaja1 = new Töötaja();
            töötaja1.Nimi = "Mati";
            töötaja1.Vanus = 37;
            töötaja1.Ametikoht = "Autojuht";
            töötaja1.Tervita();
            töötaja1.Töötan();
            töötaja1.Tunnid = 160;
            double palk = töötaja1.ArvutaPalk();


            Console.WriteLine($"Algne konto on {töötaja1.Konto.Saldo} eurot.");
            töötaja1.Konto.Saldo += palk;
            Console.WriteLine($"Pärast palka on kontol {töötaja1.Konto.Saldo} eurot.");
            töötaja1.Konto.VõtaRaha(200);
            Console.WriteLine($"Pärast sularaha võtmist on kontol {töötaja1.Konto.Saldo} eurot.");
            töötaja1.Konto.LisaRaha(600);
            Console.WriteLine($"Pärast raha lisamist on kontol {töötaja1.Konto.Saldo} eurot.");


            List<IKujund> kujundid = new List<IKujund>();

            while (true)
            {
                Console.WriteLine("\nVali kujund: 1=Ruut, 2=Ring, 3=Kolmnurk, 0=Välju");
                string valik = Console.ReadLine();

                if (valik == "0") break;

                switch (valik)
                {
                    case "1":
                        Console.Write("Sisesta küljepikkus: ");
                        double külg = double.Parse(Console.ReadLine());
                        kujundid.Add(new Ruut(külg));
                        break;

                    case "2":
                        Console.Write("Sisesta raadius: ");
                        double r = double.Parse(Console.ReadLine());
                        kujundid.Add(new Ring(r));
                        break;

                    case "3":
                        Console.Write("Sisesta kolm külge (A B C): ");
                        string[] osad = Console.ReadLine().Split();
                        double a = double.Parse(osad[0]);
                        double b = double.Parse(osad[1]);
                        double c = double.Parse(osad[2]);
                        kujundid.Add(new Kolmnurk(a, b, c));
                        break;

                    default:
                        Console.WriteLine("Tundmatu valik.");
                        break;
                }
            }

            Console.WriteLine("\n--- Kujundite tulemused ---");
            foreach (var kujund in kujundid)
            {
                Console.WriteLine($"Pindala: {kujund.ArvutaPindala():F2}, Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");
            }
        }
    }
}
