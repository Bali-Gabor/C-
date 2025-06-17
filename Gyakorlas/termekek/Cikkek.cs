using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termekek
{
    internal class Cikkek
    {
        private string cikkszam;
        private string megnevezes;
        private int beszerzesiar;
        private int afakulcs;
        private bool akcios;
        private int kedvezmeny;

        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public int Beszerzesiar { get => beszerzesiar; set => beszerzesiar = value; }
        public int Afakulcs { get => afakulcs; set => afakulcs = value; }
        public bool Akcios { get => akcios; set => akcios = value; }
        public int Kedvezmeny { get => kedvezmeny; set => kedvezmeny = value; }


        public Cikkek(string c, string m, int b, int a, bool ak, int k)
        {
            cikkszam = c;
            megnevezes = m;
            beszerzesiar=b;
            afakulcs=a;
            akcios = ak;
            kedvezmeny = k;
        }


        public double NettoSzamitas()
        {
            double netto_ar = beszerzesiar * 1.35;
            return Math.Round(netto_ar, 2);
        }


        public int BruttoSzamitas()
        {
            double brutto_ar = NettoSzamitas() * (100 + afakulcs) / 100;
            return Convert.ToInt32(brutto_ar);
        }


        public string AkciosUzenetIras()
        {
            if (akcios)
            {
                return $"A {cikkszam} {megnevezes} jelenleg akciós.";
            }
            else
            {
                return $"A {cikkszam} {megnevezes} jelenleg nem akciós.";
            }
        }

        public int KedvarSzamitas()
        {
            double kedvezar = BruttoSzamitas() * (100 - kedvezmeny) / 100;
            return Convert.ToInt32(kedvezar);
        }
    }
}
