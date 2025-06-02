using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vonatjegy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void szamolas()
        {
            double osszeg = 0;
            if (textBox1.Text.Length > 0)
            {
                osszeg = Convert.ToDouble(textBox1.Text) * 25;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                osszeg = osszeg / 2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                osszeg = osszeg * 0.1;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                osszeg = osszeg + 150;
            }

            osszeg = Math.Round(osszeg);
            label4.Text = $"A fizetendő összeg: {osszeg} Forint";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                try
                {
                    int km = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("A mezőben csak szám szerepelhet!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                szamolas();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (valasz == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
