using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat: festesCLI

            //Console.Write("Adja meg a fal szélességét [centiméter]:  ");
            //double szelesseg = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Adja meg a fal magasságát [centiméter]:  ");
            //double magassag = Convert.ToDouble(Console.ReadLine());
            //double terulet = (szelesseg * magassag) / 10000;
            //Console.WriteLine($"A festendő felület: {terulet:F2} m²");
            //double festek = terulet * 2 / 14 * 1.1;
            //festek = Math.Round(festek, 1);
            //Console.WriteLine($"A festékigény: {festek} liter");


            // 2. feladat: felvaltas

            //Console.Write("Adja meg a felváltandó Eurót:  ");
            //int euro = Convert.ToInt32(Console.ReadLine());
            //int tiz = euro / 10;
            //int ot = euro % 10 / 5;
            //int egy = euro % 5;
            //Console.WriteLine("Felváltva:");
            //Console.WriteLine($"\tTíz Euro: {tiz} db");
            //Console.WriteLine($"\tÖt Euro: {ot} db");
            //Console.WriteLine($"\tEgy Euro: {egy} db");


            // 3. feladat: kedvezmenyCLI

            //Console.Write("Adja meg a termék vételárát:  ");
            //double TermekAra = Convert.ToDouble(Console.ReadLine());
            //double kedvezmeny;

            //if (TermekAra < 5000)
            //{
            //    kedvezmeny = 0.1;
            //}
            //else if (TermekAra <= 8000)
            //{
            //    kedvezmeny = 0.15;
            //}
            //else
            //{
            //    kedvezmeny = 0.2;
            //}

            //double KedvezmenyOsszege = Math.Round(TermekAra * kedvezmeny, 0);
            //double KedvezmenyesAr = Math.Round(TermekAra - KedvezmenyOsszege, 0);
            //Console.WriteLine($"Kedvezmény mértéke:\t{kedvezmeny * 100}%\nKedvezmény összege:\t{KedvezmenyOsszege} HUF\nFizetendő összeg:\t{KedvezmenyesAr} HUF");


            // 4. feladat: homersekletCLI

            //double[] homerseklet = new double[7];
            //Random rnd = new Random();

            //for(int i = 0;i < homerseklet.Length;i++)
            //{
            //    homerseklet[i] = Math.Round(rnd.Next(15, 27) + rnd.NextDouble(), 1);
            //}

            //Console.Write("Heti hőmérséklet adatok: ");

            //for (int i = 0; i < homerseklet.Length; i++)
            //{
            //    Console.Write($"{homerseklet[i]}\t");
            //}

            //Console.WriteLine("");

            //int j = 0;

            //while (j < homerseklet.Length && homerseklet[j] <= 25)
            //{
            //    j++;
            //}

            //if (j < homerseklet.Length)
            //{
            //    Console.WriteLine("A héten volt forró nap.");
            //}
            //else
            //{
            //    Console.WriteLine("A héten nem volt forró nap.");
            //}


            // 5. feladat: kisboltCLI

            List<int> szamlak = new List<int>();

            int adat = -1;

            while (adat != 0)
            {
                Console.Write("Adja meg a számla végösszegét [Ft] (ha 0-t ír befejezi az adatfelvitelt):  ");
                adat = Convert.ToInt32(Console.ReadLine());
                if (adat != 0)
                {
                    szamlak.Add(adat);
                }
            }

            if (szamlak.Count == 0)
            {
                Console.WriteLine("Nincs felvett számla.");
            }
            else
            {
                double osszeg = 0;
                double darab = 0;

                for (int i = 0; i < szamlak.Count; i++) 
                {
                    if (szamlak[i] > 10000)
                    {
                        osszeg += szamlak[i];
                        darab++;
                    }
                }

                if (darab != 0)
                {
                    double atlag = Math.Round(osszeg / darab, 0);
                    Console.WriteLine($"A 10000 Ft-nál nagyobb végösszegű számlák átlaga: {atlag} Ft");
                }
                else
                {
                    Console.WriteLine("Nincs 10000 Ft-nál nagyobb végösszegű számla.");
                }

                    int max = 0;

                for (int j = 1; j < szamlak.Count; j++)
                {
                    if (szamlak[j] > szamlak[max])
                    {
                        max = j;
                    }
                }

                Console.WriteLine($"A legmagasabb számla értéke: {szamlak[max]} Ft");

                Console.Write("Adj meg a keresett számla végösszegét [Ft]:  ");
                int keres = Convert.ToInt32(Console.ReadLine());

                int k = 0;

                while (k < szamlak.Count && szamlak[k] != keres)
                {
                    k++;
                }

                if (k < szamlak.Count)
                {
                    Console.WriteLine($"A {keres} Ft értékű számla {k + 1}.-ként lett felvíve.");
                }
                else
                {
                    Console.WriteLine($"Nincs {keres} Ft értékű számla a rendszerben!");
                }
            }
                Console.ReadKey();
        }
    }
}
