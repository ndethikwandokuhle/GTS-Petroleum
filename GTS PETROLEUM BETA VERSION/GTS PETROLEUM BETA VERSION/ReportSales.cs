using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class ReportSales : Form
    {
        public ReportSales()
        {
            InitializeComponent();
        }

        public void Loadtables()
        {
            if(fueltype_cbx.SelectedIndex == 0)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                DbConn.DisplayAndSearch("SELECT  date, tankname, pumpname, dipquantity, sideaopen, sideaclose, sideasale, sidebopen, sidebclose, sidebsale, totalsales, amount, dipopenm, dipclosem, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, supervisor, attendant FROM sales WHERE date BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", sales_gdv);
            }
            else if (fueltype_cbx.SelectedIndex == 1)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string fueltank1 = "Petrol_1";
                string fueltank2 = "Petrol_2";
                DbConn.DisplayAndSearch("SELECT  date, tankname, pumpname, dipquantity, sideaopen, sideaclose, sideasale, sidebopen, sidebclose, sidebsale, totalsales, amount, dipopenm, dipclosem, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, supervisor, attendant FROM sales WHERE tankname LIKE '"+ fueltank1 + "' OR tankname LIKE '" + fueltank2 + "' AND date BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", sales_gdv);
            }
            else if (fueltype_cbx.SelectedIndex == 2)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string fueltank1 = "Diesel_1";
                string fueltank2 = "Diesel_2";
                DbConn.DisplayAndSearch("SELECT  date, tankname, pumpname, dipquantity, sideaopen, sideaclose, sideasale, sidebopen, sidebclose, sidebsale, totalsales, amount, dipopenm, dipclosem, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, supervisor, attendant FROM sales WHERE tankname LIKE '" + fueltank1 + "' OR tankname LIKE '" + fueltank2 + "' AND date BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", sales_gdv);
            }

        }

        private void ReportSales_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
            DbConn.DisplayAndSearch("SELECT  date, tankname, pumpname, dipquantity, sideaopen, sideaclose, sideasale, sidebopen, sidebclose, sidebsale, totalsales, amount, dipopenm, dipclosem, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, supervisor, attendant FROM sales", sales_gdv);
        }

        private void report_Click(object sender, EventArgs e)
        {
            Loadtables();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0,9);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
        }
    }
}
