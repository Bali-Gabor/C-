using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmekGUI
{
    public partial class Form1 : Form
    {
        List<Filmek> filmekLista = new List<Filmek>();

        void betoltes()
        {
            FileStream fs = new FileStream("filmekGUI_adatok.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            double atlag = 0;

            while (!sr.EndOfStream)
            {
                Filmek a = new Filmek (sr.ReadLine());
                filmekLista.Add (a);

                richTextBox1.Text = richTextBox1.Text + $"\n {a.FilmCime} ({a.BemutatasEve}): {a.FilmMufaja}, mozifoglaltság: {a.mozifoglaltsag()} perc";

                atlag += a.FilmHossza;
            }

            label2.Text = $"Filmek átlagos hossza: {Math.Round(atlag / filmekLista.Count, 0)} perc";

            int min = 0;
            for (int i = 1; i < filmekLista.Count; i++)
            {
                if (filmekLista[i].BemutatasEve < filmekLista[min].BemutatasEve)
                {
                    min = i;
                }
            }

            label3.Text = $"A legrégebben készült film: {filmekLista[min].FilmCime} ({filmekLista[min].BemutatasEve})";

            sr.Close();
            fs.Close();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = 0;

            for (int i = 1; i < filmekLista.Count; i++)
            {
                if (filmekLista[i].FilmHossza < filmekLista[min].FilmHossza)
                {
                    min = i;
                }
            }

            MessageBox.Show($"{filmekLista[min].FilmCime}, hossza: {filmekLista[min].FilmHossza} perc, gyártója: {filmekLista[min].Gyarto}", "Legrövidebb film", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("sci_fi.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < filmekLista.Count; i++)
            {
                if (filmekLista[i].FilmMufaja == "sci-fi")
                {
                    sw.WriteLine($"{filmekLista[i].FilmCime};{filmekLista[i].BemutatasEve};{filmekLista[i].Gyarto}");
                }
            }

            MessageBox.Show("sci_fi.csv fájl létrehozva!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sw.Close();
            fs.Close();
        }
    }
}
