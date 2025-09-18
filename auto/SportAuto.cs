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

        public void sonum()
        {
            Console.WriteLine($"See on Sportauto see varv on: {Varv} see number on: {Number} see kiirus on: {Kiirus}");
        }
    }
}
