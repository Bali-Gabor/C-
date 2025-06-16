using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopbevlista
{
    internal class Bevasarlolista
    {
        string nev;
        double egysegar;
        int mennyiseg;

        public string Nev { get => nev; set => nev = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }


        public Bevasarlolista(string sor)
        {
            string[] darabok = sor.Split(';');
            nev = darabok[0];
            egysegar = Convert.ToDouble(darabok[1]);
            mennyiseg = Convert.ToInt32(darabok[2]);
        }

        public double fizetendoSzamitas()
        {
            return egysegar * mennyiseg;
        }
    }
}
