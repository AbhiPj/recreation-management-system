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

namespace _19030690_Abhinav_Parajuli
{
    public partial class LoginEmployee : Form
    {
        public LoginEmployee()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RegisterEmployee employee = new RegisterEmployee();
            string employeePath = @"../../../employee.csv";

            if (File.Exists(employeePath))
            {
                var employeeList = employee.getEmployees(employeePath);
                var username = employeeList.Select(x => x.Username);
                var password = employeeList.Select(x => x.Password);
                if (username.Contains(txtUsername.Text) && password.Contains(txtPassword.Text))
                {
                    MessageBox.Show("Logged In");
                    this.Hide();
                    EmployeeForm empForm = new EmployeeForm();
                    empForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid");

                }
            }
            else
            {
                MessageBox.Show("File does not exist");
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
