﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace feladatsor01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SZEKVENCIA

            // 1)	Deviza átváltás (deviza_atvaltas)

            //Console.Write("Add meg a váltni kívánt forint mennyiségét:  ");
            //double forint = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg az Euro árfolyamát:  ");
            //double euro_arfolyam = Convert.ToDouble(Console.ReadLine());
            //double euro = forint / euro_arfolyam;
            //euro = Math.Round(euro, 2);
            //Console.WriteLine($"A megadott összeg: {euro} EUR");


            // 2)	Sebesség átváltás (sebesseg_atvaltas)

            //Console.Write("Add meg a jármű sebességét m/s -ban:  ");
            //double sebesseg = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"A jármű sebessége: {sebesseg * 3.6:F2} km/h");


            // 3)	Téglatest felszín és térfogat számítása (teglatest)

            //Console.Write("Add meg a téglatest 'a' oldalának hosszát cm-ben:  ");
            //double a_oldal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg a 'b' oldal hosszát cm-ben:  ");
            //double b_oldal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg a 'c' oldal hosszát cm-ben:  ");
            //double c_oldal = Convert.ToDouble(Console.ReadLine());
            //double terfogat = a_oldal * b_oldal * c_oldal;
            //terfogat = Math.Round(terfogat, 2);
            //double felulet = (a_oldal * b_oldal + a_oldal * c_oldal + b_oldal * c_oldal) * 2;
            //felulet = Math.Round(felulet, 2);
            //Console.WriteLine($"A téglatest\n\tfelülete: {felulet} cm2\n\ttérfogata: {terfogat} cm3");


            // 4)	Átfogó számítás (pitagorasz)

            //Console.Write("Add meg az egyik befogó hosszát cm-ben:  ");
            //double a_oldal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg a másik befogó hosszát cm-ben:  ");
            //double b_oldal = Convert.ToDouble(Console.ReadLine());
            //double atfogo = Math.Sqrt(Math.Pow(a_oldal, 2) + Math.Pow(b_oldal, 2));
            //atfogo = Math.Round(atfogo, 2);
            //Console.WriteLine($"Az átfogó hossza: {atfogo} cm");


            // 5)	Sebesség számítás (sebesseg)

            //Console.Write("Add meg a megtett út hosszát km-ben:  ");
            //double ut_hossz = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg az utazási időt percben:  ");
            //double ido = Convert.ToDouble(Console.ReadLine());
            //double sebesseg = ut_hossz / (ido / 60);
            //sebesseg = Math.Round(sebesseg, 2);
            //Console.WriteLine($"A jármű sebessége: {sebesseg} km/h");


            // 6)	Fogyasztás (fogyasztas)

            //Console.Write("Add meg a gépjármű fogyasztását liter/100 km -ben: ");
            //double fogyasztas = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg a megtett út hosszát km-ben:  ");
            //double tavolsag = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg az üzemanyag árát forintban:  ");
            //double ar = Convert.ToDouble(Console.ReadLine());
            //double fogyasztasAzUton = tavolsag / 100 * fogyasztas;
            //fogyasztasAzUton = Math.Round(fogyasztasAzUton, 2);
            //Console.WriteLine($"Az autó {fogyasztasAzUton} liter üzemanyagot fogyasztott, az üzemanyagköltség: {Math.Round(fogyasztasAzUton * ar, 0)} HUF");


            // 7)	Testtömeg index (tti)

            //Console.Write("Add meg a testtömeged kg-ban:  ");
            //double tomeg = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg a magasságod cm-ben:  ");
            //double magassag = Convert.ToDouble(Console.ReadLine());
            //double tti = tomeg / Math.Pow(magassag / 100, 2);
            //Console.WriteLine($"A testtömegindexe: {tti:F2}");


            // 8)	Gömb (gomb)

            //Console.Write("Add meg a gömb sugarát cm-ben:  ");
            //double sugar = Convert.ToDouble(Console.ReadLine());
            //double felszin = 4 * Math.PI * Math.Pow(sugar, 2);
            //double terfogat = ((4 * Math.PI) / 3) * Math.Pow(sugar, 3);
            //Console.WriteLine($"A gömb felszíne: {felszin:F2}cm2, térfogata: {terfogat:F2}cm3");


            // 9)	Ötvenév (otvenev)

            //Console.Write("Add meg a vezetékneved:  ");
            //string vezeteknev = Console.ReadLine();
            //Console.Write("Add meg a keresztneved:  ");
            //string keresztnev = Console.ReadLine();
            //Console.Write("Add meg a születési éved:  ");
            //int ev = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{vezeteknev} {keresztnev} {ev + 50}-ban leszel 50 éves.");


            // 10)	Henger (henger)

            //Console.Write("Add meg a henger alapjának sugarát cm-ben:  ");
            //double sugar = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg a henger magasságát cm-ben:  ");
            //double magassag = Convert.ToDouble(Console.ReadLine());
            //double felszin = 2 * Math.PI * sugar * (sugar + magassag);
            //double terfogat = Math.PI * Math.Pow(sugar, 2) * magassag;
            //Console.WriteLine($"A henger felszíne: {felszin:F2}cm2");
            //Console.WriteLine($"A henger térfogata: {terfogat:F2}cm3");



            // SZELEKCIÓ

            // 1)	Páros vs páratlan (pros_ptalan)

            //Console.Write("Írj be egy számot:  ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //if(szam % 2 == 0)
            //{
            //    Console.WriteLine("A szám páros.");
            //}
            //else
            //{
            //    Console.WriteLine("A szám páratlan.");
            //}


            // 2)	Pozitív vs negatív (poz_neg)

            //Console.Write("Adj meg egy számot:  ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //if (szam > 0)
            //{
            //    Console.WriteLine("A szám pozitív.");
            //}
            //else if (szam < 0)
            //{
            //    Console.WriteLine("A szám negatív.");
            //}
            //else
            //{
            //    Console.WriteLine("A szám nulla.");
            //}


            // 3)	Oszthatóság (oszthatosag)

            //Console.Write("Adj meg egy számot:  ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //if (szam % 5  == 0)
            //{
            //    Console.WriteLine($"A szám osztható 5-tel,hányadosa: {szam / 5}");
            //}
            //else
            //{
            //    Console.WriteLine("A szám nem osztható 5-tel.");
            //}


            // 4)	Nap meghatározás (nap)

            //Console.Write("Add meg, hogy a hét hányadik napja van:  ");
            //int nap = Convert.ToInt32(Console.ReadLine());
            //switch (nap)
            //{
            //    case 1: Console.WriteLine("Hétfő");
            //        break;
            //    case 2: Console.WriteLine("Kedd");
            //        break;
            //    case 3: Console.WriteLine("Szerda");
            //        break;
            //    case 4: Console.WriteLine("Csütörtök");
            //        break;
            //    case 5: Console.WriteLine("Péntek");
            //        break;
            //    case 6: Console.WriteLine("Szombat");
            //        break;
            //    case 7: Console.WriteLine("Vasárnap");
            //        break;
            //    default: Console.WriteLine("Érvénytelen szám!");
            //        break;
            //}


            // 5)	Érdemjegy1 (osztalyzat)

            //Console.Write("Add meg, hogy hány pontos a dolgozat:  ");
            //double pont = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg az elért pontoszámot:  ");
            //double pontszam = Convert.ToDouble(Console.ReadLine());
            //double szazalek = pontszam / pont * 100;
            //Console.Write("A dolgozat eredménye:  ");
            //if (szazalek <= 32)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (szazalek <= 49)
            //{
            //    Console.WriteLine("2");
            //}
            //else if (szazalek <= 69)
            //{
            //    Console.WriteLine("3");
            //}
            //else if (szazalek <= 84)
            //{
            //    Console.WriteLine("4");
            //}
            //else
            //{
            //    Console.WriteLine("5");
            //}


            // 6)	Érdemjegy2 (ertekeles)

            //Console.Write("Add meg az érdemjegyet:  ");
            //int jegy = Convert.ToInt32(Console.ReadLine());
            //switch (jegy)
            //{
            //    case 1:
            //        Console.WriteLine("elégtelen");
            //        break;
            //    case 2:
            //        Console.WriteLine("elégséges");
            //        break;
            //    case 3:
            //        Console.WriteLine("közepes");
            //        break;
            //    case 4:
            //        Console.WriteLine("jó");
            //        break;
            //    case 5:
            //        Console.WriteLine("jeles");
            //        break;
            //    default:
            //        Console.WriteLine("Hibás adat!");
            //        break;
            //}


            // 7)	Költőpénz (koltopenz)

            //Console.Write("Add meg a napi kereseted HUF-ban:  ");
            //int kereset = Convert.ToInt32(Console.ReadLine());
            //if (kereset <= 5000)
            //{
            //    Console.WriteLine($"A mai napon megtakarításra: 0 szórakozásra: {kereset} forintod van.");
            //}
            //else
            //{
            //    Console.WriteLine($"A mai napon megtakarításra: 5000 forintod, szórakozásra: {kereset - 5000} forintod van.");
            //}


            // 8)	Gyorshajtás bűntetés 2017. (buntetes)

            //Console.Write("Add meg a sebességhatárrt:  ");
            //int hatar = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Add meg a jármű sebességét:  ");
            //int sebesseg = Convert.ToInt32(Console.ReadLine());





            // 9)	Személyi szám (szemelyi_szam)

            //Console.Write("Add meg a személyi számod első számjegyét:  ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //switch (szam)
            //{
            //    case 1:
            //        Console.WriteLine("Férfi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Nő");
            //        break;
            //    case 3:
            //        Console.WriteLine("Férfi");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nő");
            //        break;
            //    default:
            //        Console.WriteLine("Hibás adat!");
            //        break;
            //}


            //10)	Kedvezmény (kedvezmeny)











            Console.ReadKey();
        }
    }
}
