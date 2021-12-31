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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    Form1 form = new Form1();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();

        }
    }
}
