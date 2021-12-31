using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19030690_Abhinav_Parajuli
{
    public partial class Form1 : Form
    {
      //  PriceRate priceRate = new PriceRate();
        //Report report = new Report();
        public Form1()
        {
            InitializeComponent();
            report1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ticketDetails1.BringToFront();
        }

        private void btnPriceDetails_Click(object sender, EventArgs e)
        {
            priceDetails1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Show();
        }
    }
}
