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
        List<DailyReport> newList;
        List<WeeklyReport> weeklyReports;
        string file = @"C:\Users\Abhinav\TicketDetails.csv";
        public Report()
        {
            InitializeComponent();
            newList = new List<DailyReport>();
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
                
                if (File.Exists(file))
                {
                    TicketDetails TD = new TicketDetails();
                    List<TicketData> dailyReport;
                    dailyReport = TD.getTicketData();
                    var groupList = dailyReport.GroupBy(a => a.category);

                    foreach (var group in groupList)
                    {
                        DailyReport DR = new DailyReport();
                        DR.category = group.Key;
                        DR.dailyCustomers = group.Count();
                        newList.Add(DR);
                    }
                    dailyReportGrid.DataSource = newList;
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(file))
                {
                    TicketDetails TD = new TicketDetails();
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
                    string curDate = date.ToShortDateString();
                    Console.WriteLine("Start Of Week: " + startDateOfWeek.ToShortDateString());
                    Console.WriteLine("End of week:" + endDateOfWeek.ToShortDateString());

                    var groupList = ticketDatas.GroupBy(a => a.Date).Select((
                        s => new
                        {
                            Key = s.Key,
                            Value = s.Sum(a => a.price),
                            visitor = s.Count()

                        })).Where(s => DateTime.Parse(s.Key) >= DateTime.Parse(start) && DateTime.Parse(s.Key) <= DateTime.Parse(end));
                    foreach (var group in groupList)
                    {
                        WeeklyReport WR = new WeeklyReport();
                        WR.date = group.Key;
                        WR.totalVisitor = group.visitor;
                        WR.totalEarning = group.Value;
                        weeklyReports.Add(WR);

                    }
                    weeklyReportGrid.DataSource = weeklyReports;
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
       
        }
    }
}
