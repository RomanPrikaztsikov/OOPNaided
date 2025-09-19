using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNaided.inimene
{
    public class SportAuto : Auto
    {
        public int Kiirus = 450;

        public override void BipBop()
        {
            Console.WriteLine("brrrr");
        }

        public override void KuvaInfo()
        {
            Console.WriteLine($"Sportauto info: varv = {Varv}, number = {Number}, kiirus = {Kiirus}");
        }

        public override void Liigu()
        {
            Console.WriteLine("Kiiresti");
        }
    }
}

