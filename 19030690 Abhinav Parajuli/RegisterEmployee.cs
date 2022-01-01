using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19030690_Abhinav_Parajuli
{
    public partial class RegisterEmployee : UserControl
    {
        List<EmployeeData> employees;
        string file = @"../../../employee.csv";

        public RegisterEmployee()
        {
            employees = new List<EmployeeData>();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try 
            {
                if (File.Exists(file))
                {
                    employees = getEmployees(file);
                }
                EmployeeData employee = new EmployeeData();
                employee.Name = txtName.Text;
                employee.Age = int.Parse(txtAge.Text);
                employee.Username = txtUsername.Text;
                employee.Password = txtPassword.Text;
                employee.Gender = cmbGender.Text;
                employees.Add(employee);
                using (StreamWriter writer = new StreamWriter(file, false, System.Text.Encoding.UTF8))
                {
                    var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                    csvWriter.WriteRecords(employees); // where values implements IEnumerable
                    csvWriter.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<EmployeeData> getEmployees(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    var streamReader = new StreamReader(path);
                    var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                    var record = csvReader.GetRecords<EmployeeData>().ToList();
                    csvReader.Dispose();
                    return record;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void btnLoadEmployee_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                employees = getEmployees(file);
                employeeGridView.DataSource = employees;
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
    }
}
