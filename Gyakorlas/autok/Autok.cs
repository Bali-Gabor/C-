using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok
{
    internal class Autok
    {
        private string rendszam;
        private double forgyasztas;
        private int tankmeret;
        private int kmora;
        private bool idosebb;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public double Forgyasztas { get => forgyasztas; set => forgyasztas = value; }
        public int Tankmeret { get => tankmeret; set => tankmeret = value; }
        public int Kmora { get => kmora; set => kmora = value; }
        public bool Idosebb { get => idosebb; set => idosebb = value; }

        public Autok(string r, double f, int t, int k, int i)
        {
            rendszam = r;
            forgyasztas = f;
            tankmeret = t;
            kmora = k;
            if (i > 5)
            {
                idosebb = true;
            }
            else
            {
                idosebb = false;
            }
        }

        public double EgyTankalMenet()
        {
            double ut = tankmeret * (100 / forgyasztas);
            return Math.Round(ut, 1);
        }

        public double TankolasKifizet()
        {
            double fizet = tankmeret * 648.5;
            return Math.Round(fizet, 0);
        }

        public double OsszTankolasSzamolas()
        {
            double tankolt = kmora / (tankmeret * (100 / forgyasztas));
            return Math.Round(tankolt, 0);
        }

        public void EladasDontes()
        {
            if (idosebb || kmora > 450000)
            {
                Console.WriteLine($"Figyelem! A {rendszam} rendszámú autót el kell adni!"); 
            }
            else
            {
                Console.WriteLine($"Nincs teendő a {rendszam} rendszámú autó eladásával Kapcsolatban!");
            }
        }

        public void Kiiras()
        {
            double teliTank = EgyTankalMenet();
            Console.WriteLine($"Teli tank benzin esetén megtehető út: {teliTank} km.");
            double fizet = TankolasKifizet();
            Console.WriteLine($"Egy teli tank üzemanyag költsége: {fizet} Ft.");
            double tele = OsszTankolasSzamolas();
            Console.WriteLine($"Az autót eddig {tele} alkalommal kellett teletankolni.");
            EladasDontes();
        }
    }
}
