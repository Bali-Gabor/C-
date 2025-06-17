using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szegedCLI1
{
    internal class Szeged
    {
        string jaratSzam;
        string jaratVegallomasok;
        string jaratMegallok;
        string jaratTipus;

        public string JaratSzam { get => jaratSzam; set => jaratSzam = value; }
        public string JaratVegallomasok { get => jaratVegallomasok; set => jaratVegallomasok = value; }
        public string JaratMegallok { get => jaratMegallok; set => jaratMegallok = value; }
        public string JaratTipus { get => jaratTipus; set => jaratTipus = value; }

        public Szeged(string sor)
        {
            string[] darabok = sor.Split(';');
            jaratSzam = darabok[0];
            jaratVegallomasok = darabok[1];
            jaratMegallok = darabok[2];
            jaratTipus = darabok[3];
        }
    }
}
