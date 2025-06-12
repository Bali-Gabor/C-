using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicukaoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Macska szafika = new Macska("Szafi", 3.5, true);
            Macska picurka = new Macska("Picur", 3.8);
            szafika.kiiras();
            picurka.kiiras();

            Console.Write("Mennyit egyenek a ciciák:  ");
            double kajamennyiseg = Convert.ToDouble(Console.ReadLine());
            if (szafika.etetes(kajamennyiseg))
            {
                Console.WriteLine($"{szafika.Nev} evett.");
            }
            else
            {
                Console.WriteLine($"{szafika.Nev} nem evett.");
            }

            if (szafika.etetes(kajamennyiseg))
            {
                Console.WriteLine($"{picurka.Nev} evett.");
            }
            else
            {
                Console.WriteLine($"{picurka.Nev} nem evett.");
            }

            szafika.kiiras();
            picurka.kiiras();

            szafika.futkos();
            picurka.futkos();

            szafika.kiiras();
            picurka.kiiras();


            Console.ReadKey();
        }
    }
}
