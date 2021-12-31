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
    public partial class Chart : UserControl
    {
        List<WeeklyReport> chartList;

        public Chart()
        {
            chartList = new List<WeeklyReport>();
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            List<string> xval = new List<string>();
            List<double> totalVisitor = new List<double>();
            List<double> totalEarning = new List<double>();

            Report R = new Report();
            chartList = R.getWeeklyReport();
            foreach (WeeklyReport report in chartList)
            {
                xval.Add(report.date);
                totalVisitor.Add(report.totalVisitor);
                totalEarning.Add(report.totalEarning);




            }
            weeklyChart.Series["Total Visitor"].Points.DataBindXY(xval, totalVisitor);
            weeklyChart.Series["Total Earning"].Points.DataBindXY(xval, totalEarning);


            // weeklyChart.DataSource = chartList;

        }
    }
}
