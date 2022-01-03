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
        List<priceData> newPriceData = new List<priceData>();

        string file = @"../../../price.csv";
        public PriceRate()
        {
            InitializeComponent();
            priceDatas = new List<priceData>();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"../../../price.csv";
                if (File.Exists(file))
                {
                    priceDatas = ReadCsv(file);
                    newPriceData = priceDatas;
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
                int count = 0;
                if (category.Contains(PD.category))
                {
                    foreach (priceData price in priceDatas)
                    {
                        if (price.category==PD.category && price.dayType == PD.dayType)
                        {
                            newPriceData.RemoveAt(count);
                            newPriceData.Add(PD);
                             WriteCsv(file, newPriceData);
                            dataGridView1.DataSource = newPriceData;
                            MessageBox.Show("Price replaced");
                            txtRate1.Clear();
                            txtRate2.Clear();
                            txtRate3.Clear();
                            txtRate4.Clear();
                            txtWholeDay.Clear();
                            Exist = true;
                            break;
                        }
                        count = count + 1;
                    }
                }

                if (!Exist)
                {
                    priceDatas.Add(PD);
                    WriteCsv(file, priceDatas);
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
                MessageBox.Show( exc.Message);
            }
        }
       
        private void btnRead_Click(object sender, EventArgs e)
        {
            var path = @"../../../price.csv";
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
            using (StreamWriter writer = new StreamWriter(@"../../../price.csv", false, System.Text.Encoding.UTF8))
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

