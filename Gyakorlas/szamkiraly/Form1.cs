using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamkiraly
{
    public partial class Form1 : Form
    {
        Valtozok a = new Valtozok();
        Random rnd = new Random();

        void MuveletKivalasztas()
        {
            a.Muvelet[0] = checkBox1.Checked;
            a.Muvelet[1] = checkBox2.Checked;
            a.Muvelet[2] = checkBox3.Checked;
            a.Muvelet[3] = checkBox4.Checked;

            int veletlenMuvelet = 0;
            do
            {
                veletlenMuvelet = rnd.Next(0, 4);
            }
            while (a.Muvelet[veletlenMuvelet] != true);

            switch (veletlenMuvelet)
            {
                case 0: a.Muveletijel = "+"; break;
                case 1: a.Muveletijel = "-"; break;
                case 2: a.Muveletijel = "*"; break;
                case 3: a.Muveletijel = "/"; break;
            }
        }

        void SzamKivalasztas()
        {
            int szam1Max = 0;
            int szam2Max = 0;
            RadioButton[] elso = new RadioButton[] {radioButton1, radioButton2, radioButton3, radioButton4};
            RadioButton[] masodik = new RadioButton[] {radioButton5,  radioButton6, radioButton7, radioButton8};

            int i = 0;

            while (!elso[i].Checked)
            {
                i++;
            }

            switch (i)
            {
                case 0: szam1Max = 10; break;
                case 1: szam1Max = 100; break;
                case 2: szam1Max = 1000; break;
                case 3: szam1Max = 10000; break;
            }

            i = 0;

            while (!masodik[i].Checked)
            {
                i++;
            }

            switch (i)
            {
                case 0: szam2Max = 10; break;
                case 1: szam2Max = 100; break;
                case 2: szam2Max = 1000; break;
                case 3: szam2Max = 10000; break;
            }

            if (a.Muveletijel == "/")
            {

                do
                {
                    a.Szam1 = rnd.Next(1, szam1Max);
                    a.Szam2 = rnd.Next(1, szam2Max);
                }
                while (a.Szam1 % a.Szam2 != 0);
            }
            else if (a.Muveletijel == "-")
            {
                do
                {
                    a.Szam1 = rnd.Next(1, szam1Max);
                    a.Szam2 = rnd.Next(1, szam2Max);
                }
                while (a.Szam1 < a.Szam2);
            }
            else
            {
                a.Szam1 = rnd.Next(1, szam1Max);
                a.Szam2 = rnd.Next(1, szam2Max);
            }
        }

        void FeladatKiiras()
        {
            if (a.Muveletijel == "+")
            {
                label4.Text = $"{a.Szam1} + {a.Szam2} = ";
                label4.Visible = true;
                a.Eredmeny = a.Szam1 + a.Szam2;
            }
            else if (a.Muveletijel == "-")
            {
                label4.Text = $"{a.Szam1} - {a.Szam2} = ";
                label4.Visible = true;
                a.Eredmeny = a.Szam1 - a.Szam2;
            }
            else if (a.Muveletijel == "*")
            {
                label4.Text = $"{a.Szam1} * {a.Szam2} = ";
                label4.Visible = true;
                a.Eredmeny = a.Szam1 * a.Szam2;
            }
            else
            {
                label4.Text = $"{a.Szam1} / {a.Szam2} = ";
                label4.Visible = true;
                a.Eredmeny = a.Szam1 / a.Szam2;
            }
        }

        void jatek()
        {
            if (button3.Text == "Új játék")
            {
                a.Pont1 = 0;
                a.Pont2 = 0;
                label6.Text = "0";
                label7.Text = "0";
                a.On = false;
                Application.Restart();
            }

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                label3.Visible = true;
                label3.Text = "Legalább egy\nműveletet ki\nkell választani!";
                label4.Visible = false;
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && a.On == false)
            {
                MessageBox.Show("A játékosok nevét meg kell adni!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a.On = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Visible = false;
                textBox3.Text = "";
                a.Visszaszamlalas = 5;
                label5.Text = "5 mp";
                label6.Visible = true;
                label7.Visible = true;
                label3.Visible = false;
                button3.Text = "Következő";
                MuveletKivalasztas();
                SzamKivalasztas();
                FeladatKiiras();
            }
        }

        void pontozas()
        {
            bool valasz = Convert.ToString(a.Eredmeny) == textBox3.Text;
            if (a.Megfejtes)
            {
                if (valasz)
                {
                    a.Pont1 += 2;
                    MessageBox.Show("A válasz helyes!", "HELYES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    a.Pont2++;
                    MessageBox.Show("A válasz helytelen!", "HELYTELEN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (valasz)
                {
                    a.Pont2 += 2;
                    MessageBox.Show("A válasz helyes!", "HELYES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    a.Pont1++;
                    MessageBox.Show("A válasz helytelen!", "HELYTELEN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            label6.Text = $"{a.Pont1}";
            label7.Text = $"{a.Pont2}";

            if (a.Pont1 >= 5 || a.Pont2 >= 5)
            {
                if (a.Pont1 >= 5)
                {
                    MessageBox.Show($"Gratulálok {button1.Text} nyert!", "NYERTES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button3.Text = "ÚJ játék";
                }
                else
                {
                    MessageBox.Show($"Gratulálok {button2.Text} nyert!", "NYERTES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button3.Text = "ÚJ játék";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
        }

        private void nev1(object sender, KeyEventArgs e)
        {
            button1.Text = textBox1.Text;
            a.Jatekos1 = textBox1.Text;
        }

        private void nev2(object sender, KeyEventArgs e)
        {
            button2.Text = textBox2.Text;
            a.Jatekos2 = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jatek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a.On)
            {
                textBox3.Visible = true;
                textBox3.Focus();
                timer1.Enabled = true;
                timer1.Start();
                a.Megfejtes = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a.On)
            {
                textBox3.Visible = true;
                textBox3.Focus();
                timer1.Enabled = true;
                timer1.Start();
                a.Megfejtes = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a.Visszaszamlalas > 0)
            {
                a.Visszaszamlalas--;
                label5.Text = $"{a.Visszaszamlalas} mp";
            }
            else
            {
                timer1.Stop();
                pontozas();
            }
        }
    }
}
