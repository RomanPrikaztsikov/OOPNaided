using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNaided.Pank
{
    public interface ITööline
    {
        double ArvutaPalk();
    }


    public class Pank
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
            }
        }
        public void LisaRaha(double summa)
        {
            if (summa > 0)
                saldo += summa;
            Console.WriteLine($"Teie kontol on {saldo} eurot.");
        }
        public void VõtaRaha(double summa)
        {
            if (summa > 0 && summa <= saldo)
                saldo -= summa;
            else
                Console.WriteLine("Teie kontol pole piisavalt raha,");
            Console.WriteLine($"Teie kontol on {saldo} eurot.");
        }
    }
}
