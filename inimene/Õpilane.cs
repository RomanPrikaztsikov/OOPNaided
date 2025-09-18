using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNaided.inimene
{
    public class Õpilane : Inimene
    {
        public string Rühm_Klass;
        public string Kool;
        public override void Mida_teeb()
        {
            Console.WriteLine($"{Nimi} õpib koolis.");
        }
    }
}
