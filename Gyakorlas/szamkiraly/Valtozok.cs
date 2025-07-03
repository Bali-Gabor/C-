using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkiraly
{
    internal class Valtozok
    {
        bool on;

        bool[] muvelet = {false, false, false, false};
        string muveletijel;

        string jatekos1;
        string jatekos2;

        int szam1;
        int szam2;
        int eredmeny;

        int visszaszamlalas;

        int pont1;
        int pont2;
        bool megfejtes;

        public bool[] Muvelet { get => muvelet; set => muvelet = value; }
        public string Muveletijel { get => muveletijel; set => muveletijel = value; }
        public string Jatekos1 { get => jatekos1; set => jatekos1 = value; }
        public string Jatekos2 { get => jatekos2; set => jatekos2 = value; }
        public int Szam1 { get => szam1; set => szam1 = value; }
        public int Szam2 { get => szam2; set => szam2 = value; }
        public int Eredmeny { get => eredmeny; set => eredmeny = value; }
        public int Visszaszamlalas { get => visszaszamlalas; set => visszaszamlalas = value; }
        public int Pont1 { get => pont1; set => pont1 = value; }
        public int Pont2 { get => pont2; set => pont2 = value; }
        public bool Megfejtes { get => megfejtes; set => megfejtes = value; }
        public bool On { get => on; set => on = value; }
    }
}
