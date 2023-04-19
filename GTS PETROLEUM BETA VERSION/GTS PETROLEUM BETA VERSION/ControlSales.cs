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
    public partial class ControlSales : UserControl
    {
        public static ControlSales instance;
        public string activeuser;
        public string mynid;
        public ControlSales()
        {
            InitializeComponent();
            instance = this;
        }

        int verificationcode;
        private void Clear()
        {
            tankname.SelectedIndex = pumpname.SelectedIndex = 0;
            cashSubmitted.Value = sideaclose.Value = sidebclose.Value = 0;
            sideaopen.Text = sideasale.Text = sidebopen.Text = sidebsale.Text = totalsales.Text = amount.Text = pumpstock.Text = variation.Text = cashshort.Text = cashtotal.Text = "0.00";
        }

        string station = "";
        private void save_btn_Click(object sender, EventArgs e)
        {
            
            //if(verifycode_txt.Text == verificationcode.ToString())
            //{
            if ((sideaclose.Value < decimal.Parse(sideaopen.Text)) || (sidebclose.Value < decimal.Parse(sidebopen.Text)))
                MessageBox.Show("Closing meter reading cannot be less than opening meter reading.  \r\nProvide accurate data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                mynid = label63.Text;
                activeuser = label58.Text;
                VerifySale VS = new VerifySale();
                VS.ShowDialog();
            }
            //}
            //else
            //    MessageBox.Show("Verification code provided is invalid. \r\nProvide accurate code and try again?", "VERIFICATION FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Savedata()
        {
            Saveprofile();
        }


        private void Saveprofile()
        {
            DateTime mydate = DateTime.Now;
            station = Splashscreen.instance.station;
            decimal settled = 0;
            SaleProfile std = new SaleProfile(mydate, label58.Text.Trim(), supervisor_cbx.Text.Trim(), label60.Text.Trim(), label63.Text.Trim(), decimal.Parse(label65.Text), decimal.Parse(label19.Text), settled, station);
            DbConn.AddSaleProfile(std);
            Savesale();
        }



        decimal petrol;
        decimal diesel;
        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT petrol, diesel FROM rates ORDER BY id DESC LIMIT 1", rates_dgv);
            if (rates_dgv.Rows.Count > 0)
            {
                petrol = decimal.Parse(rates_dgv.Rows[0].Cells[0].Value.ToString());
                diesel = decimal.Parse(rates_dgv.Rows[0].Cells[1].Value.ToString());
            }
            
            pprice.Text = petrol.ToString();
            dprice.Text = diesel.ToString();


        }

        private void ControlSales_Load(object sender, EventArgs e)
        {
            pumpname.Enabled = false;
            string myposition = "Attendant";
            //string myotherposition = "Supervisor";
            Loadtables();
            DbConn.DisplayAndSearch("SELECT email FROM employee WHERE position LIKE '%" + myposition + "%'", attend_dgv);
            DbConn.DisplayAndSearch("SELECT fullname FROM users", super_dgv);

            foreach (DataGridViewRow row in attend_dgv.Rows)
            {
                attendant_cbx.Items.Add(row.Cells[0].Value);
            }
            foreach (DataGridViewRow row in super_dgv.Rows)
            {
                supervisor_cbx.Items.Add(row.Cells[0].Value);
            }
        }

        private void Changetank()
        {
            dipopenm.Text = "0.00";
            dipopenl.Text = "0.00";
            dipclosem.Text = "0.00";
            dipclosel.Text = "0.00";
            dipmovement.Text = "0.00";
            openinglitres.Text = dipopenl.Text;
            pumpname.SelectedIndex = 0;
            printsales_pnl.Enabled = false;
        }


        string tanknameactive = "";
        private void tankname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changetank();
            if (tankname.SelectedIndex == 0)
            {
                printsales_pnl.Enabled = false;
                MessageBox.Show("No tank has been selected.", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tankname.SelectedIndex == 1)
            {
                tanknameactive = "Petrol_1";
                DbConn.DisplayAndSearch("SELECT ID, readingdate, autoopenmeters, autoopenlitres, closedipmeters, closediplitres, movementlitres FROM reading  WHERE tankname LIKE '%" + tanknameactive + "%' ORDER BY id DESC LIMIT 1", readings_dgv);
                if (readings_dgv.Rows.Count > 0)
                {
                    string dbdate = readings_dgv.Rows[0].Cells[1].Value.ToString().Substring(0, 9);
                    string namhla = date.Value.ToString().Substring(0, 9);
                    if (dbdate == namhla)
                    {
                        dipopenm.Text = readings_dgv.Rows[0].Cells[2].Value.ToString();
                        dipopenl.Text = readings_dgv.Rows[0].Cells[3].Value.ToString();
                        dipclosem.Text = readings_dgv.Rows[0].Cells[4].Value.ToString();
                        dipclosel.Text = readings_dgv.Rows[0].Cells[5].Value.ToString();
                        dipmovement.Text = readings_dgv.Rows[0].Cells[6].Value.ToString();
                        openinglitres.Text = dipopenl.Text;
                        pumpname.Enabled = true;
                        sideaclose.Value = decimal.Parse(sideaopen.Text);
                        sidebclose.Value = decimal.Parse(sidebopen.Text);
                    }
                    else
                    {
                        printsales_pnl.Enabled = false;
                        MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pumpname.Enabled = false;
                        Clear();
                    }
                }
                else
                {
                    printsales_pnl.Enabled = false;
                    pumpname.Enabled = false;
                    MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tankname.SelectedIndex == 2)
            {
                //readings_dgv.Rows.Clear();
                tanknameactive = "Petrol_2";
                DbConn.DisplayAndSearch("SELECT ID, readingdate, autoopenmeters, autoopenlitres, closedipmeters, closediplitres, movementlitres FROM reading  WHERE tankname LIKE '%" + tanknameactive + "%' ORDER BY id DESC LIMIT 1", p2_dgv);
                if (p2_dgv.Rows.Count > 0)
                {
                    string dbdate = p2_dgv.Rows[0].Cells[1].Value.ToString().Substring(0, 9);
                    string namhla = date.Value.ToString().Substring(0, 9);
                    if (dbdate == namhla)
                    {
                        dipopenm.Text = p2_dgv.Rows[0].Cells[2].Value.ToString();
                        dipopenl.Text = p2_dgv.Rows[0].Cells[3].Value.ToString();
                        dipclosem.Text = p2_dgv.Rows[0].Cells[4].Value.ToString();
                        dipclosel.Text = p2_dgv.Rows[0].Cells[5].Value.ToString();
                        dipmovement.Text = p2_dgv.Rows[0].Cells[6].Value.ToString();
                        openinglitres.Text = dipopenl.Text;
                        pumpname.Enabled = true;
                        sideaclose.Value = decimal.Parse(sideaopen.Text);
                        sidebclose.Value = decimal.Parse(sidebopen.Text);
                    }
                    else
                    {
                        printsales_pnl.Enabled = false;
                        MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pumpname.Enabled = false;
                    }
                }
                else
                {
                    pumpname.Enabled = false;
                    MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    printsales_pnl.Enabled = false;
                    Clear();
                }
            }
            else if (tankname.SelectedIndex == 3)
            {
                //readings_dgv.Rows.Clear();
                tanknameactive = "Diesel_1";
                DbConn.DisplayAndSearch("SELECT ID, readingdate, autoopenmeters, autoopenlitres, closedipmeters, closediplitres, movementlitres FROM reading  WHERE tankname LIKE '%" + tanknameactive + "%' ORDER BY id DESC LIMIT 1", d1_dgv);
                if (d1_dgv.Rows.Count > 0)
                {
                    string dbdate = d1_dgv.Rows[0].Cells[1].Value.ToString().Substring(0, 9);
                    string namhla = date.Value.ToString().Substring(0, 9);
                    if (dbdate == namhla)
                    {
                        dipopenm.Text = d1_dgv.Rows[0].Cells[2].Value.ToString();
                        dipopenl.Text = d1_dgv.Rows[0].Cells[3].Value.ToString();
                        dipclosem.Text = d1_dgv.Rows[0].Cells[4].Value.ToString();
                        dipclosel.Text = d1_dgv.Rows[0].Cells[5].Value.ToString();
                        dipmovement.Text = d1_dgv.Rows[0].Cells[6].Value.ToString();
                        openinglitres.Text = dipopenl.Text;
                        pumpname.Enabled = true;
                        sideaclose.Value = decimal.Parse(sideaopen.Text);
                        sidebclose.Value = decimal.Parse(sidebopen.Text);
                    }
                    else
                    {
                        printsales_pnl.Enabled = false;
                        MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pumpname.Enabled = false;
                    }
                }
                else
                {
                    pumpname.Enabled = false;
                    MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    printsales_pnl.Enabled = false;
                    Clear();
                }
            }
            else if (tankname.SelectedIndex == 4)
            {
                //readings_dgv.Rows.Clear();
                tanknameactive = "Diesel_2";
                DbConn.DisplayAndSearch("SELECT ID, readingdate, autoopenmeters, autoopenlitres, closedipmeters, closediplitres, movementlitres FROM reading  WHERE tankname LIKE '%" + tanknameactive + "%' ORDER BY id DESC LIMIT 1", d2_dgv);
                if (d2_dgv.Rows.Count > 0)
                {
                    string dbdate = d2_dgv.Rows[0].Cells[1].Value.ToString().Substring(0, 9);
                    string namhla = date.Value.ToString().Substring(0, 9);
                    if (dbdate == namhla)
                    {
                        dipopenm.Text = d2_dgv.Rows[0].Cells[2].Value.ToString();
                        dipopenl.Text = d2_dgv.Rows[0].Cells[3].Value.ToString();
                        dipclosem.Text = d2_dgv.Rows[0].Cells[4].Value.ToString();
                        dipclosel.Text = d2_dgv.Rows[0].Cells[5].Value.ToString();
                        dipmovement.Text = d2_dgv.Rows[0].Cells[6].Value.ToString();
                        openinglitres.Text = dipopenl.Text;
                        pumpname.Enabled = true;
                        sideaclose.Value = decimal.Parse(sideaopen.Text);
                        sidebclose.Value = decimal.Parse(sidebopen.Text);
                    }
                    else
                    {
                        printsales_pnl.Enabled = false;
                        MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pumpname.Enabled = false;
                    }
                }
                else
                {
                    pumpname.Enabled = false;
                    MessageBox.Show("No dip readings where found for this tank.  \r\nEnter dip readings and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    printsales_pnl.Enabled = false;
                    Clear();
                }
                    
            }
        }



        private void pumpname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((pumpname.Text == "Pump_2")&&((tankname.Text == "Petrol_1")||(tankname.Text == "Petrol_2") || (tankname.Text == "Diesel_1")))
            {
                MessageBox.Show("This tank does not support 2 pumps, therefore you should not select Pump 2.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                printsales_pnl.Enabled = false;
            }
            else    
            {
                string location = Splashscreen.instance.station;
                if (location == "GTS Mberengwa Consolidated")
                {
                    if ((tankname.Text == "Petrol_1") || (tankname.Text == "Petrol_2") || (tankname.Text == "Diesel_1"))
                        if (pumpname.Text == "Pump_2")
                        {
                            MessageBox.Show("This tank does not support 2 pumps, therefore you should not select Pump 2.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pumpname.SelectedIndex = 0;
                        }
                        else
                            Processfrompump();
                    else
                        Processfrompump();
                }
                else
                    Processfrompump();
            }
            
        }

        private void Processfrompump()
        {
            DbConn.DisplayAndSearch("SELECT date, p1p1a, p1p1b, p2p1a, p2p1b, d1p1a, d1p1b, d2p1a, d2p1b, d2p2a, d2p2b FROM openingmeter ORDER BY id DESC LIMIT 1", appstartmeter_dgv);
            DbConn.DisplayAndSearch("SELECT date, sideaclose, sidebclose FROM sales WHERE tankname LIKE'%" + tankname.Text + "%' ORDER BY id DESC LIMIT 1", sales_dgv);
            if (sales_dgv.Rows.Count > 0)
            {
                string dbdate = sales_dgv.Rows[0].Cells[0].Value.ToString().Substring(0, 9);
                string namhla = date.Value.ToString().Substring(0, 9);
                if (dbdate == namhla)
                {
                    MessageBox.Show("Selected date sales for this pump have been registered.  \r\nAre you sure pumpname is correct?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    printsales_pnl.Enabled = false;
                }
                else
                {
                    sideaopen.Text = sales_dgv.Rows[0].Cells[1].Value.ToString();
                    sidebopen.Text = sales_dgv.Rows[0].Cells[2].Value.ToString();
                    printsales_pnl.Enabled = true;
                }
            }
            else
            {
                //No previous records found in database PETROL 1 PUMP1

                if ((tankname.Text == "Petrol_1") && (pumpname.Text == "Pump_1"))
                {
                    if (appstartmeter_dgv.Rows.Count > 0)
                    {
                        sideaopen.Text = appstartmeter_dgv.Rows[0].Cells[1].Value.ToString();
                        sidebopen.Text = appstartmeter_dgv.Rows[0].Cells[2].Value.ToString();
                        printsales_pnl.Enabled = true;
                    }
                }
                else
                    printsales_pnl.Enabled = true;

                //No previous records found in database PETROL 2 PUMP1

                if ((tankname.Text == "Petrol_2") && (pumpname.Text == "Pump_1"))
                {
                    if (appstartmeter_dgv.Rows.Count > 0)
                    {
                        sideaopen.Text = appstartmeter_dgv.Rows[0].Cells[3].Value.ToString();
                        sidebopen.Text = appstartmeter_dgv.Rows[0].Cells[4].Value.ToString();
                        printsales_pnl.Enabled = true;
                    }
                }
                else
                    printsales_pnl.Enabled = true;

                //No previous records found in database DIESEL 1 PUMP1

                if ((tankname.Text == "Diesel_1") && (pumpname.Text == "Pump_1"))
                {
                    if (appstartmeter_dgv.Rows.Count > 0)
                    {
                        sideaopen.Text = appstartmeter_dgv.Rows[0].Cells[5].Value.ToString();
                        sidebopen.Text = appstartmeter_dgv.Rows[0].Cells[6].Value.ToString();
                        printsales_pnl.Enabled = true;
                    }
                }
                else
                    printsales_pnl.Enabled = true;

                //No previous records found in database DIESEL 2 PUMP1

                if ((tankname.Text == "Diesel_2") && (pumpname.Text == "Pump_1"))
                {
                    if (appstartmeter_dgv.Rows.Count > 0)
                    {
                        sideaopen.Text = appstartmeter_dgv.Rows[0].Cells[7].Value.ToString();
                        sidebopen.Text = appstartmeter_dgv.Rows[0].Cells[8].Value.ToString();
                        printsales_pnl.Enabled = true;
                    }
                }
                else
                    printsales_pnl.Enabled = true;

                //No previous records found in database DIESEL 2 PUMP2

                if ((tankname.Text == "Diesel_2") && (pumpname.Text == "Pump_2"))
                {
                    if (appstartmeter_dgv.Rows.Count > 0)
                    {
                        sideaopen.Text = appstartmeter_dgv.Rows[0].Cells[9].Value.ToString();
                        sidebopen.Text = appstartmeter_dgv.Rows[0].Cells[10].Value.ToString();
                        printsales_pnl.Enabled = true;
                    }
                }
                else
                    printsales_pnl.Enabled = true;
            }
        }

        public void Salesflows()
        {
            cashsale = Salesflow.instance.xcashsale;
            prepaid = Salesflow.instance.xprepaid;
            postpaid = Salesflow.instance.xpostpaid;

            Calculate();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
        }

        decimal cashsale = 0;
        decimal prepaid = 0;
        decimal postpaid = 0;
        private void Calculate()
        {
            sideasale.Text = (sideaclose.Value - Convert.ToDecimal(sideaopen.Text)).ToString();
            sidebsale.Text = (sidebclose.Value - Convert.ToDecimal(sidebopen.Text)).ToString();
            totalsales.Text = (Convert.ToDecimal(sideasale.Text) + Convert.ToDecimal(sidebsale.Text)).ToString();
            if ((tankname.Text == "Petrol_1") || (tankname.Text == "Petrol_2"))
                amount.Text = (Convert.ToDecimal(totalsales.Text) * Convert.ToDecimal(pprice.Text)).ToString();
            else if ((tankname.Text == "Diesel_1") || (tankname.Text == "Diesel_2"))
                amount.Text = (Convert.ToDecimal(totalsales.Text) * Convert.ToDecimal(dprice.Text)).ToString();
            pumpstock.Text = (Convert.ToDecimal(openinglitres.Text) - Convert.ToDecimal(totalsales.Text)).ToString();
            dipstock.Text = dipclosel.Text;
            decimal var = Convert.ToDecimal(pumpstock.Text) - Convert.ToDecimal(dipstock.Text);
            if(Convert.ToDecimal(var)<0)
            {
                var *= -1;
            }
            variation.Text = var.ToString();
            cashtotal.Text = (decimal.Parse(amount.Text) - ((prepaid+postpaid)* Convert.ToDecimal(pprice.Text))).ToString();
            decimal amountt = Convert.ToDecimal(amount.Text);
            cashshort.Text = (decimal.Parse(cashtotal.Text) - cashSubmitted.Value).ToString();


        }
        private void sideaclose_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void sidebclose_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cashSubmitted_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Savesale()
        {
            Sale std = new Sale(date.Value, tankname.Text.Trim(), pumpname.Text.Trim(),openinglitres.Text.Trim(), sideaopen.Text.Trim(), sideaclose.Value,
                 sideasale.Text.Trim(), sidebopen.Text.Trim(), sidebclose.Value, sidebsale.Text.Trim(), totalsales.Text.Trim(), amount.Text.Trim(),
                  dipopenm.Text.Trim(), dipclosem.Text.Trim(), dipopenl.Text.Trim(), dipclosel.Text.Trim(), dipmovement.Text.Trim(), pumpstock.Text.Trim(),
                   dipstock.Text.Trim(), variation.Text.Trim(), cashSubmitted.Value, cashshort.Text.Trim(), cashtotal.Text.Trim(), supervisor_cbx.Text.Trim(), 
                   attendant_cbx.Text.Trim(),prepaid,postpaid,station);
            DbConn.AddSale(std);
            Clear();
            Loadtables();
            //Dashboard.instance.Loadtables();
            ControlHome.instance.Loadtables();
            //ControlReports.instance.Loadtables();
            attendant_cbx.SelectedIndex = supervisor_cbx.SelectedIndex = 0;
            label58.Text = label60.Text = label65.Text = label19.Text = label63.Text = "";
        }

        private void Savesaleprofile()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal mysales = decimal.Parse(label65.Text);
            if ((supervisor_cbx.Text == "") || (attendant_cbx.Text == "")||(mysales<1))
                MessageBox.Show("Attandant and supervisor names missing / Data incomplete.  \r\nCapture them and try again].", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                save_btn.Enabled = true;
                Random rand = new Random();
                verificationcode = rand.Next(100000, 999999);

                //email x
                verifycode_txt.Text = verificationcode.ToString();
            }
                
        }

        private void Loadattendants()
        {
            DbConn.DisplayAndSearch("SELECT fullname, idnumber, phone FROM employee WHERE email LIKE '%" + attendant_cbx.Text + "%' ORDER BY id DESC LIMIT 1", dataGridView2);
        }

        private void attendant_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadattendants();
            if (dataGridView2.Rows.Count > 0)
            {
                label58.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label60.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                label63.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                label65.Text = cashtotal.Text;
                label19.Text = cashshort.Text;
                save_btn.Enabled = true;
            }
            
        }

        private void label55_DoubleClick(object sender, EventArgs e)
        {

        }
        public string totallitres;
        private void salesflow_btn_Click(object sender, EventArgs e)
        {
            totallitres = totalsales.Text;
            Salesflow sf = new Salesflow();
            sf.ShowDialog();
        }

        //GENERATE RANDOM FOR FILLING VERIFICATION

    }
}
