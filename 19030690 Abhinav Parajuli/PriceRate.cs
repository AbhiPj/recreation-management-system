using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace _19030690_Abhinav_Parajuli
{
    public partial class PriceRate : UserControl
    {

        List<priceData> priceDatas;
        string file = @"C:\Users\Abhinav\price.csv";
        public PriceRate()
        {
            InitializeComponent();
            priceDatas = new List<priceData>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"C:\Users\Abhinav\price.csv";
                if (File.Exists(file))
                {
                    priceDatas = ReadCsv(file);
                }
                priceData PD = new priceData();

          /*     ValidationContext context = new ValidationContext(PD, null, null);
                IList<ValidationResult> error = new List<ValidationResult>();
                if (!Validator.TryValidateObject(PD, context, error, true))
                {
                    foreach (ValidationResult result in error)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
          */
               
                PD.category = cmbCategory.Text;
                PD.rate1 = int.Parse(txtRate1.Text);
                PD.rate2 = int.Parse(txtRate2.Text);
                PD.rate3 = int.Parse(txtRate3.Text);
                PD.rate4 = int.Parse(txtRate4.Text);
                PD.wholeDay = int.Parse(txtWholeDay.Text);
                if (rbtnWeekday.Checked)
                {
                    PD.dayType = rbtnWeekday.Text;
                }
                else
                {
                    PD.dayType = rbtnWeekend.Text;

                }

                var category = priceDatas.Select(x => x.category);
                bool Exist = false;
                if (category.Contains(PD.category))
                {
                    foreach (priceData price in priceDatas)
                    {
                        if (price.category==PD.category && price.dayType == PD.dayType)
                        {
                            MessageBox.Show("already exists");
                            Exist = true;
                            break;
                        }
                    }
                }

                if (Exist)
                {
                    MessageBox.Show("already exist if condition");
                }
                else
                {
                    priceDatas.Add(PD);
                    WriteCsv(file, priceDatas);
                    var parice = priceDatas.Select(x => x.category);
                    dataGridView1.DataSource = priceDatas;
                    MessageBox.Show("Price added");
                    txtRate1.Clear();
                    txtRate2.Clear();
                    txtRate3.Clear();
                    txtRate4.Clear();
                    txtWholeDay.Clear();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Please insert all data" + exc.Message);
            }
        }
       
        private void btnRead_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\Abhinav\price.csv";
            if (File.Exists(path))
            {
                priceDatas = ReadCsv(path);
                dataGridView1.DataSource = priceDatas;
               
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
        public void WriteCsv(string path, List<priceData> list)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Abhinav\price.csv", false, System.Text.Encoding.UTF8))
            {
                var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(list); // where values implements IEnumerable
                csvWriter.Dispose();
              
            }
        }

        public List<priceData> ReadCsv(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    var streamReader = new StreamReader(path);
                    var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                    var record = csvReader.GetRecords<priceData>().ToList();
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
        public int GetPrice(string category, string duration, string day)
        {
            priceDatas = ReadCsv(file);
            int price = 0;
            double timeDiff = double.Parse(duration);
            var RateCategory = priceDatas.Select(x => x.category);
            foreach(var rate in priceDatas)
            {
                if (rate.category==category && rate.dayType == day)
                {
                    if (timeDiff <= 1)
                    {
                         price = rate.rate1;
                       

                    }
                    else if(timeDiff <= 2)
                    {
                      
                        price = rate.rate2;
                    }
                    else if(timeDiff <= 3)
                    {
                     
                        price = rate.rate3;
                    }
                    else if(timeDiff <= 4)
                    {
                        price = rate.rate4;
                    }
                    else
                    {
                        price = rate.wholeDay;
                    }
                }
            }
            return price;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch(Exception exc)
            {
                MessageBox.Show("error");
            }
        }
    }
    }

