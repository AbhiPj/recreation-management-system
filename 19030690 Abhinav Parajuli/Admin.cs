﻿using System;
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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            priceRate1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (username == "admin" && password == "admin")
            {
                priceRate1.Visible = true;
            } 
        }
    }
}
