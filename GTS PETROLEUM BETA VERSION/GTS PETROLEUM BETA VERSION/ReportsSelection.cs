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
    public partial class ReportsSelection : Form
    {
        public ReportsSelection()
        {
            InitializeComponent();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            ReportSales rs = new ReportSales();
            rs.ShowDialog();
        }

        private void deliveries_btn_Click(object sender, EventArgs e)
        {
            ReportDeliveries rd = new ReportDeliveries();
            rd.ShowDialog();
        }

        private void readings_btn_Click(object sender, EventArgs e)
        {
            ReportReadings rr = new ReportReadings();
            rr.ShowDialog();
        }

        private void attendants_btn_Click(object sender, EventArgs e)
        {
            ReportAttendants ra = new ReportAttendants();
            ra.ShowDialog();
        }

        private void accounts_btn_Click(object sender, EventArgs e)
        {
            ReportAccounts ra = new ReportAccounts();
            ra.ShowDialog();
        }

        private void ledger_btn_Click(object sender, EventArgs e)
        {
            ReportLedger rl = new ReportLedger();
            rl.ShowDialog();
        }

        private void rates_btn_Click(object sender, EventArgs e)
        {
            ReportRates rr = new ReportRates();
            rr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportMore rm = new ReportMore();
            rm.ShowDialog();
        }
    }
}
