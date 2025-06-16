using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanulok_oopalapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a tanuló nevét: ");
            string nev = Console.ReadLine();
            Console.Write("Adja meg a tanuló átlagát: ");
            double atlag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a tanuló igazolt óráinak a számát: ");
            int igazolt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a tanuló igazolatlan óráinak a számát: ");
            int igazolatlan = Convert.ToInt32(Console.ReadLine());
            Console.Write("A tanuló évismétlő? ");
            bool bukas = false;
            if (Console.ReadLine() == "Igen")
            {
                bukas = true;
            }

            Tanulok ujTanulo = new Tanulok(nev, atlag, igazolt, igazolatlan, bukas);

            ujTanulo.Kiiras();
        }
    }
}
