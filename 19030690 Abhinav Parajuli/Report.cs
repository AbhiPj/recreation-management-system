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
    public partial class Report : UserControl
    {
        List<DailyReport> dailyReports;
        List<DailyReport> sortReport= new List<DailyReport>();

        List<WeeklyReport> weeklyReports;
        List<WeeklyReport> weeklyReports2 = new List<WeeklyReport>();
        bool sorted = false;
        bool weeklyEarningSorted = false;
        bool weeklyVisitorSorted = false;

        string file = @"../../../TicketDetails.csv";
        public Report()
        {
            InitializeComponent();
            dailyReports = new List<DailyReport>();
            weeklyReports = new List<WeeklyReport>();
        }

        //Button to generate daily report
        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            try
            {
                dailyReports = getDailyReports();       //gets daily report from the method and stores in list
                dailyReportGrid.DataSource = dailyReports;      //showing the report in grid
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }

        //Button to generate weekly report
        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {
                weeklyReports = getWeeklyReport();      //gets weekly report from the method and stores in list
                weeklyReportGrid.DataSource = weeklyReports;        //showing the report in grid
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error1" + exc.Message);
            }
        }

        //Method to get weekly report
        public List<WeeklyReport> getWeeklyReport()
        {
            if (File.Exists(file))
            {
                TicketDetails TD = new TicketDetails();
                List<WeeklyReport> reportWeekly = new List<WeeklyReport>();
                List<TicketData> ticketDatas;
                ticketDatas = TD.getTicketData();

                DateTime date = DateTime.Now;       //Stores the current date and time in variable


                //getting start and end Date of the week
                int year = date.Date.Year;
                DateTime firstDay = new DateTime(year, 1, 1);
                CultureInfo cul = CultureInfo.CurrentCulture;
                int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                int days = (weekNo - 1) * 7;
                DateTime dt1 = firstDay.AddDays(days);
                DayOfWeek dow = dt1.DayOfWeek;
                DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
                DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
                string start = startDateOfWeek.ToShortDateString();     //converting the start date to short Date format
                string end = endDateOfWeek.ToShortDateString();         //converting the end date to short Date format

                //Filtering the data to group by date and get daily visitors and total income
                var groupList = ticketDatas.GroupBy(a => a.Date).Select((
                    s => new
                    {
                        Key = s.Key,
                        Value = s.Sum(a => a.Price),
                        visitor = s.Count()
                    })).Where(s => DateTime.Parse(s.Key) >= DateTime.Parse(start) && DateTime.Parse(s.Key) <= DateTime.Parse(end));     //filtering data by start and end of week
                foreach (var group in groupList)
                {
                    //getting day of week for that day
                    DateTime dateDay = DateTime.Parse(group.Key);
                    DayOfWeek d = dateDay.DayOfWeek;

                    //Creating WR object and adding it to weekly report array
                    WeeklyReport WR = new WeeklyReport();
                    WR.date = d.ToString();
                    WR.TotalVisitor = group.visitor;
                    WR.TotalEarning = group.Value;
                    reportWeekly.Add(WR);
                }
                return reportWeekly;
            }
            else
            {
                MessageBox.Show("File does not exist");
                return null;
            }
        }

        //Method to calculate and return daily report from ticket data
        public List<DailyReport> getDailyReports()
        {
            //Checks if Ticket details file exists
            if (File.Exists(file))
            {
                List<DailyReport> reportDaily = new List<DailyReport>();
                TicketDetails TD = new TicketDetails();
                List<TicketData> ticketData;
                ticketData = TD.getTicketData();        //getting ticket data 
                DateTime date = DateTime.Parse(dateDailyReport.Text);
                var shortDate = date.ToShortDateString();
                //Getting the daily report 
                var groupList = ticketData.Where(a => a.Date == shortDate.ToString()).GroupBy(b => b.Category);

                //var groupList = ticketData.GroupBy(a => a.Category);
                foreach (var group in groupList)
                {
                    DailyReport DR = new DailyReport();
                    DR.Category = group.Key;
                    DR.DailyCustomers = group.Count();
                    reportDaily.Add(DR);
                }
                return reportDaily;
            }
            else
            {
                MessageBox.Show("File does not exist");
                return null;
            }

        }

        private void btnSortVisitor_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {
                //Sorting data according to daily customers by ascending and descending
                if (!sorted)
                {
                    sortReport = dailyReports.OrderBy(o => o.DailyCustomers).ToList();
                    sorted = true;
                    dailyReportGrid.DataSource = sortReport;
                }
                else
                {
                    sortReport = dailyReports.OrderByDescending(o => o.DailyCustomers).ToList();
                    sorted = false;
                    dailyReportGrid.DataSource = sortReport;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Button for Sorting Weekly report data by Total earning
        private void btnWeeklySortEarning_Click(object sender, EventArgs e)
        {
            //Exception handling
            try
            {
                weeklyReports = getWeeklyReport();      //Getting data
                //Sorting data according to earning by ascending and descending
                if (!weeklyEarningSorted)
                {
                    weeklyReports = weeklyReports.OrderBy(o => o.TotalEarning).ToList();
                    weeklyEarningSorted = true;
                    weeklyReportGrid.DataSource = weeklyReports;
                }
                else
                {
                    weeklyReports = weeklyReports.OrderByDescending(o => o.TotalEarning).ToList();
                    weeklyEarningSorted = false;
                    weeklyReportGrid.DataSource = weeklyReports;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error1" + exc.Message);
            }
        }

        //Button for sorting weeky report by total visitors
        private void btnWeeklySortVisitor_Click(object sender, EventArgs e)
        {
            try
            {
                weeklyReports = getWeeklyReport();
                if (!weeklyVisitorSorted)
                {
                    weeklyReports = weeklyReports.OrderBy(o => o.TotalVisitor).ToList();
                    weeklyVisitorSorted = true;
                    weeklyReportGrid.DataSource = weeklyReports;
                }
                else
                {
                    weeklyReports = weeklyReports.OrderByDescending(o => o.TotalVisitor).ToList();
                    weeklyVisitorSorted = false;
                    weeklyReportGrid.DataSource = weeklyReports;
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error1" + exc.Message);
            }
          
        }

        //Button to clear the daily report grid view
        private void btnClear_Click(object sender, EventArgs e)
        {
            dailyReportGrid.DataSource = null;
        }

        //Button to clear the weekly report grid view
        private void btnWeeklyClear_Click(object sender, EventArgs e)
        {
            weeklyReportGrid.DataSource = null;

        }
    }
}
