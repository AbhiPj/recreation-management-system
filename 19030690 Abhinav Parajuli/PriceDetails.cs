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
    public partial class PriceDetails : UserControl
    {
        List<priceData> priceList;
        public PriceDetails()
        {
            InitializeComponent();
            priceList = new List<priceData>();
        }

        private void btnReadPrice_Click(object sender, EventArgs e)
        {
            PriceRate PR = new PriceRate();
            string priceFile = @"C:\Users\Abhinav\price.csv";
            priceList= PR.ReadCsv(priceFile);
            priceGridView.DataSource = priceList;
        }
    }
}
