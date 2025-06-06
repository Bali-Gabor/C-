using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace opphitel
{
    internal class Hitel
    {
        public double kamat;
        public double felvettosszeg;
        public int evekszama;
        public double kezelesikoltseg;

        public Hitel(double k, double f, int e)
        {
            kamat = k;
            felvettosszeg = f;
            kezelesikoltseg = 0.05;
            evekszama = e;
        }

        public double visszafizetendo()
        {
            double osszeg;
            osszeg = Math.Round(felvettosszeg + (felvettosszeg * kamat / 100) + (felvettosszeg * kezelesikoltseg));

            return osszeg;
        }

        public double havitorleszto()
        {
            double havi;
      
            havi = Math.Round(visszafizetendo() / (evekszama * 12));

            return havi;

        }
    }
}
