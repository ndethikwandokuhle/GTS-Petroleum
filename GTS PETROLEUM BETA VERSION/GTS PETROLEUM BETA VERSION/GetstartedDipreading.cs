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
    public partial class GetstartedDipreading : UserControl
    {
        public static GetstartedDipreading instance;
        public decimal petrol_1meter;
        public decimal petrol_1litre;
        public decimal petrol_2meter;
        public decimal petrol_2litre;
        public decimal diesel_1meter;
        public decimal diesel_1litre;
        public decimal diesel_2meter;
        public decimal diesel_2litre;


        public GetstartedDipreading()
        {
            InitializeComponent();
            instance = this;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (((p1meter.Value < 1) && (p2meter.Value < 1)) || ((d1meter.Value < 1) && (d2meter.Value < 1)))
                MessageBox.Show("Some tank dip-meters are set to zero. Are you sure this is correct.", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (((p1qty.Value < 10) && (p2qty.Value < 10)) || ((d1qty.Value < 10) && (d2qty.Value < 10)))
                MessageBox.Show("Some tank dip-quantity values are set to less than 10Litres. Are you sure this is correct.", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                petrol_1meter = p1meter.Value;
                petrol_1litre = p1qty.Value;
                petrol_2meter = p2meter.Value;
                petrol_2litre = p2qty.Value;
                diesel_1meter = d1meter.Value;
                diesel_1litre = d1qty.Value;
                diesel_2meter = d2meter.Value;
                diesel_2litre = d2qty.Value; 
                New_system.instance.Fromdip();
            }
                
        }

        private void GetstartedDipreading_Load(object sender, EventArgs e)
        {
            
        }

        private void Disablepanels()
        {
            string station = GetstartedStation.instance.station;
            if (station == "GTS Mberengwa Consolidated")
            {
                panel5.Enabled = panel8.Enabled = false;
                p2meter.Value = p2qty.Value = d2meter.Value = d2qty.Value = 0;
            }
            else
                panel5.Enabled = panel8.Enabled = true;
        }

        private void p1meter_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void p1qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void p2meter_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void p2qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d1meter_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d1qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d2meter_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }

        private void d2qty_ValueChanged(object sender, EventArgs e)
        {
            Disablepanels();
        }
    }
}
