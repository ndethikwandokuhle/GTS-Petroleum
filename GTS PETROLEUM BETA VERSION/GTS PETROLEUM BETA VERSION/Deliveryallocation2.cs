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
    public partial class Deliveryallocation2 : Form
    {
        public Deliveryallocation2()
        {
            InitializeComponent();
        }

        private void Deliveryallocation2_Load(object sender, EventArgs e)
        {
            DbConn.DisplayAndSearch("SELECT ID, deliverydate, invoiceno, dnoteno, t1beforeqty, t1afterqty, t1movement, t2beforeqty, t2afterqty, t2movement FROM deliveries", deliveries_gdv);
        }
    }
}
