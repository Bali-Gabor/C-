
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafipax
{
    internal class Meresek
    {
        string rendszam;
        string mertsebesseg;
        int kategoria;
        int buntetes;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Mertsebesseg { get => mertsebesseg; set => mertsebesseg = value; }
        public int Kategoria { get => kategoria; set => kategoria = value; }
        public int Buntetes { get => buntetes; set => buntetes = value; }

        public Meresek(string sor)
        {
            string[] darabok = sor.Split(';');
            rendszam = darabok[0];
            mertsebesseg= darabok[1];
            kategoria = Convert.ToInt32(darabok[2]);
            buntetes = Convert.ToInt32(darabok[3]);
        }
    }
}
