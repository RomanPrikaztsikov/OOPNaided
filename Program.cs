using OOPNaided.inimene;
using OOPNaided.inimene;

namespace OOPNaided;

public class Program
{
    public static void Main(string[] args)
    {
        Inimene inimene1 = new Inimene();
        inimene1.Nimi = "Juku";
        inimene1.Vanus = 12;
        inimene1.Tervita();

        Inimene inimene2 = new Inimene("Kati", 28);

        Töötaja töötaja1 = new Töötaja();
        töötaja1.Nimi = "Mati";
        töötaja1.Vanus = 37;
        töötaja1.Ametikoht = "Autojuht";
        töötaja1.Tervita();
        töötaja1.Töötan();

        Auto auto1 = new Auto();
        auto1.Varv = "blue";
        auto1.Number = 999;
        auto1.BipBop();

        Traktor traktor1 = new Traktor();
        traktor1.Varv = "red";
        traktor1.Number = 666;
        traktor1.Firma = "PoldsaarOU";
        traktor1.sonum();

        SportAuto sportauto1 = new SportAuto();
        sportauto1.Varv = "purple";
        sportauto1.Number = 112;
        sportauto1.Kiirus = 399;
        sportauto1.sonum();


    }
}
