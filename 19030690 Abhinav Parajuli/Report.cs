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
        public Report()
        {
            InitializeComponent();
            newList = new List<DailyReport>();
        }

        public void getDailyVisitor()
        {
            MessageBox.Show("this is it");
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            TicketDetails TD = new TicketDetails();
            List<TicketData> dailyReport;
            dailyReport = TD.getDailyReport();
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

        }
    }
}
