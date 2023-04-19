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
    public partial class ReportAccounts : Form
    {
        public ReportAccounts()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
        }

        private void ReportAccounts_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
            DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction", transactions_gdv);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
        }

        private void report_Click(object sender, EventArgs e)
        {
            string petrol = "Petrol";
            string diesel = "Diesel";
            string prepaid = "Pre-paid";
            string postpaid = "Post-paid";
            if (fueltype_cbx.SelectedIndex == 0)
            {
                if(accounts_cbx.SelectedIndex == 0)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
                else if (accounts_cbx.SelectedIndex == 1)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE acctype LIKE '" + prepaid + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
                else if (accounts_cbx.SelectedIndex == 2)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE acctype LIKE '" + postpaid + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
            }
            else if (fueltype_cbx.SelectedIndex == 1)
            {
                if (accounts_cbx.SelectedIndex == 0)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE fueltype LIKE '" + petrol + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
                else if (accounts_cbx.SelectedIndex == 1)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE fueltype LIKE '" + petrol + "' AND acctype LIKE '" + prepaid + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
                else if (accounts_cbx.SelectedIndex == 2)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE fueltype LIKE '" + petrol + "' AND acctype LIKE '" + postpaid + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
            }
            else if (fueltype_cbx.SelectedIndex == 2)
            {
                if (accounts_cbx.SelectedIndex == 0)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE fueltype LIKE '" + diesel + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
                else if (accounts_cbx.SelectedIndex == 1)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE fueltype LIKE '" + diesel + "' AND acctype LIKE '" + prepaid + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
                else if (accounts_cbx.SelectedIndex == 2)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, qty, discounted, discount, discountedtotal, petrolbuy, dieselbuy FROM transaction WHERE fueltype LIKE '" + diesel + "' AND acctype LIKE '" + postpaid + "' AND transdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", transactions_gdv);
                }
            }


        }

        private void accounts_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
