using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopbevasarlolista
{
    internal class Bevasarlolista
    {
        string termeknev;
        float egysegar;
        int mennyiseg;

        public string Termeknev { get => termeknev; set => termeknev = value; }
        public float Egysegar { get => egysegar; set => egysegar = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public Bevasarlolista(string sor)
        {
            string[] darab = sor.Split(';');
            termeknev = darab[0];
            egysegar = Convert.ToSingle(darab[1]);
            mennyiseg = Convert.ToInt32(darab[2]);
        }


        public double fizetendoOsszeg()
        {
            double osszeg = 0;

            osszeg = Egysegar * Mennyiseg;
            
            return osszeg;
        }
    }
}
