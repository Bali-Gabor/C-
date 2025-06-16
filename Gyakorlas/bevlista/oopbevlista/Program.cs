using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oopbevlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bevasarlolista> ltermekek = new List<Bevasarlolista>();
            FileStream fs = new FileStream("bevasarlolista.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Bevasarlolista b = new Bevasarlolista(sr.ReadLine());
                ltermekek.Add(b);
            }

            sr.Close();
            fs.Close();

            Console.WriteLine($"{ltermekek.Count} féle termék szerepel a bevásárlólistán.");

            double vegosszeg = 0;
            int mennyisegOsszeg = 0;
            for (int i = 0; i < ltermekek.Count; i++)
            {
                vegosszeg += ltermekek[i].fizetendoSzamitas();
                mennyisegOsszeg += ltermekek[i].Mennyiseg;
            }
            Console.WriteLine($"Végösszeg: {vegosszeg} Forint");
            Console.WriteLine($"Összesen {mennyisegOsszeg} db termék");

            int max = 0;
            for (int i = 1; i < ltermekek.Count; i++)
            {
                if (ltermekek[i].Egysegar > ltermekek[max].Egysegar)
                {
                    max = i;
                }
            }
            Console.WriteLine($"A legdrágább termék: {ltermekek[max].Nev}, ára: {ltermekek[max].Egysegar} Ft");

            fs = new FileStream("fizetendo.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for ( int i = 0; i < ltermekek.Count; i++)
            {
                sw.WriteLine($"{ltermekek[i].Nev};{ltermekek[i].fizetendoSzamitas()}");
            }
            sw.Write($"Végösszeg: {vegosszeg} Ft");
            sw.Close();
            fs.Close();

            List<Bevasarlolista> lolcsok = new List<Bevasarlolista>();
            for (int i = 0; i < ltermekek.Count; i++)
            {
                if (ltermekek[i].Egysegar < 500)
                {
                    lolcsok.Add(ltermekek[i]);
                }
            }

            Console.WriteLine($"{lolcsok.Count} db 500 forintnál olcsóbb termék van.");

            int j = 0;
            while (j < ltermekek.Count && ltermekek[j].Mennyiseg <= 10)
            {
                j++;
            }
            if (j < ltermekek.Count)
            {
                Console.WriteLine(ltermekek[j].Nev);
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék!");
            }



            Console.ReadKey();
        }
    }
}
