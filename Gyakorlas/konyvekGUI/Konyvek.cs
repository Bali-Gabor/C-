using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvekGUI
{
    internal class Konyvek
    {
        string isbn;
        string konyvCime;
        int kiadasEve;
        string konyvTipusa;
        string konyvKiadoja;
        int konyvHossza;

        public string Isbn { get => isbn; set => isbn = value; }
        public string KonyvCime { get => konyvCime; set => konyvCime = value; }
        public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
        public string KonyvTipusa { get => konyvTipusa; set => konyvTipusa = value; }
        public string KonyvKiadoja { get => konyvKiadoja; set => konyvKiadoja = value; }
        public int KonyvHossza { get => konyvHossza; set => konyvHossza = value; }


        public Konyvek(string sor)
        {
            var adat = sor.Split(';');
            isbn = adat[0];
            konyvCime = adat[1];
            kiadasEve = Convert.ToInt32(adat[2]);

            switch (adat[3]){
                case "e": konyvTipusa = "e-könyv"; break;
                case "h": konyvTipusa = "hangoskönyv"; break;
                case "n": konyvTipusa = "könyv"; break;
            }
    
            konyvKiadoja = adat[4];
            konyvHossza = Convert.ToInt32(adat[5]);
        }
    }
}
