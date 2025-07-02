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

namespace konyvekGUI
{
    public partial class Form1 : Form
    {
        List<Konyvek> konyveklista = new List<Konyvek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("konyvekGUI_adatok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            double atlag = 0;

            while (!sr.EndOfStream)
            {
                Konyvek a = new Konyvek (sr.ReadLine());
                konyveklista.Add (a);

                richTextBox1.Text += $"{a.Isbn}, {a.KonyvCime} ({a.KiadasEve}): {a.KonyvTipusa}\n";

                atlag += a.KonyvHossza;
            }

            fs.Close();
            sr.Close();
            
            label3.Text = $"A könyvek átlag hossza: {Math.Round(atlag / konyveklista.Count, 0)}";
            label3.Visible = true;

            int min = 0;

            for (int i = 1;  i < konyveklista.Count; i++)
            {
                if (konyveklista[i].KiadasEve < konyveklista[min].KiadasEve)
                {
                    min = i;
                }
            }

            textBox1.Text = konyveklista[min].KonyvCime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("hangoskonyvek.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < konyveklista.Count; ++i)
            {
                if (konyveklista[i].KonyvTipusa == "hangoskönyv")
                {
                    sw.WriteLine($"{konyveklista[i].Isbn};{konyveklista[i].KonyvCime};{konyveklista[i].KonyvKiadoja};{konyveklista[i].KiadasEve}");
                }
            }

            sw.Close();
            fs.Close();

            MessageBox.Show("hangoskonyvek.csv létrehozva!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int darab = 0;

            for (int i = 0; i < konyveklista.Count; i++)
            {
                if (konyveklista[i].KonyvTipusa == "e-könyv")
                {
                    darab++;
                }
            }

            MessageBox.Show($"{darab} db e-könyv van", "e-könyvek száma", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
