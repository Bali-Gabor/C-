using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace diakok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diakok> tanulok = new List<Diakok>();
            FileStream fs = new FileStream("diakok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Diakok tanulo = new Diakok(sr.ReadLine());
                tanulok.Add(tanulo);
            }

            sr.Close();
            fs.Close();

            for (int i = 0; i < tanulok.Count; i++)
            {
                Console.WriteLine($"Név: {tanulok[i].Nev}, osztály: {tanulok[i].Osztaly}");
            }

            Console.WriteLine($"Az adatbázisban {tanulok.Count} diák szerepel.");

            double diakAtlag = 0;

            for (int k = 0; k < tanulok.Count; k++)
            {
                diakAtlag += tanulok[k].Atlag;
            }
            Console.WriteLine($"A diákok átlaga: {diakAtlag / tanulok.Count}");

            Console.WriteLine("4,5-ös átlag feletti tanulók:");
            for (int l = 0; l < tanulok.Count; l++)
            {
                if (tanulok[l].Atlag > 4.5)
                {
                    Console.WriteLine($"\t{tanulok[l].Nev}");
                }
            }

            int m = 0;
            while (m < tanulok.Count && tanulok[m].Atlag != 5.0)
            {
                m++;
            }
            if (m < tanulok.Count)
            {
                Console.WriteLine("Van 5,0 átlagú diák.");
            }
            else
            {
                Console.WriteLine("Nincs 5,0 átlagú diák.");
            }

            int max = 0;
            for (int j = 1; j < tanulok.Count; j++)
            {
                if (tanulok[j].Atlag > tanulok[max].Atlag)
                {
                    max = j;
                }
            }
            Console.WriteLine($"A legjobb tanuló neve {tanulok[max].Nev}, átlaga: {tanulok[max].Atlag}");

            int min = 0;
            for (int n = 1; n < tanulok.Count; n++)
            {
                if (tanulok[n].Kor < tanulok[min].Kor)
                {
                    min = n;
                }
            }
            Console.WriteLine($"A legfiatalabb diák {tanulok[min].Nev}, {tanulok[min].Kor} éves.");

            Console.WriteLine("A 10.A osztályba járó diákok:");
            for (int o = 0; o < tanulok.Count; o++)
            {
                if (tanulok[o].Osztaly == "10.A")
                {
                    Console.WriteLine($"{tanulok[o].Id}; {tanulok[o].Nev}; {tanulok[o].Kor}; {tanulok[o].Osztaly}; {tanulok[o].Atlag}");
                }
            }

            Dictionary<string, int> osztalyok = new Dictionary<string, int>();
            for (int p = 0;  p < tanulok.Count; p++)
            {
                if (osztalyok.ContainsKey(tanulok[p].Osztaly))
                {
                    osztalyok[tanulok[p].Osztaly]++;
                }
                else
                {
                    osztalyok.Add(tanulok[p].Osztaly, 1);
                }
            }
            foreach (var adat in osztalyok)
            {
                Console.WriteLine($"{adat.Key}, {adat.Value}");
            }
        }
    }
}
