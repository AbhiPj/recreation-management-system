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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginEmployee loginEmployee = new LoginEmployee();
            loginEmployee.Show();
        }
    }
}
