using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oophitel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a felvett összeget:  ");
            double osszeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a kamatot:  ");
            double kamat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a törlesztési évek számát:  ");
            int evek = Convert.ToInt32(Console.ReadLine());

            Hitel h = new Hitel(kamat, osszeg, evek);

            Console.WriteLine($"A visszafizetendő összeg: {h.visszafizetendo()} Ft");
            Console.WriteLine($"Havi törlesztőrészlet: {h.havitorleszto()} Ft");


            Console.ReadKey();
        }
    }
}
