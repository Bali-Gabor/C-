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

namespace trafipax
{
    public partial class FormRogzites : Form
    {
        int kategoria;
        int buntetesOsszeg;
        int mertSebesseg;

        public void nevadas(string nev)
        {
            label4.Text = nev;
        }

        void szamitas()
        {
            kategoria = 0;
            buntetesOsszeg = 0;

            if (textBoxMertSebesseg.TextLength > 0)
            {
                mertSebesseg = Convert.ToInt32(textBoxMertSebesseg.Text);
                if (mertSebesseg > 100 && mertSebesseg < 120)
                {
                    kategoria = 1;
                    buntetesOsszeg = 0;
                }
                else if (mertSebesseg >= 120 && mertSebesseg < 135)
                {
                    kategoria = 2;
                    buntetesOsszeg = 39000;
                }
                else if (mertSebesseg >= 135 && mertSebesseg < 150)
                {
                    kategoria = 3;
                    buntetesOsszeg = 58500;
                }
                else if (mertSebesseg >= 150 && mertSebesseg < 165)
                {
                    kategoria = 4;
                    buntetesOsszeg = 78000;
                }
                else if (mertSebesseg >= 165 && mertSebesseg <= 180)
                {
                    kategoria = 5;
                    buntetesOsszeg = 117000;
                }

                labelKategória.Text = $"Büntetési kategória: {kategoria}. kategória";
                if (kategoria == 0)
                {
                    labelKategória.Text = "Büntetési kategória: Nincs gyorshajtás.";
                }

                labelOsszeg.Text = $"Büntetés összege: {buntetesOsszeg} Forint";
            }
        }
        public FormRogzites()
        {
            InitializeComponent();
        }

        private void textBoxMertSebesseg_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMertSebesseg.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(textBoxMertSebesseg.Text);
                    if (szam > 180)
                    {
                        MessageBox.Show("Mért sebesség nem lehet 180 km/h-nál nagyobb!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxMertSebesseg.Clear();
                        textBoxMertSebesseg.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Mért sebességnek számot adjon meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMertSebesseg.Clear();
                    textBoxMertSebesseg.Focus();
                    labelKategória.Text = $"Büntetési kategória: {kategoria}. kategória";
                    labelOsszeg.Text = $"Büntetés összege: 0 Forint";
                }

                szamitas();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = MessageBox.Show("Biztos elveti?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (uzenet == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxRendszam.TextLength == 0)
            {
                MessageBox.Show("Adja meg az autó rendszámát!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRendszam.Focus();
            }
            else if (textBoxMertSebesseg.TextLength == 0)
            {
                MessageBox.Show("Adja meg a mért sebességet!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMertSebesseg.Focus();
            }
            else if (File.Exists("gyorshajtasok.txt"))
            {
                FileStream fs = new FileStream("gyorshajtasok.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write($"\n{textBoxRendszam.Text};{textBoxMertSebesseg.Text};{kategoria};{buntetesOsszeg}");
                sw.Close();
                fs.Close();
                MessageBox.Show("Sikeres mentés!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMertSebesseg.Clear();
                textBoxRendszam.Clear();
            }
            else
            {
                FileStream fs = new FileStream("gyorshajtasok.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write($"{textBoxRendszam.Text};{textBoxMertSebesseg.Text};{kategoria};{buntetesOsszeg}");
                sw.Close();
                fs.Close();
                MessageBox.Show("Sikeres mentés!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMertSebesseg.Clear();
                textBoxRendszam.Clear();
            }

            
        }
    }
}
