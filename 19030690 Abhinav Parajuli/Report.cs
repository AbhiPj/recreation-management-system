using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            TicketDetails TD = new TicketDetails();
            List<TicketData> ticketDatas;
            ticketDatas = TD.getTicketData();

            var groupList = ticketDatas.GroupBy(a => a.Date).Select((
                s => new
                {
                    Key = s.Key,
                    Value = s.Sum(a => a.price),
                    visitor = s.Count()

                })); ;
             
            

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
    }
}
