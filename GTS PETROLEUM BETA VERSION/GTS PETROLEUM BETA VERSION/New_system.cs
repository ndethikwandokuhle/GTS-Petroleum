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
    public partial class New_system : Form
    {
        public static New_system instance;
        public void Fromwelcome()
        {
            welcome_btn.Image = Properties.Resources.check_mark;
            station_btn.Enabled = true;
            getstartedStation1.BringToFront();
        }
        public void Fromstation()
        {
            station_btn.Image = Properties.Resources.check_mark;
            dip_btn.Enabled = true;
            getstartedDipreading1.BringToFront();
        }
        public void Fromdip()
        {
            dip_btn.Image = Properties.Resources.check_mark;
            meter_btn.Enabled = true;
            getstartedMeterreading1.BringToFront();
        }
        public void Frommeter()
        {
            meter_btn.Image = Properties.Resources.check_mark;
            rates_btn.Enabled = true;
            getstartedRates1.BringToFront();
        }
        public void Fromrates()
        {
            rates_btn.Image = Properties.Resources.check_mark;
            staff_btn.Enabled = true;
            getstartedStaff1.BringToFront();
        }
        public void Fromstaff()
        {
            staff_btn.Image = Properties.Resources.check_mark;
            finish_btn.Enabled = true;
            getstartedFinish1.BringToFront();
        }
        public void Fromfinish()
        {
            finish_btn.Image = Properties.Resources.check_mark;

        }
        public New_system()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getstartedStation1.BringToFront();
        }

        private void New_system_Load(object sender, EventArgs e)
        {
            getstartedWelcome1.BringToFront();
        }

        private void welcome_btn_Click(object sender, EventArgs e)
        {
            getstartedWelcome1.BringToFront();
        }

        private void dip_btn_Click(object sender, EventArgs e)
        {
            getstartedDipreading1.BringToFront();
            instance.Fromstation();
        }

        private void meter_btn_Click(object sender, EventArgs e)
        {
            getstartedMeterreading1.BringToFront();
            instance.Fromdip();
        }

        private void rates_btn_Click(object sender, EventArgs e)
        {
            getstartedRates1.BringToFront();
            instance.Frommeter();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            getstartedStaff1.BringToFront();
            instance.Fromrates();
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            getstartedFinish1.BringToFront();
            instance.Fromstaff();
        }

        public void Callmeonclosing()
        {
            Splashscreen.instance.Callmeonclosing();
            this.Close();
        }
    }
}
