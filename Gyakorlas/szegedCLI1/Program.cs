using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szegedCLI1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szeged> adatok = new List<Szeged>();

            FileStream fs = new FileStream("szegedCLI_adatok.csv",FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Szeged adat = new Szeged(sr.ReadLine());
                adatok.Add(adat);
            }

            sr.Close();
            fs.Close();

            Console.WriteLine($"3. feladat: Szegeden {adatok.Count} darab megálló található.");

            int darab = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].JaratTipus == "troli")
                {
                    darab++;
                }
            }
            Console.WriteLine($"4. feladat: Szegedi troli megállók száma: {darab}");

            Dictionary<string, int> jaratSzamok = new Dictionary<string, int>();
            for (int i = 0; i < adatok.Count; i++)
            {
                if(jaratSzamok.ContainsKey(adatok[i].JaratSzam))
                {
                    jaratSzamok[adatok[i].JaratSzam]++;
                }
                else
                {
                    jaratSzamok.Add(adatok[i].JaratSzam, 1);
                }
            }
            Console.WriteLine("5. feladat:");
            foreach (var jarat in jaratSzamok)
            {
                Console.WriteLine($"\tJáratszám: {jarat.Key}, megállók száma: {jarat.Value} db");
            }

            Console.WriteLine("6. feladat:");
            Console.Write("Adjon meg egy járatszámot: ");
            string szam = Console.ReadLine();
            int j = 0;
            while (j < adatok.Count && adatok[j].JaratSzam != szam)
            {
                j++;
            }
            if( j <  adatok.Count)
            {
                Console.WriteLine("7. feladat:");
                List<string> megallok = new List<string>();
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].JaratSzam == szam)
                    {
                        megallok.Add(adatok[i].JaratMegallok);
                    }
                }
                Random rnd = new Random();
                Console.WriteLine($"A {szam} járat megállóinak száma: {megallok.Count}");
                int a = rnd.Next(0,megallok.Count);
                Console.WriteLine($"A {szam} járat egyik megállója: {megallok[a]}");
            }
            else
            {
                Console.WriteLine("Nem létezik ilyen járat!");
            }
                Console.ReadKey();
        }
    }
}
