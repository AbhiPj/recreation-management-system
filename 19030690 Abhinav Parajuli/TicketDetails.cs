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
        string file = @"../../../TicketDetails.csv";    // location for ticket details CSV file
        string priceCsv = @"../../../price.csv";        // location for price csv file
        public TicketDetails()
        {
            InitializeComponent();
        }

        //Button to take the data inserted by the user and write on CSV file.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {
                //Checks if the price CSV file exists
                if (File.Exists(priceCsv))
                {
                    DateTime date = DateTime.Now;                    //To get the current date and time
                    string curDate = date.ToShortDateString();      //Converts the Date and time into date
                    DayOfWeek day = date.DayOfWeek;                 //Gets the current day of week
                    var todayDay = day.ToString();
                    string dayType;
                    //checking for day type
                    if (todayDay == "Saturday")
                    {
                         dayType = "Weekend";
                    }
                    else
                    {
                         dayType = "Weekdays";
                    }
                    TicketData TK = new TicketData();                //Creating object of TicketData class
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

                    //Check if file exists and add new data to file
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
                            ticketGridView.DataSource = ticketDatas;
                            MessageBox.Show("Data added");
                        }
                    }
                    //Adding data if file does not exist
                    if (!File.Exists(file))
                    {
                        TK.Price = 0;
                        ticketDatas.Add(TK);
                        WriteCsv(file, ticketDatas);
                        ticketGridView.DataSource = ticketDatas;
                        MessageBox.Show("Data added");
                    }
                }
                else
                {
                    MessageBox.Show("Price file does not exist");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        //Method for writing on CSV file
        public void WriteCsv(string path, List<TicketData> list)
        {
            using (StreamWriter writer = new StreamWriter(file, false, System.Text.Encoding.UTF8))
            {
                var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(list); 
                csvWriter.Dispose();
            }
        }

        //Method for Reading CSV file
        public List<TicketData> ReadCsv(string path)
        {
            try
            {
                //Check if file exists
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

        //Method to get ticket data 
        public List<TicketData> getTicketData()
        {
            ticketDatas= ReadCsv(file);
            return ticketDatas;
        }

        //Button for Read 
        private void btnRead_Click(object sender, EventArgs e)
        {
            ticketDatas = ReadCsv(file);
            ticketGridView.DataSource = ticketDatas;
        }
        //Button for checkout
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                ticketDatas = ReadCsv(file);        //Reading CSV and storing into List
                List<TicketData> newTicketList;
                newTicketList = ReadCsv(file);
                TicketData TK = new TicketData();
                var id = int.Parse(txtCheckoutID.Text);
                var count = 0;
                var checkId = ticketDatas.Select(a => a.Id);

                //checks if the user exists
                if (!checkId.Contains(id))
                {
                    MessageBox.Show("This user does not exist");
                }
                else
                {
                    //Updating checkout time for the user
                    foreach (TicketData ticket in ticketDatas)
                    {
                        if (ticket.Id == id)
                        {
                            if (ticket.CheckoutTime == "")
                            {
                                DateTime date = DateTime.Now;
                                //string curDate = date.ToShortDateString();
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

                                //calculating duration
                                TimeSpan diff = getDuration(ticket.CheckinTime, ticket.CheckoutTime);
                                string timeDiff = diff.TotalHours.ToString();
                                ticket.Time_duration = diff.ToString();

                                //Calculating price 
                                PriceRate PR = new PriceRate();         //Creating PriceRate object to call GetPrice method
                                int price1 = PR.GetPrice(ticket.Category, timeDiff, dayType);
                                ticket.Price = price1;

                                //Replacing List with new data
                                newTicketList.RemoveAt(count);
                                newTicketList.Add(ticket);

                                //Showing data in grid view and displaying message to user
                                ticketGridView.DataSource = newTicketList;
                                MessageBox.Show("checked out " + "" +
                                    "\n Price: " + price1 + "" +
                                    "\nDuration: " + ticket.Time_duration + "" +
                                    "\nCheckOut Time: " + ticket.CheckoutTime);
                            }
                            else
                            {
                                MessageBox.Show("Already checked out");
                            }
                        }
                        count = count + 1;
                    }

                }
           
                WriteCsv(file, newTicketList);      //Writing the new data with checkout info into CSV
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method to substract time and get duration
        public TimeSpan getDuration(string checkIn, string checkOut)
        {
            DateTime checkInTime = DateTime.Parse(checkIn);
            DateTime checkOutTime = DateTime.Parse(checkOut);
            TimeSpan diff = checkOutTime.Subtract(checkInTime);     //substracting time to get duration

            //TimeSpan diff = checkOutTime - checkInTime;
            return diff;

        }
    }
}
