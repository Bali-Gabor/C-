using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Write("Sziasztok!");
            //Console.WriteLine(" Tanulók!");

            //Console.Write("Add meg a neved: ");
            //string nev = Console.ReadLine();
            //Console.WriteLine($"Hello {nev}!");

            //int a = 21;
            //int b = 5;
            //int osszeg = a + b;
            //Console.WriteLine($"A két szám összege: {osszeg}");

            //double hanyados = Convert.ToDouble(a) / b;
            //Console.WriteLine($"A két szám hányadosa: {hanyados}");

            // 1. feladat Szekvencia

            //Console.Write("Add meg az átváltandó forint mennyiségét: ");
            //double forint = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Add meg az Euró árfolyamát: ");
            //double euro_arfolyam =Convert.ToDouble(Console.ReadLine());
            //double euro = (forint / euro_arfolyam);
            //euro = Math.Round(euro,2);
            //Console.WriteLine($"Az érték Euróban: {euro}");

            // 2. feladat Szelekció

            //Console.Write("Adj meg egy számot: ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //if (szam == 0)
            //{
            //    Console.WriteLine("A szám Nulla.");
            //}
            //else if (szam % 2 == 0)
            //{
            //    Console.Write("A szám páros.");
            //}
            //else
            //{
            //    Console.Write("A szám páratlan.");
            //}

            // 3. feladat

            //Console.Write("Add meg a személyi számod első számjegyét: ");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //if (szam == 1 || szam == 3)
            //{
            //    Console.WriteLine("Férfi");
            //}
            //else if (szam == 2 || szam == 4)
            //{
            //    Console.WriteLine("Nő");
            //}
            //else
            //{
            //    Console.WriteLine("Hibás adat!");
            //}

            // 4. feladat

            Console.Write("Add meg a személyi számod első számjegyét: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            switch(szam)
            {
                case 1: 
                    Console.WriteLine("Férfi");
                    break;
                case 2:
                    Console.WriteLine("Nő");
                    break;
                case 3:
                    Console.WriteLine("Férfi");
                    break;
                case 4:
                    Console.WriteLine("Nő");
                    break;
                default:
                    Console.WriteLine("Hibás adat!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
