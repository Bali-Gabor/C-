using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oophitel
{
    internal class Hitel
    {
        public double kamat;
        public double felvettosszeg;
        public int evekszama;
        public const double kezelesikoltseg = 0.05;

        public Hitel(double k, double f, int e)
        {
            kamat = k;
            felvettosszeg = f;  
            evekszama = e;
        }

        public double visszafizetendo()
        {
            return Math.Round(felvettosszeg + felvettosszeg * kamat / 100 + felvettosszeg * kezelesikoltseg / 100);
        }

        public double havitorleszto()
        {
            return Math.Round(visszafizetendo() / (evekszama * 12));
        }
    }
}
