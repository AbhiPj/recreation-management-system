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
        List<TicketData> ticketDatas= new List<TicketData>();
        private IEnumerable<int> userID;
        string file = @"../../../TicketDetails.csv";
        string priceCsv = @"../../../price.csv";

        public TicketDetails()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(priceCsv))
                {
                    DateTime date = DateTime.Now;
               
                    string curDate = date.ToShortDateString();


                    DayOfWeek day = date.DayOfWeek;
                    var todayDay = day.ToString();
                    string dayType;
                    
                    if (todayDay == "Saturday")
                    {
                         dayType = "Weekend";
                    }
                    else
                    {
                         dayType = "Weekdays";
                    }

                    TicketData TK = new TicketData();
                    PriceRate PD = new PriceRate();

                    TK.Id = int.Parse(txtID.Text);
                    TK.Category = cmbTicketCategory.Text;
                    TK.Name = txtName.Text;
                    TK.Age = int.Parse(txtAge.Text);
                    TK.Date = curDate;
                    TK.CheckinTime = date.ToShortTimeString();
                    TK.Time_duration = null;
                    TK.CheckoutTime = null;
                    TK.Price = 0;
                    TK.Day = todayDay;

                    if (File.Exists(file))
                    {
                        ticketDatas = ReadCsv(file);
                        userID = ticketDatas.Select(x => x.Id);
                        if (userID.Contains(TK.Id))
                        {
                            MessageBox.Show("User with the ID already exists");
                        }
                        else
                        {
                            //int price1 = PD.GetPrice(TK.category, TK.time_duration, dayType);
                            ticketDatas.Add(TK);
                            WriteCsv(file, ticketDatas);
                        }
                    }
                    else
                    {
                        // int price = PD.GetPrice(TK.category, TK.time_duration, dayType);
                        TK.Price = 0;
                        ticketDatas.Add(TK);
                        WriteCsv(file, ticketDatas);
                    }
                       
                }
                else
                {
                    MessageBox.Show("Price file does not exist");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error" + exc);
            }
        }
        public void WriteCsv(string path, List<TicketData> list)
        {
            using (StreamWriter writer = new StreamWriter(@"../../../TicketDetails.csv", false, System.Text.Encoding.UTF8))
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                ticketDatas = ReadCsv(file);
                List<TicketData> newTicketList;
                newTicketList = ReadCsv(file);

                TicketData TK = new TicketData();
                var id = int.Parse(txtCheckoutID.Text);
                var count = 0;
                foreach (TicketData ticket in ticketDatas)
                {
                    if (ticket.Id == id)
                    {
                        if (ticket.CheckoutTime == "")
                        {
                            DateTime date = DateTime.Now;
                            string curDate = date.ToShortDateString();


                            DayOfWeek day = date.DayOfWeek;
                            var todayDay = day.ToString();
                            string dayType;

                            if (todayDay == "Saturday")
                            {
                                dayType = "Weekend";
                            }
                            else
                            {
                                dayType = "Weekdays";
                            }

                            ticket.CheckoutTime = date.ToShortTimeString();
                            TimeSpan diff = getDuration(ticket.CheckinTime, ticket.CheckoutTime);
                            string timeDiff = diff.TotalHours.ToString();
                            ticket.Time_duration = diff.ToString();


                            PriceRate PR = new PriceRate();

                            int price1 = PR.GetPrice(ticket.Category, timeDiff, dayType);
                            ticket.Price = price1;

                            newTicketList.RemoveAt(count);
                            newTicketList.Add(ticket);
                            MessageBox.Show("checked out " +"\n Price: " + price1 + "\nDuration: " + ticket.Time_duration + "\nCheckOut Time: " + ticket.CheckoutTime);

                        }
                        else
                        {
                            MessageBox.Show("Already checked out");
                        }

                    }
                    count = count + 1;
                }
                WriteCsv(file, newTicketList);
            }
            catch
            {

            }
        }
        public TimeSpan getDuration(string checkIn, string checkOut)
        {
            DateTime checkInTime = DateTime.Parse(checkIn);
            DateTime checkOutTime = DateTime.Parse(checkOut);
            TimeSpan diff = checkOutTime - checkInTime;
            return diff;

        }
    }
}
