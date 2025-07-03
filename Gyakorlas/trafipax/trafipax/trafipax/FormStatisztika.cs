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
    public partial class FormStatisztika : Form
    {
        List<Meresek> lmeres = new List<Meresek>();

        
        public void betoltes()
        {
            FileStream fs = new FileStream("gyorshajtasok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                Meresek m = new Meresek(sr.ReadLine());
                lmeres.Add(m);
            }

            sr.Close();
            fs.Close();
        }

        public void szures()
        {
            dataGridView1.Rows.Clear();
            int osszeg = 0;

            if (radioButton1.Checked)
            {
                
                

                for (int i = 0; i < lmeres.Count; i++)
                {
                    dataGridView1.Rows.Add(lmeres[i].Rendszam, lmeres[i].Mertsebesseg, lmeres[i].Buntetes);
                    osszeg += lmeres[i].Buntetes;
                }
                label2.Text = $"Bírságok összege: {osszeg} Ft";
                label1.Text = $"Mérések száma: {lmeres.Count}";
            }

            if (radioButton2.Checked)
            {
                int kategoria = comboBox1.SelectedIndex;
                int db = 0;
                for (int i = 0; i < lmeres.Count; i++)
                {
                    if (lmeres[i].Kategoria == kategoria)
                    {
                        db++;
                        osszeg += lmeres[i].Buntetes;
                        dataGridView1.Rows.Add(lmeres[i].Rendszam, lmeres[i].Mertsebesseg, lmeres[i].Buntetes);
                    }
                }
                label2.Text = $"Bírságok összege: {osszeg} Ft";
                label1.Text = $"Mérések száma: {db}";
            }
        }
        public FormStatisztika()
        {
            InitializeComponent();
        }

        private void FormStatisztika_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            comboBox1.Visible = false;
            betoltes();
            szures();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Visible = true;
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Visible = false;
                szures();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szures();
        }
    }
}
