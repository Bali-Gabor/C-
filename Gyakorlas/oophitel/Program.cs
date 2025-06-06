using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opphitel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adja meg a felvett összeget: ");
            double osszeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a kamatot: ");
            double kamat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg az futamidőt években: ");
            int ev = Convert.ToInt32(Console.ReadLine());

            Hitel a = new Hitel(kamat, osszeg, ev);

            Console.WriteLine($"A visszafizetendő összeg: {a.visszafizetendo()} Ft");
            Console.WriteLine($"A havi törlesztőrészlet: {a.havitorleszto()} Ft");
        }
    }
}
