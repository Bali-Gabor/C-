using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlo_fv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.feladat: Osztályzat

            //Console.Write("Add meg a dolgozat értékelésének százalékát:  ");
            //int szazalek = Convert.ToInt32(Console.ReadLine());

            //string osztalyzat = OsztalyzatVissza(szazalek);
            //Console.WriteLine(osztalyzat);


            //2.feladat: Tanulók aránya

            //Console.Write("Add meg az iskola teljes létszámát:  ");
            //double letszam = Convert.ToDouble(Console.ReadLine());

            //AranySzamitas(letszam);


            //3.feladat: Tömb

            //double[] tortek = new double[20];

            //Random rnd = new Random();

            //for (int i = 0; i < tortek.Length; i++)
            //{
            //    tortek[i] = Math.Round(rnd.Next(10, 30) + rnd.NextDouble(), 2);
            //}

            //Kiiratas(tortek);

            //int index = MinimumHely(tortek);
            //Console.WriteLine($"\n\nA tömb legkisebb elemének indexe: {index}, értéke: {tortek[index]}");

            //Console.Write("\nAdj meg egy értéket 10 és 30 között:  ");
            //double BekertSzam = Convert.ToDouble(Console.ReadLine());

            //VaneNagyobb(tortek, BekertSzam);


            //4.feladat: Lista végjelig

            //List<int> EgeszSzamok = new List<int>();

            //Feltoltes(EgeszSzamok);

            //Torles(EgeszSzamok);

            //Kiiratas(EgeszSzamok);

            //if (Vane(EgeszSzamok) == true)
            //{
            //    Console.WriteLine("Van páros szám az értékek között.");
            //}
            //else
            //{
            //    Console.WriteLine("Nincs páros szám az értékek között.");
            //}


            // 5.feladat: Tehenek

            //double[] tej = { 11.8, 13.6, 12.7, 10.9, 13.2 };

            //AtlagTejtermeles(tej);

            //Console.WriteLine($"A 12,5 liter tej alatt adó tehenek száma: {KevesTej(tej)}");
            
            //int LegkevesebbTej = MinTej(tej);
            //Console.WriteLine("A legkevesebb tejet adó tehén:");

            //switch ( LegkevesebbTej )
            //{
            //    case 0:
            //        Console.WriteLine($"\tBori\n\t{tej[LegkevesebbTej]}");
            //        break;
            //    case 1:
            //        Console.WriteLine($"\tRozi\n\t{tej[LegkevesebbTej]}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"\tRiska\n\t{tej[LegkevesebbTej]}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"\tMilka\n\t{tej[LegkevesebbTej]}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"\tAranyhaj\n\t{tej[LegkevesebbTej]}");
            //        break;
            //}

            //if (VaneTobb(tej))
            //{
            //    Console.WriteLine("Van 15 liternél több tejet adó tehén.");
            //}
            //else
            //{
            //    Console.WriteLine("Nincs 15 liternél több tejet adó tehén.");
            //}


            // 6.feladat: TéglatestLista

            List<int> oldalak = new List<int>();

            AdatBeolvasas(oldalak);

            Console.WriteLine($"A téglatest térfogata: {TerfogatSzamitas(oldalak)} cm3");

            Console.WriteLine($"A legnagyobb oldal területe: {LegnagyobbOldalTerulete(oldalak)} cm2");


        }

        static string OsztalyzatVissza(int szam)
        {
            if (szam >= 0 && szam <= 32)
            {
                return "1-es Elégtelen";
            }
            else if (szam <= 49)
            {
                return "2-es Elégséges";
            }
            else if (szam <= 69)
            {
                return "3-as Közepes";
            }
            else if (szam <= 84)
            {
                return "4-es Jó";
            }
            else if (szam <= 100)
            {
                return "5-ös Jeles";
            }
            else
            {
                return "Hibás adat!";
            }
        
        }

        static void AranySzamitas(double szam)
        {
            Random rnd = new Random();
            double alsos = 0;
            double felsos = 0;

            for (int i = 0; i < szam; i++)
            {
                int veletlen = rnd.Next(1, 5);

                if (veletlen == 1 || veletlen == 2)
                {
                    alsos++;
                }
                else
                {
                    felsos++;
                }
            }

            Console.WriteLine($"Az iskolába {alsos} alsó tagozatos gyerek jár.\n");
            Console.WriteLine($"A felsősök létszáma: {felsos} fő.\n");
            double szazalek = Math.Round(alsos / szam * 100, 1);
            Console.WriteLine($"Az iskola {szazalek}%-a alsó tagozatos.\n");
        }

        static void Kiiratas(double[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]}\t");
            }
        }


        static int MinimumHely(double[] tomb)
        {
            int min = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < tomb[min])
                {
                    min = i;
                }
            }

            return min;
        }

        static void VaneNagyobb(double[] tomb, double ertek)
        {
            bool van = false;
            int i = 0;

            while (i < tomb.Length && tomb[i] <= ertek)
            {
                i++;
            }

            if (i < tomb.Length)
            {
                van = true;
            }

            if (van == true)
            {
                Console.WriteLine($"\nVan a {ertek} értéknél nagyobb szám a tömbben.");
            }
            else
            {
                Console.WriteLine($"\nNincs a {ertek} értéknél nagyobb szám a tömben.");
            }

        }

        static void Feltoltes(List<int> lista)
        {
            bool van = true;

            while (van == true)
            {
                Console.Write("Írj be egy egész számot, ha [x] -et ütsz, befejeződik az adatbevitel:  ");
                string adat = Console.ReadLine();
                if (adat == "x")
                {
                    van = false;
                }
                else
                {
                    lista.Add(Convert.ToInt32(adat));
                }
            }
        }


        static void Torles(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 10 && lista[i] < 30)
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }
        }

        static void Kiiratas(List<int> lista)
        {
            Console.WriteLine($"A lista elemszáma: {lista.Count}");
            Console.Write($"A lista elemei: ");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]}  "); 
                
            }
            Console.WriteLine();
        }

        static bool Vane(List<int> lista)
        {
            bool van = false;
            int i = 0;

            while (i < lista.Count && lista[i] % 2 == 1)
            {
                i++;
            }

            if (i < lista.Count)
            {
                van = true;
            }

            return van;
        }

        static void AtlagTejtermeles(double[] tomb)
        {
            double osszeg = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }

            double atlag = osszeg / tomb.Length;
            Console.WriteLine($"Az átlag tejtermelés: {atlag:F1} liter");
        }

        static int KevesTej( double[] tomb)
        {
            int darab = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 12.5)
                {
                    darab++;
                }
            }
            return darab;
        }

        static int MinTej( double[] tomb)
        {
            int min = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < tomb[min])
                {
                    min = i;
                }
            }
            return min;
        }

        static bool VaneTobb( double[] tomb)
        {
            bool van = false;
            int i = 0;

            while (i < tomb.Length && tomb[i] < 15)
            {
                i++;
            }

            if (i < tomb.Length)
            {
                van = true;
            }

            return van;
        }


        static void AdatBeolvasas(List<int> lista)
        {
            for (int i = 0; i < 3; i++)
            { 
                switch (lista.Count)
                {
                    case 0: 
                        Console.Write("Adja meg az 'a' oldal hosszát: ");
                        lista.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 1:
                        Console.Write("Adja meg a 'b' oldal hosszát: ");
                        lista.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Adja meg a 'c' oldal hosszát: ");
                        lista.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                }
            }
        }


        static int TerfogatSzamitas(List<int> lista)
        {
            int v = 1;

            for (int i = 0; i < lista.Count; i++)
            {
                v =  v * lista[i];
            }

            return v;
        }

        static int LegnagyobbOldalTerulete(List<int> lista)
        {
            List<int> masolat = new List<int>(lista);
            masolat.Sort();

            return masolat[1] * masolat[2];
        } 
    }
}
