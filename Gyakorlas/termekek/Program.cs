using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termekek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cikkszam : ");
            string cikk = Console.ReadLine();
            Console.Write("Megnevezés: ");
            string nev = Console.ReadLine();
            Console.Write("Beszerzési ár: ");
            int bear = Convert.ToInt32(Console.ReadLine());
            Console.Write("ÁFA kulcs: ");
            int afa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Akcios? ");
            bool akc;
            int kedv;
            if (Console.ReadLine() == "Igen")
            {
                akc = true;
                Console.Write("Kedvezmény mértéke: ");
                kedv = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                akc = false;
                kedv = 0;
            }
           
            Cikkek uj_termek = new Cikkek(cikk, nev, bear, afa, akc, kedv);

            Console.WriteLine($"Nettó ár: {uj_termek.NettoSzamitas()}");
            Console.WriteLine($"Bruttó ár: {uj_termek.BruttoSzamitas()}");
            string uzenet = uj_termek.AkciosUzenetIras();
            Console.WriteLine(uzenet);
            if (akc)
            {
                Console.WriteLine($"Kedvezményes ár: {uj_termek.KedvarSzamitas()}");
            }

        }
    }
}
