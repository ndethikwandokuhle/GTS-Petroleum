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
    public partial class Salesflow : Form
    {
        public static Salesflow instance;
        public decimal xcashsale;
        public decimal xprepaid;
        public decimal xpostpaid;
        public Salesflow()
        {
            InitializeComponent();
            instance = this;
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(label5.Text);
            decimal sum = cashvalue.Value + prepaidvalue.Value + postpaidvalue.Value;

            if(total == sum)
            {
                xcashsale = cashvalue.Value;
                xprepaid = prepaidvalue.Value;
                xpostpaid = postpaidvalue.Value;

                ControlSales.instance.Salesflows();
                this.Close();
            }
            else
                MessageBox.Show("Sum of sales breakdown does not tally with total sales figure. \r\n Total Sales: "+total+ "\r\n Breakdown Sales Total: "+sum, "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Salesflow_Load(object sender, EventArgs e)
        {
            label5.Text = ControlSales.instance.totallitres;
        }
    }
}
