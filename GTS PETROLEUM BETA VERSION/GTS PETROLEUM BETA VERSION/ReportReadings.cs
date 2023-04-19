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
    public partial class ReportReadings : Form
    {
        public ReportReadings()
        {
            InitializeComponent();
        }

        private void fueltype_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fueltype_cbx.SelectedIndex == 0)
            {
                comboBox1.Enabled = false;
                //comboBox1.SelectedIndex = 0;
            }
            else if (fueltype_cbx.SelectedIndex == 1)
            {
                comboBox1.Enabled = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Petrol");
                comboBox1.Items.Add("Diesel");
            }
            else if (fueltype_cbx.SelectedIndex == 2)
            {
                comboBox1.Enabled = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Petrol_1");
                comboBox1.Items.Add("Petrol_2");
                comboBox1.Items.Add("Diesel_1");
                comboBox1.Items.Add("Diesel_2");
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string petrol ="Petrol_1";
            string petrol1 ="Petrol_2";
            string diesel ="Diesel_1";
            string diesel1 ="Diesel_2";
            //DbConn.DisplayAndSearch("SELECT  date, tankname, pumpname, dipquantity, sideaopen, sideaclose, sideasale, sidebopen, sidebclose, sidebsale, totalsales, amount, dipopenm, dipclosem, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, supervisor, attendant FROM sales WHERE tankname LIKE '"+ fueltank1 + "' OR tankname LIKE '" + fueltank2 + "' AND date BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", sales_gdv);
            if (fueltype_cbx.SelectedIndex == 0)
            {
                DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading WHERE readingdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", reading_gdv);
            }
            else if (fueltype_cbx.SelectedIndex == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                    DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading WHERE tankname LIKE '" + petrol + "' OR tankname LIKE '" + petrol1 + "' AND readingdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", reading_gdv);
                else if (comboBox1.SelectedIndex == 1)
                    DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading WHERE tankname LIKE '" + diesel + "' OR tankname LIKE '" + diesel1 + "' AND readingdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", reading_gdv);
                else
                    MessageBox.Show("Filter by fueltype selected.  \r\nFueltype not selected.", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fueltype_cbx.SelectedIndex == 2)
            {
                DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading WHERE tankname LIKE '" + comboBox1.Text + "' AND readingdate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", reading_gdv);
            }
        }

        private void ReportReadings_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
            label3.Text = dateTimePicker2.Value.ToString().Substring(0, 9);
            DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading", reading_gdv);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
