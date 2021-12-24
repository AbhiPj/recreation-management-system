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
        public PriceRate()
        {
            InitializeComponent();
            priceDatas = new List<priceData>();
        }

        private void button1_Click(object sender, EventArgs e)
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

                priceDatas.Add(PD);
                WriteCsv(file, priceDatas);
                var parice = priceDatas.Select(x => x.category);
            }

            catch
            {
                MessageBox.Show("Please insert all data");
            }

        }
       


        private void button2_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\Abhinav\price.csv";
            priceDatas = ReadCsv(path);
            dataGridView1.DataSource = priceDatas;
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
    }
}
