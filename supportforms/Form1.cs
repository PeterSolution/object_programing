using app3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace supportforms
{
    public partial class Form1 : Form
    {
        Czlowiek czlowiek = new Czlowiek();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            czlowiek.jedzenie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            czlowiek.wyjscie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            czlowiek.rozpoczeciepracy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            czlowiek.koniecpracy();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            czlowiek.rekreacja();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            czlowiek.prysznic();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            czlowiek.spanie();
        }
    }
}
