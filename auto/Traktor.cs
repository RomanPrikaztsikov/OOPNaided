using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNaided.inimene
{
    public class Traktor : Auto
    {
        public string Firma = "PrikaztsikovOU";

        public override void BipBop()
        {
            Console.WriteLine("trrrrrrr");
        }

        public override void KuvaInfo()
        {
            Console.WriteLine($"Traktori info: varv = {Varv}, number = {Number}, firma = {Firma}");
        }

        public override void Liigu()
        {
            Console.WriteLine("Aeglaselt");
        }
    }
}

