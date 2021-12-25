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
using CsvHelper;

namespace _19030690_Abhinav_Parajuli
{
    public partial class TicketDetails : UserControl
    {
        List<TicketData> ticketDatas;
        string file = @"C:\Users\Abhinav\TicketDetails.csv";
        public TicketDetails()
        {
            InitializeComponent();
            ticketDatas = new List<TicketData>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"C:\Users\Abhinav\TicketDetails.csv";
                DateTime date = DateTime.Now;

                if (File.Exists(file))
                {
                    ticketDatas = ReadCsv(file);
                }
                TicketData TK = new TicketData();
                TK.category = cmbTicketCategory.Text;
                TK.name = txtName.Text;
                TK.age = int.Parse(txtAge.Text);
                TK.Date = date;
                TK.time_duration = cmbDuration.Text;


                PriceRate PD = new PriceRate();
                int price = PD.GetPrice(TK.category, TK.time_duration);
                TK.price = price;

                ticketDatas.Add(TK);
                WriteCsv(file, ticketDatas);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        
           

     


        
        }
        public void WriteCsv(string path, List<TicketData> list)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Abhinav\TicketDetails.csv", false, System.Text.Encoding.UTF8))
            {
                var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(list); // where values implements IEnumerable
                csvWriter.Dispose();
            }
        }

        public List<TicketData> ReadCsv(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    var streamReader = new StreamReader(path);
                    var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                    var record = csvReader.GetRecords<TicketData>().ToList();
                    csvReader.Dispose();
                    return record;
                }
                else
                {
                    MessageBox.Show("File does not exist");
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<TicketData> getTicketData()
        {
            ticketDatas= ReadCsv(file);
            return ticketDatas;

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ticketDatas = ReadCsv(file);
            dataGridView1.DataSource = ticketDatas;
        }
    }
}
