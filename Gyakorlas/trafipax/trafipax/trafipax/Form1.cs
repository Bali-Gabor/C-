using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafipax
{
    public partial class FormFomenu : Form
    {
        public FormFomenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRogzites ujrogzites = new FormRogzites();
            ujrogzites.nevadas(textBox1.Text);
            ujrogzites.ShowDialog();
            
        }

        private void statisztikákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatisztika ujstatisztika = new FormStatisztika();
            ujstatisztika.ShowDialog();
        }
    }
}
