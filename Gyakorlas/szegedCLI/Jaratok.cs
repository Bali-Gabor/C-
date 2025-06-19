using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szegedCLI
{
    internal class Jaratok
    {
        string jaratszam;
        string vegallomasok;
        string megallonev;
        string tipus;

        public string Jaratszam { get => jaratszam; set => jaratszam = value; }
        public string Vegallomasok { get => vegallomasok; set => vegallomasok = value; }
        public string Megallonev { get => megallonev; set => megallonev = value; }
        public string Tipus { get => tipus; set => tipus = value; }


        public Jaratok(string sor)
        {
            string[] darabok = sor.Split(';');
            jaratszam = darabok[0];
            vegallomasok= darabok[1];
            megallonev= darabok[2];
            tipus = darabok[3];
        }



    }
}
