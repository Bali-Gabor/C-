using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicukaoop
{
    internal class Macska
    {
        private string nev;
        private double suly;
        private bool ehese;

        public string Nev { get => nev; set => nev = value; }
        public double Suly { get => suly; set => suly = value; }
        public bool Ehese { get => ehese; set => ehese = value; }

        public Macska(string n, double s, bool e)
        {
            nev = n;
            suly = s;
            ehese = e;
        }

        public Macska(string n, double s)
        {
            nev = n;
            suly = s;
            ehese = true;
        }

        public bool etetes(double mennyiseg)
        {
            if (ehese)
            {
                suly += mennyiseg;
                ehese = false;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void futkos()
        {
            suly -= 0.1;
            ehese = true;
        }

        public void kiiras()
        {
            if (ehese)
            {
                Console.WriteLine($"{nev} macska, {suly} kg, éhes a cica");
            }
            else
            {
                Console.WriteLine($"{nev} macska, {suly} kg, nem éhes a cica");
            }
        }
    }
}
