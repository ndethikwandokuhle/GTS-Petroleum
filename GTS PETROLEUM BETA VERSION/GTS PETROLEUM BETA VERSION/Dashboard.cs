using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class Dashboard : Form
    {
        public static Dashboard instance;
        public string station;
        public string fullname;
        public string position;
        public string tables = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nBottomRect,
            int nRightRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public void Loadtables()
        {
            string p1 = "Petrol_1";
            string p2 = "Petrol_2";
            string d1 = "Diesel_1";
            string d2 = "Diesel_2";
            //MessageBox.Show("Dashboard was called");
            DbConn.DisplayAndSearch("SELECT closediplitres FROM reading WHERE tankname LIKE '%" + p1 + "%' ORDER BY id DESC LIMIT 1", p1_dgv);
            DbConn.DisplayAndSearch("SELECT closediplitres FROM reading WHERE tankname LIKE '%" + p2 + "%' ORDER BY id DESC LIMIT 1", p2_dgv);
            DbConn.DisplayAndSearch("SELECT closediplitres FROM reading WHERE tankname LIKE '%" + d1 + "%' ORDER BY id DESC LIMIT 1", d1_dgv);
            DbConn.DisplayAndSearch("SELECT closediplitres FROM reading WHERE tankname LIKE '%" + d2 + "%' ORDER BY id DESC LIMIT 1", d2_dgv);

            decimal petrol1 = 0;
            decimal petrol2 = 0;
            decimal diesel1 = 0;
            decimal diesel2 = 0;
            if (p1_dgv.Rows.Count > 0)
                petrol1 = decimal.Parse(p1_dgv.Rows[0].Cells[0].Value.ToString());
            if (p2_dgv.Rows.Count > 0)
                petrol2 = decimal.Parse(p2_dgv.Rows[0].Cells[0].Value.ToString());
            if (d1_dgv.Rows.Count > 0)
                diesel1 = decimal.Parse(d1_dgv.Rows[0].Cells[0].Value.ToString());
            if (d2_dgv.Rows.Count > 0)
                diesel2 = decimal.Parse(d2_dgv.Rows[0].Cells[0].Value.ToString()); 

            decimal grosspetrol = petrol1 + petrol2;
            decimal grossdiesel = diesel1 + diesel2;

            label6.Text = grosspetrol.ToString();
            label7.Text = grossdiesel.ToString();
            //accountancy


            //calculating prepaid fuel quantities
            string prepaidtype = "Pre-paid";
            string pet = "Petrol";
            string die = "Diesel";
            string depo = "Deposit";
            string refu = "Refuel";
            DbConn.DisplayAndSearch("SELECT petrolbuy FROM transaction WHERE acctype LIKE '%" + prepaidtype + "%' AND fueltype LIKE '%" + pet + "%' AND transtype LIKE '%" + depo + "%'", prepaidpetrolbal_dgv);
            DbConn.DisplayAndSearch("SELECT qty FROM transaction WHERE acctype LIKE '%" + prepaidtype + "%' AND fueltype LIKE '%" + pet + "%' AND transtype LIKE '%" + refu + "%'", petrolqty_dgv);

            DbConn.DisplayAndSearch("SELECT dieselbuy FROM transaction WHERE acctype LIKE '%" + prepaidtype + "%' AND fueltype LIKE '%" + die + "%' AND transtype  LIKE '%" + depo + "%'", prepaiddieselbal_dgv);
            DbConn.DisplayAndSearch("SELECT qty FROM transaction WHERE acctype LIKE '%" + prepaidtype + "%' AND fueltype LIKE '%" + die + "%' AND transtype  LIKE '%" + refu + "%'", dieselqty_dgv);

            //******************************check petrol
            decimal boughtpetrol = 0;
            decimal usedpetrol = 0;
            if(prepaidpetrolbal_dgv.Rows.Count>0)
            {
                for (int i = 0; i < prepaidpetrolbal_dgv.Rows.Count; i++)
                {
                    boughtpetrol = (boughtpetrol + decimal.Parse(prepaidpetrolbal_dgv.Rows[i].Cells[0].Value.ToString()));
                }
            }

            if (petrolqty_dgv.Rows.Count > 0)
            {
                for (int i = 0; i < petrolqty_dgv.Rows.Count; i++)
                {
                    usedpetrol = (usedpetrol + decimal.Parse(petrolqty_dgv.Rows[i].Cells[0].Value.ToString()));
                }
            }
            
            decimal prepaidpetrolbalance = boughtpetrol - usedpetrol;
            label11.Text = prepaidpetrolbalance.ToString();

            //*******************************check diesel
            decimal boughtdiesel = 0;
            decimal useddiesel = 0;
            if (prepaiddieselbal_dgv.Rows.Count > 0)
            {
                for (int i = 0; i < prepaiddieselbal_dgv.Rows.Count; i++)
                {
                   boughtdiesel = (boughtdiesel + decimal.Parse(prepaiddieselbal_dgv.Rows[i].Cells[0].Value.ToString()));
                }
            }

            if (dieselqty_dgv.Rows.Count > 0)
            { 
                for (int i = 0; i < dieselqty_dgv.Rows.Count; i++)
                {
                    useddiesel = (useddiesel + decimal.Parse(dieselqty_dgv.Rows[i].Cells[0].Value.ToString()));
                }
            }

               
            decimal prepaiddieselbalance = boughtdiesel- useddiesel;
            label8.Text = prepaiddieselbalance.ToString();

            label17.Text = (decimal.Parse(label6.Text) - decimal.Parse(label11.Text)).ToString();
            label14.Text = (decimal.Parse(label7.Text) - decimal.Parse(label8.Text)).ToString();
        }
        public Dashboard()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            instance = this;
        }

        private void sidebar_panel_MouseEnter(object sender, EventArgs e)
        {
            //StartSlide();
        }

        private void sidebar_panel_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void maintanence_btn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "HOME";
            controlHome1.Show();
            controlHome1.BringToFront();

            controlDeliveries1.Hide();
            controlSales1.Hide();
            controlReading1.Hide();
            controlLedger1.Hide();
            controlAccount1.Hide();
            controlReports1.Hide();
        }

        private void delivery_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "FUEL DELIVERIES";
            controlDeliveries1.Show();
            controlDeliveries1.BringToFront();

            controlHome1.Hide();
            controlSales1.Hide();
            controlReading1.Hide();
            controlLedger1.Hide();
            controlAccount1.Hide();
            controlReports1.Hide();
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "FUEL SALES";
            controlSales1.Show();
            controlSales1.BringToFront();

            controlHome1.Hide();
            controlDeliveries1.Hide();
            controlReading1.Hide();
            controlLedger1.Hide();
            controlAccount1.Hide();
            controlReports1.Hide();
        }

        private void reading_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "TANK DIP-READINGS";
            controlReading1.Show();
            controlReading1.BringToFront();

            controlHome1.Hide();
            controlDeliveries1.Hide();
            controlSales1.Hide();
            controlLedger1.Hide();
            controlAccount1.Hide();
            controlReports1.Hide();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "PERSONAL ACCOUNTS";
            controlAccount1.Show();
            controlAccount1.BringToFront();

            controlHome1.Hide();
            controlDeliveries1.Hide();
            controlSales1.Hide();
            controlLedger1.Hide();
            controlReading1.Hide();
            controlReports1.Hide();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "VIEW REPORTS";
            controlReports1.Show();
            controlReports1.BringToFront();

            controlHome1.Hide();
            controlDeliveries1.Hide();
            controlSales1.Hide();
            controlLedger1.Hide();
            controlReading1.Hide();
            controlAccount1.Hide();
        }

        private void maintanence_btn_Click(object sender, EventArgs e)
        {
            Maintenance mnt = new Maintenance();
            mnt.ShowDialog();
        }

        private void ledger_btn_Click(object sender, EventArgs e)
        {
            header_lbl.Text = "General Ledger Recordings";
            controlLedger1.Show();
            controlLedger1.BringToFront();

            controlHome1.Hide();
            controlDeliveries1.Hide();
            controlSales1.Hide();
            controlReports1.Hide();
            controlReading1.Hide();
            controlAccount1.Hide();

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit application?  \r\nClick YES to proceed?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                station ="";
                fullname="";
                position="";
                this.Close();
            }
        }

        private void home_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void delivery_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void sale_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void reading_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void account_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void report_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void maintanence_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void about_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void ledger_btn_MouseLeave(object sender, EventArgs e)
        {
            //EndSlide();
        }

        private void ledger_btn_MouseEnter(object sender, EventArgs e)
        {
            //StartSlide();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Loadtables();
            //Small();
            header_lbl.Text = "HOME";
            controlHome1.Show();
            controlHome1.BringToFront();

            controlDeliveries1.Hide();
            controlSales1.Hide();
            controlReading1.Hide();
            controlLedger1.Hide();
            controlAccount1.Hide();
            controlReports1.Hide();

            //Login.instance.Assignnames();

            string fullname = Login.instance.fullname;
            string position = Login.instance.position;


            station_lbl.Text = Splashscreen.instance.station;
            position_lbl.Text = fullname;
            username_lbl.Text = position;
        }

        private void messanger_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notes_lbl_Click(object sender, EventArgs e)
        {
            //messanger_pnl.Visible = true;
            timer3.Start();
        }

        private void kwandoPanelComponent5_Paint(object sender, PaintEventArgs e)
        {
            //notes red oval
            //messanger_pnl.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (messanger_pnl.Width < 320)
            {
                messanger_pnl.Width += 20;
            }
            else
                timer3.Stop();
        }

        private void closesnotes_btn_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            messanger_pnl.Width = 0;
        }

        private void report_btn_Click_1(object sender, EventArgs e)
        {
            header_lbl.Text = "VIEW REPORTS";
            ReportsSelection rs = new ReportsSelection();
            rs.ShowDialog();
        }

        private void maintanence_btn_Click_1(object sender, EventArgs e)
        {
            Maintenance mnt = new Maintenance();
            mnt.ShowDialog();
        }
    }
}
