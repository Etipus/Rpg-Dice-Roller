using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RDR : Form
    {
        public RDR()
        {
            InitializeComponent();
        }

        private void d8button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 9);

            d8label.Text = randomnumber.ToString();
        }

        private void d10button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 11);

            d10label.Text = randomnumber.ToString();
        }

        private void d12button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 13);

            d12label.Text = randomnumber.ToString();
        }

        private void d20button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 21);

            d20label.Text = randomnumber.ToString();
        }

        private void d100button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 101);

            d100label.Text = randomnumber.ToString();
        }

        private void exıtbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
