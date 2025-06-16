using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tanulok_oopalapok
{
    internal class Tanulok
    {
        private string nev;
        private double atlag;
        private int igazolt;
        private int igazolatlan;
        private bool bukott;

        public string Nev { get => nev; set => nev = value; }
        public double Atlag { get => atlag; set => atlag = value; }
        public int Igazolt { get => igazolt; set => igazolt = value; }
        public int Igazolatlan { get => igazolatlan; set => igazolatlan = value; }
        public bool Bukott { get => bukott; set => bukott = value; }


        public Tanulok(string n, double a, int igaz, int iglan, bool b)
        {
            nev = n;
            atlag = a;  
            igazolt = igaz;
            igazolatlan = iglan;
            bukott = b;
        }


        public int OsztondijSzamolas()
        {
            if (bukott || igazolatlan >= 6)
            {
                return 0;
            }
            else if (atlag >= 2 && atlag < 3)
            {
                return 8000;
            }
            else if (atlag < 4)
            {
                return 25000;
            }
            else if (atlag < 4.5)
            {
                return 42000;
            }
            else
            {
                return 59000;
            }
        }

        public int HianyzasokSzamolas()
        {
            return igazolatlan + igazolt;
        }


        public string Levelkuldes()
        {
            string szoveg = "";

            if ( igazolt >= 250 && igazolatlan >= 10)
            {
                szoveg =  $"Figyelelm! {nev} szüleinek igazolt hiányzásai {igazolt} óra és igazolatlan hiányzásai {igazolatlan} óra miatt levelet kell írni!";
            }
            else if ( igazolt >= 250 && igazolatlan < 10)
            {
                szoveg = $"Figyelelm! {nev} szüleinek igazolt hiányzásai {igazolt} óra miatt levelet kell írni!";
            }
            else if ( igazolt < 250 &&  igazolatlan >= 10)
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
            int osztondij = OsztondijSzamolas();
            Console.WriteLine($"A tanuló ösztöndíja: {osztondij} Ft");
            int hianyzas = HianyzasokSzamolas();
            Console.WriteLine($"A tanuló hiányzásainak száma: {hianyzas} óra");
            string szoveg = Levelkuldes();
            Console.WriteLine(szoveg);
        }
    }
}
