using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osztalyzat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adat = Convert.ToInt32(beolvas.Text);

            if (adat < 0 || adat > 100)
            {
                megjelen.Text = "Hibás adat!";
                megjelen.Visible = true;
            }
            else if (adat < 33)
            {
                megjelen.Text = "1 - elégtelen";
                megjelen.Visible = true;
            }
            else if (adat < 50){
                megjelen.Text = "2 - elégséges";
                megjelen.Visible = true;
            }
            else if (adat < 70)
            {
                megjelen.Text = "3 - közepes";
                megjelen.Visible = true;
            }
            else if (adat < 85)
            {
                megjelen.Text = "4 - jó";
                megjelen.Visible = true;
            }
            else
            {
                megjelen.Text = "5 - kiváló";
                megjelen.Visible = true;
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
