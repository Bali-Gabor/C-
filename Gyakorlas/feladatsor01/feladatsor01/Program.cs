using System;
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

            Console.Write("Add meg a megtett út hosszát km-ben:  ");
            double ut_hossz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az utazási időt percben:  ");
            double ido = Convert.ToDouble(Console.ReadLine());
            double sebesseg = ut_hossz / (ido / 60);
            sebesseg = Math.Round(sebesseg, 2);
            Console.WriteLine($"A jármű sebessége: {sebesseg} km/h");



        }
    }
}
