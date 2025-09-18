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

        public void sonum()
        {
            Console.WriteLine($"See on Traktor see varv on: {Varv} see number on: {Number} See Firma on: {Firma}");
        }
    }

}
