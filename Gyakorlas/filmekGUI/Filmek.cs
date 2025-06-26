using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmekGUI
{
    internal class Filmek
    {
        string filmCime;
        int bemutatasEve;
        string filmMufaja;
        string gyarto;
        int filmHossza;

        public string FilmCime { get => filmCime; set => filmCime = value; }
        public int BemutatasEve { get => bemutatasEve; set => bemutatasEve = value; }
        public string FilmMufaja { get => filmMufaja; set => filmMufaja = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
        public int FilmHossza { get => filmHossza; set => filmHossza = value; }


        public Filmek(string sor)
        {
            var adat = sor.Split(';');
            filmCime = adat[0];
            bemutatasEve = Convert.ToInt32(adat[1]);
            filmMufaja= adat[2];
            gyarto = adat[3];
            filmHossza = Convert.ToInt32(adat[4]);
        }

        public int mozifoglaltsag()
        {
            return filmHossza + 25;
        }
    }
}
