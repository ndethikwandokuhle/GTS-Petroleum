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
    public partial class Getstartedalldata : Form
    {
        public Getstartedalldata()
        {
            InitializeComponent();
        }

        private void Getstartedalldata_Load(object sender, EventArgs e)
        {
            station_lbl.Text = GetstartedStation.instance.station;
            if(station_lbl.Text == "GTS Mberengwa Consolidated")
            {
                panel3.Visible = panel4.Visible = panel7.Visible = panel8.Visible = panel10.Visible = false;
                panel5.BackColor = Color.Silver;
                panel9.BackColor = Color.White;
            }

            fullname.Text = GetstartedStaff.instance.fullname;
            DateTime dob = GetstartedStaff.instance.dateofbirth;
            dateofbirth.Text = dob.ToString().Substring(0,9);
            sex.Text = GetstartedStaff.instance.sex;
            position.Text = GetstartedStaff.instance.position;
            idnumber.Text = GetstartedStaff.instance.idnumber;
            phone.Text = GetstartedStaff.instance.phone;
            email.Text = GetstartedStaff.instance.email;

            decimal p = GetstartedRates.instance.petrolprice;
            petrol.Text = p.ToString();
            decimal d = GetstartedRates.instance.dieselprice;
            diesel.Text = d.ToString();

            decimal p1p1a = GetstartedMeterreading.instance.petrol_1pump1a;
            decimal p1p1b = GetstartedMeterreading.instance.petrol_1pump1b;
            decimal p2p1a = GetstartedMeterreading.instance.petrol_2pump1a;
            decimal p2p1b = GetstartedMeterreading.instance.petrol_2pump1b;
            decimal d1p1a = GetstartedMeterreading.instance.diesel_1pump1a;
            decimal d1p1b = GetstartedMeterreading.instance.diesel_1pump1b;
            decimal d2p1a = GetstartedMeterreading.instance.diesel_2pump1a;
            decimal d2p1b = GetstartedMeterreading.instance.diesel_2pump1b;
            decimal d2p2a = GetstartedMeterreading.instance.diesel_2pump2a;
            decimal d2p2b = GetstartedMeterreading.instance.diesel_2pump2b;
            p1p1a_lbl.Text = p1p1a.ToString();
            p1p1b_lbl.Text = p1p1b.ToString();
            p2p1a_lbl.Text = p2p1a.ToString();
            p2p1b_lbl.Text = p2p1b.ToString();
            d1p1a_lbl.Text = d1p1a.ToString();
            d1p1b_lbl.Text = d1p1b.ToString();
            d2p1a_lbl.Text = d2p1a.ToString();
            d2p1b_lbl.Text = d2p1b.ToString();
            d2p2a_lbl.Text = d2p2a.ToString();
            d2p2b_lbl.Text = d2p2b.ToString();


            decimal p1m = GetstartedDipreading.instance.petrol_1meter;
            decimal p2m = GetstartedDipreading.instance.petrol_1litre;
            decimal p1l = GetstartedDipreading.instance.petrol_2meter;
            decimal p2l = GetstartedDipreading.instance.petrol_2litre;
            decimal d1m = GetstartedDipreading.instance.diesel_1meter;
            decimal d2m = GetstartedDipreading.instance.diesel_1litre;
            decimal d1l = GetstartedDipreading.instance.diesel_2meter;
            decimal d2l = GetstartedDipreading.instance.diesel_2litre;
            p1meter.Text = p1m.ToString();
            p1qty.Text = p1l.ToString();
            p2meter.Text = p2m.ToString();
            p2qty.Text = p2l.ToString();
            d1meter.Text = d1m.ToString();
            d1qty.Text = d1l.ToString();
            d2meter.Text = d2m.ToString();
            d2qty.Text = d2l.ToString();
        }
    }
}
