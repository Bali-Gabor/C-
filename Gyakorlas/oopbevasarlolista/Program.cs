using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopbevasarlolista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bevasarlolista> bevlista = new List<Bevasarlolista>();
            FileStream fs = new FileStream("bevasarlolista.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Bevasarlolista lista = new Bevasarlolista(sr.ReadLine());
                bevlista.Add(lista);
            }

            sr.Close();
            fs.Close();

            Console.WriteLine($"{bevlista.Count} db terméket kell vásárolni.");

            double vegosszeg = 0;
            for (int i = 0; i < bevlista.Count; i++)
            {
                vegosszeg += bevlista[i].fizetendoOsszeg();
            }
            Console.WriteLine($"Végösszeg: {vegosszeg} Ft");

            int darab = 0;
            for (int i = 0; i < bevlista.Count; i++)
            {
                darab += bevlista[i].Mennyiseg;
            }
            Console.WriteLine($"Összesen {darab} db termék");

            int max = 0;
            for (int i = 1; i < bevlista.Count; i++)
            {
                if (bevlista[i].Egysegar > bevlista[max].Egysegar)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Legdrágább termék: {bevlista[max].Termeknev}, ára: {bevlista[max].Egysegar} Ft");

            FileStream fs1 = new FileStream("fizetendo.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);

            for (int i = 0; i < bevlista.Count; i++)
            {
                sw.WriteLine($"{bevlista[i].Termeknev};{bevlista[i].fizetendoOsszeg()} Ft");
            }
            sw.WriteLine($"Végösszeg: {vegosszeg:F2} Ft");

            sw.Close();
            fs1.Close();

            List<Bevasarlolista> olcsobb = new List<Bevasarlolista> ();

            for (int i = 0; i < bevlista.Count; i++)
            {
                if (bevlista[i].Egysegar < 500)
                {
                    olcsobb.Add(bevlista[i]);
                }
            }
            Console.WriteLine($"{olcsobb.Count} db 500Ft-nál olcsóbb termék van a bevásárlólistában.");

            int min = 0;
            for (int i = 1; i < olcsobb.Count; i++)
            {
                if (olcsobb[i].Egysegar < olcsobb[min].Egysegar)
                {
                    min = i;
                }
            }
            Console.WriteLine($"A legolcsóbb termék: {olcsobb[min].Termeknev}, ára: {olcsobb[min].Egysegar} Ft");

            int j = 0;
            while (j < bevlista.Count && bevlista[j].Mennyiseg <= 10)
            {
                j++;
            }
            if (j < bevlista.Count)
            {
                Console.WriteLine(bevlista[j].Termeknev);
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék!");
            }

            Console.ReadKey();
        }
    }
}
