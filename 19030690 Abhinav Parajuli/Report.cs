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

        public void getDailyVisitor()
        {
            MessageBox.Show("this is it");
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            try
            {
                dailyReports = getDailyReports();
                dailyReportGrid.DataSource = dailyReports;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            try
            {
                weeklyReports = getWeeklyReport();
                weeklyReportGrid.DataSource = weeklyReports;

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error1" + exc.Message);
            }
        }
        public List<WeeklyReport> getWeeklyReport()
        {
            if (File.Exists(file))
            {

                TicketDetails TD = new TicketDetails();
                List<WeeklyReport> reportWeekly = new List<WeeklyReport>();
                List<TicketData> ticketDatas;
                ticketDatas = TD.getTicketData();
                DateTime date = DateTime.Now;
                int year = date.Date.Year;
                DateTime firstDay = new DateTime(year, 1, 1);
                CultureInfo cul = CultureInfo.CurrentCulture;
                int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                int days = (weekNo - 1) * 7;
                DateTime dt1 = firstDay.AddDays(days);
                DayOfWeek dow = dt1.DayOfWeek;
                DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
                DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
                string start = startDateOfWeek.ToShortDateString();
                string end = endDateOfWeek.ToShortDateString();

                var groupList = ticketDatas.GroupBy(a => a.Date).Select((
                    s => new
                    {
                        Key = s.Key,
                        Value = s.Sum(a => a.Price),
                        visitor = s.Count()

                    })).Where(s => DateTime.Parse(s.Key) >= DateTime.Parse(start) && DateTime.Parse(s.Key) <= DateTime.Parse(end));
                foreach (var group in groupList)
                {
                    WeeklyReport WR = new WeeklyReport();
                    DateTime dateDay = DateTime.Parse(group.Key);
                    Day day = (Day)dateDay.DayOfWeek;
                    WR.date = day.ToString();
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

        public List<DailyReport> getDailyReports()
        {
                if (File.Exists(file))
                {
                List<DailyReport> reportDaily = new List<DailyReport>();
                    TicketDetails TD = new TicketDetails();
                    List<TicketData> ticketData;
                    ticketData = TD.getTicketData();
                    var groupList = ticketData.GroupBy(a => a.Category);
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
            try
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                weeklyReports = getWeeklyReport();
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

        private void button1_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            dailyReportGrid.DataSource = null;
        }

        private void btnWeeklyClear_Click(object sender, EventArgs e)
        {
            weeklyReportGrid.DataSource = null;

        }
    }
}
