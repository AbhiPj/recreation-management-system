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

        // Onclick listener for admin button
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            //Hides the current form and then shows the admin login form
            this.Hide();
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            //Hides the current form and then shows the employee login form
            this.Hide();
            LoginEmployee loginEmployee = new LoginEmployee();
            loginEmployee.Show();
        }
    }
}
