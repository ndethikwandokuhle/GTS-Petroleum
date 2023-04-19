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
    public partial class GetstartedRates : UserControl
    {
        public static GetstartedRates instance;
        public decimal petrolprice;
        public decimal dieselprice;
        public GetstartedRates()
        {
            InitializeComponent();
            instance = this;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if ((petrol.Value < 0) && (diesel.Value < 0))
                MessageBox.Show("Rates are pegged to start from USD1", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                petrolprice = petrol.Value;
                dieselprice = diesel.Value;
                New_system.instance.Fromrates();
            }
                
        }
    }
}
