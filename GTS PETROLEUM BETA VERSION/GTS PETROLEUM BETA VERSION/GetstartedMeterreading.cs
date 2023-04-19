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
    public partial class GetstartedMeterreading : UserControl
    {
        public static GetstartedMeterreading instance;
        public decimal petrol_1pump1a;
        public decimal petrol_1pump1b;
        public decimal petrol_2pump1a;
        public decimal petrol_2pump1b;
        public decimal diesel_1pump1a;
        public decimal diesel_1pump1b;
        public decimal diesel_2pump1a;
        public decimal diesel_2pump1b;
        public decimal diesel_2pump2a;
        public decimal diesel_2pump2b;
        public GetstartedMeterreading()
        {
            InitializeComponent();
            instance = this;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (((p1p1a.Value < 10) && (p2p1a.Value < 10)) || ((d1p1a.Value < 10) && (d2p1a.Value < 10))|| ((p1p1b.Value < 10) && (p2p1b.Value < 10)) || ((d1p1b.Value < 10) && (d2p1b.Value < 10)))
                MessageBox.Show("Some tank dip-quantity values are set to less than 10Litres. Are you sure this is correct.", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                petrol_1pump1a = p1p1a.Value;
                petrol_1pump1b = p1p1b.Value;
                petrol_2pump1a = p2p1a.Value;
                petrol_2pump1b = p2p1b.Value;
                diesel_1pump1a = d1p1a.Value;
                diesel_1pump1b = d1p1b.Value;
                diesel_2pump1a = d2p1a.Value;
                diesel_2pump1b = d2p1b.Value;
                diesel_2pump2a = d2p2a.Value;
                diesel_2pump2b = d2p2b.Value;
                New_system.instance.Frommeter();
            }
                
        }

        private void GetstartedMeterreading_Load(object sender, EventArgs e)
        {

        }
        private void Disablepanels()
        {
            string station = GetstartedStation.instance.station;
            if (station == "GTS Mberengwa Consolidated")
            {
                panel5.Enabled = panel8.Enabled = panel23.Enabled = false;
                p2p1a.Value = d2p1a.Value = d2p2a.Value = 0;
                p2p1b.Value = d2p1b.Value = d2p2b.Value = 0;
            }
            else
                panel5.Enabled = panel8.Enabled = true;
        }
        private void p1p1qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void p2p1qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d1p1qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d2p1qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d2p2qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }
    }
}
