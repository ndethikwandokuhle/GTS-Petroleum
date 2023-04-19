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
    public partial class ReportRates : Form
    {
        public ReportRates()
        {
            InitializeComponent();
        }

        private void ReportRates_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
            DbConn.DisplayAndSearch("SELECT date, petrol, diesel FROM rates", rates_dgv);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
        }

        private void report_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            DbConn.DisplayAndSearch("SELECT date, petrol, diesel FROM rates WHERE date BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", rates_dgv);
        }
    }
}
