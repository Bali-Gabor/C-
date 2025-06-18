using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolaCLI
{
    internal class Tanulok
    {
        string nev;
        double atlag;
        int igazolt;
        int igazolatlan;
        bool bukott;

        public string Nev { get => nev; set => nev = value; }
        public double Atlag { get => atlag; set => atlag = value; }
        public int Igazolt { get => igazolt; set => igazolt = value; }
        public int Igazolatlan { get => igazolatlan; set => igazolatlan = value; }
        public bool Bukott { get => bukott; set => bukott = value; }

        public Tanulok(string n, double a, int i, int iga, bool b)
        {
            nev = n;
            atlag = a;
            igazolt = i;
            igazolatlan = iga;
            bukott = b;
        }

        int OsztondijSzamolas()
        {
            int dij;
            if (bukott == true || igazolatlan >= 6)
            {
                dij = 0;
            }
            else if (atlag >= 2 && atlag <= 2.99)
            {
                dij = 8000;
            }
            else if (atlag <= 3.99)
            {
                dij = 25000;
            }
            else if (atlag <= 4.49)
            {
                dij = 42000;
            }
            else
            {
                dij = 59000;
            }
            return dij;
        }


        int HianyzasokSzamolasa()
        {
            return igazolt + igazolatlan;
        }


        string Levelkuldes()
        {
            string szoveg;
            if (igazolt >= 250 && igazolatlan >= 10)
            {
                szoveg = $"Figyelem! {nev} szüleinek igazolt hiányzásai {igazolt} óra és igazolatlan hiányzásai {igazolatlan} óra miatt levelet kell írni!";
            }
            else if (igazolt >= 250 &&  igazolatlan < 10)
            {
                szoveg = $"Figyelem! {nev} szüleinek igazolt hiányzásai {igazolt} óra miatt levelet kell írni!";
            }
            else if (igazolt <= 250 && igazolatlan >= 10)
            {
                szoveg = $"Figyelem! {nev} szüleinek igazolatlan hiányzásai {igazolatlan} óra miatt levelet kell írni!";
            }
            else
            {
                szoveg = $"Nincs teendő {nev} nevű tanuló hiányzásaival kapcsolatban!";
            }
            return szoveg;
        }


        public void Kiiras()
        {
            Console.WriteLine($"A tanuló ösztöndíja: {OsztondijSzamolas()}");
            Console.WriteLine($"A tanuló hiányzásainak száma: {HianyzasokSzamolasa()}");
            string valasz = Levelkuldes();
            Console.WriteLine(valasz);
        }
    }
}
