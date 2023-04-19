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
    public partial class ReportDeliveries : Form
    {
        public ReportDeliveries()
        {
            InitializeComponent();
        }

        private void ReportDeliveries_Load(object sender, EventArgs e)
        {
            DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier, driver, lorryno,invoiceno, dnoteno, dnoteqty, lorryqty, comments, lorryvar, t1received, t2received, qtyreceived, variation FROM deliveries", deliveries_gdv);
        }

        private void report_Click(object sender, EventArgs e)
        {
            Loadtables();
        }

        public void Loadtables()
        {
            if (fueltype_cbx.SelectedIndex == 0)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier, driver, lorryno,invoiceno, dnoteno, dnoteqty, lorryqty, comments, lorryvar, t1received, t2received, qtyreceived, variation FROM deliveries WHERE deliverydate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", deliveries_gdv);
            }
            else if (fueltype_cbx.SelectedIndex == 1)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string fueltank1 = "Petrol";
                DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier, driver, lorryno,invoiceno, dnoteno, dnoteqty, lorryqty, comments, lorryvar, t1received, t2received, qtyreceived, variation FROM deliveries WHERE fueltype LIKE '" + fueltank1 + "' AND deliverydate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", deliveries_gdv);
            }
            else if (fueltype_cbx.SelectedIndex == 2)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string fueltank1 = "Diesel";
                DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier, driver, lorryno,invoiceno, dnoteno, dnoteqty, lorryqty, comments, lorryvar, t1received, t2received, qtyreceived, variation FROM deliveries WHERE fueltype LIKE '" + fueltank1 + "' AND deliverydate BETWEEN CAST('" + date1 + "' AS DATE) AND CAST('" + date2 + "' AS DATE)", deliveries_gdv);
            }

        }
    }
}
