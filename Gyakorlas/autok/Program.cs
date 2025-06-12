using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az autó rendszámát:  ");
            string rendsz = Console.ReadLine();
            Console.Write("Adja meg az autó fogyasztását:  ");
            double fogy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg az autó tankjának méretét [liter]:  ");
            int liter = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az autó kmóra állását:  ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az autó életkorát [év]:  ");
            int kor = Convert.ToInt32(Console.ReadLine());


            Autok chr = new Autok(rendsz, fogy, liter, km, kor);
            chr.Kiiras();

        }
    }
}
