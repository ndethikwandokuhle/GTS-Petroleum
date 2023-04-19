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
    public partial class GetstartedStation : UserControl
    {
        public static GetstartedStation instance;
        public string station;
        public GetstartedStation()
        {
            InitializeComponent();
            instance = this;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (station_cbx.Text == "")
                MessageBox.Show("Station cannot be empty. Select your station from the Combobox Dropdown", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                station = station_cbx.Text;
                New_system.instance.Fromstation();
            }
                
        }

    }
}
