using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace szegedCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jaratok> ljarat = new List<Jaratok>();
            FileStream fs = new FileStream("szegedCLI_adatok.csv",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Jaratok ja = new Jaratok(sr.ReadLine());
                ljarat.Add(ja);
            }
            sr.Close();
            fs.Close();

            Console.WriteLine($"3. feladat: Szegeden {ljarat.Count} db megálló található.");

            int darab = 0;

            for (int i = 0; i < ljarat.Count; i++)
            {
                if (ljarat[i].Tipus == "troli")
                {
                    darab++;
                }
            }
            Console.WriteLine($"4. feladat: Szegedi trolimegállók száma: {darab}");

            Dictionary<string, int> megalloszam = new Dictionary<string, int>();
            for (int i = 0; i < ljarat.Count; i++)
            {
                if (megalloszam.ContainsKey(ljarat[i].Jaratszam))
                {
                    megalloszam[ljarat[i].Jaratszam]++;
                }
                else
                {
                    megalloszam.Add(ljarat[i].Jaratszam, 1);
                }
            }
            Console.WriteLine("5. feladat:");
            foreach (var item in megalloszam)
            {
                Console.WriteLine($"\tJáratszám: {item.Key}, megállók száma: {item.Value} db");
            }

            Console.WriteLine("6. feladat:");
            Console.Write("\tAdjon meg egy járatszámot: ");
            string keresett = Console.ReadLine();
            int j = 0;
            while ( j < ljarat.Count && ljarat[j].Jaratszam != keresett)
            {
                j++;
            }
            if (j < ljarat.Count)
            {
                List<string> lkeresett = new List<string>();
                for ( int i = 0; i < ljarat.Count; i++)
                {
                    if (ljarat[i].Jaratszam == keresett)
                    {
                        lkeresett.Add(ljarat[i].Megallonev);
                    }
                }
                Console.WriteLine($"7. feladat:\n\t{keresett} járat megállóinak száma: {lkeresett.Count} db");
                Random rnd = new Random();
                int veletlen = rnd.Next(0, lkeresett.Count);
                Console.WriteLine($"\tMegálló neve: {lkeresett[veletlen]}");
            }
            else
            {
                Console.WriteLine("\tNem létezik ilyen járat!");
            }
                Console.ReadKey();
        }
    }
}
