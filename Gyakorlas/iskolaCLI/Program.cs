using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolaCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a tanuló nevét: ");
            string neve = Console.ReadLine();
            Console.Write("Adja meg a tanuló átlagát: ");
            double atlaga = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg a tanuló igazolt óráinak a számat: ");
            int igazoltak = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a tanuló igazolatlan óráinak a számát: ");
            int igazolatlanok = Convert.ToInt32(Console.ReadLine());
            Console.Write("A tanuló évismétlő [Igen / Nem]? ");
            string valasz = Console.ReadLine();
            bool bukas = false;
            if (valasz == "Igen")
            {
                bukas = true;
            }
            Tanulok szemely = new Tanulok(neve, atlaga, igazoltak, igazolatlanok, bukas);
            szemely.Kiiras();
        }
    }
}
