using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ko_papir_ollo
{
    public partial class Form1 : Form
    {
        int gep_pont = 0;
        int jatekos_pont = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public int jatek()
        {
            Random rnd = new Random();
            int gep = rnd.Next(1, 4);
            int jatekos = 0;
            int eredmeny = -1;

            if (gep == 1)
            {
                textBox1.Text = "Kő";
            }
            else if (gep == 2)
            {
                textBox1.Text = "Papír";
            }
            else
            {
                textBox1.Text = "Olló";
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    jatekos = 1;
                    break;
                case 1:
                    jatekos = 2;
                    break;
                case 2:
                    jatekos = 3;
                    break;
            }

            if (jatekos == gep)
            {
                eredmeny = 2;
            }
            else if (jatekos == 1 && gep == 3 || jatekos == 2 && gep == 1 || jatekos == 3 && gep == 2)
            {
                eredmeny = 0;
            }
            else
            {
                eredmeny = 1;
            }

            return eredmeny;
        }
        public void szamolas(int szam)
        {
            switch (szam)
            {
                case 0:
                    jatekos_pont += 1;
                    break;
                case 1:
                    gep_pont += 1;
                    break;
                case 2:
                    jatekos_pont += 1;
                    gep_pont += 1;
                    break;
            }

            label4.Text = $"{gep_pont} : {jatekos_pont}";
        }

        public void nyer()
        {
            if(gep_pont == 5 && jatekos_pont < 5)
            {
                DialogResult valasz = MessageBox.Show("A gép nyert!", "Vesztettél!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (valasz == DialogResult.OK)
                {
                    gep_pont = 0;
                    jatekos_pont = 0;
                    label4.Text = $"{gep_pont} : {jatekos_pont}";
                }
            }
            else if (jatekos_pont == 5 && gep_pont < 5)
            {
                DialogResult valasz = MessageBox.Show("Ügyes vagy nyertél!", "Nyertél!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (valasz == DialogResult.OK)
                {
                    gep_pont = 0;
                    jatekos_pont = 0;
                    label4.Text = $"{gep_pont} : {jatekos_pont}";
                }
            }
            else if (gep_pont == 5 && jatekos_pont == 5)
            {
                DialogResult valasz = MessageBox.Show("Döntetlen!", "Döntetlen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (valasz == DialogResult.OK)
                {
                    gep_pont = 0;
                    jatekos_pont = 0;
                    label4.Text = $"{gep_pont} : {jatekos_pont}";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adat = jatek();
            szamolas(adat);
            nyer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan ki szeretnél lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
