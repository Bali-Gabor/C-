using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diakok
{
    internal class Diakok
    {
        int id;
        string nev;
        int kor;
        string osztaly;
        double atlag;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public double Atlag { get => atlag; set => atlag = value; }


        public Diakok(string sor)
        {
            string[] adatok = sor.Split(';');
            id = Convert.ToInt32(adatok[0]);
            nev = adatok[1];
            kor = Convert.ToInt32(adatok[2]);
            osztaly = adatok[3];
            atlag = Convert.ToDouble(adatok[4]);
        }
    }
}
