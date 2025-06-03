using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koncert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void szamol()
        {
            int osszeg = 0;
            int allohely_ar = 0;
            int allohely_darab = 0;
            int ulohely_ar = 0;
            int ulohely_darab = 0;

            if (radioButton1.Checked == true)
            {
                ulohely_ar = 1990;
            }
            else if (radioButton2.Checked == true)
            {
                ulohely_ar = 2990;
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ulohely_darab = 0;
                    break;
                case 1:
                    ulohely_darab = 1;
                    break;
                case 2:
                    ulohely_darab = 2;
                    break;
                case 3:
                    allohely_darab = 3;
                    break;
                case 4:
                    ulohely_darab = 4;
                    break;
                case 5:
                    ulohely_darab = 5;
                    break;
            }

            osszeg = osszeg + (ulohely_ar * ulohely_darab);

            if (radioButton3.Checked == true)
            {
                allohely_ar = 1490;
            }
            else if (radioButton4.Checked == true)
            {
                allohely_ar = 2190;
            }

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    allohely_darab = 0;
                    break;
                case 1:
                    allohely_darab = 1;
                    break;
                case 2:
                    allohely_darab = 2;
                    break;
                case 3:
                    allohely_darab = 3;
                    break;
                case 4:
                    allohely_darab = 4;
                    break;
                case 5:
                    allohely_darab = 5;
                    break;
            }
            osszeg = osszeg + (allohely_ar * allohely_darab);

            label2.Text = $"Fizetendő: {osszeg} Forint";
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            szamol();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            szamol();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            szamol();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            szamol();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamol();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            szamol();
        }
    }
}
