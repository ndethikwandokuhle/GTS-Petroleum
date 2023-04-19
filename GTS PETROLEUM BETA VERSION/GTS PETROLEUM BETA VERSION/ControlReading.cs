using System;
using System.Windows.Forms;

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class ControlReading : UserControl
    {
        public ControlReading()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            readingdate.Value = DateTime.Today;
            tankname.SelectedIndex = 0;
            comments.Text = "";
            manualOpenmeters.Value = manualOpenlitres.Value = closedipmeters.Value = closediplitres.Value = 0;
            variationLitres_lbl.Text = variationMeters_lbl.Text = autoOpenlitres_lbl.Text = autoOpenmeters_lbl.Text = "0.00";
            movementmeters_lbl.Value = movementlitres_lbl.Value = 0;
        }

        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading", reading_gdv);
            
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ControlReading_Load(object sender, EventArgs e)
        {
            reading_pnl.Width = 0;
            Loadtables();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (reading_pnl.Width < 320)
            {
                reading_pnl.Width += 40;
            }
            else
                timer1.Stop();
        }

        private void addnew_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            reading_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            reading_pnl.Width = 0;
            Loadtables();
            reading_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void reading_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadfromDeliveries()
        {
            string checktype_p = "Petrol";
            string checktype_d = "Diesel";
            if ((tankname.Text == "Petrol_1")||(tankname.Text == "Petrol_2"))
            {
                DbConn.DisplayAndSearch("SELECT deliverydate, t1received, t2received FROM deliveries WHERE fueltype LIKE '%" + checktype_p + "%' ORDER BY id DESC LIMIT 1", dataGridView2);
            }
            else if ((tankname.Text == "Diesel_1")||(tankname.Text == "Diesel_2"))
            {
                DbConn.DisplayAndSearch("SELECT deliverydate, t1received, t2received FROM deliveries WHERE fueltype LIKE '%" + checktype_d + "%' ORDER BY id DESC LIMIT 1", dataGridView2);
            }

            //check if delivery was today
            if (dataGridView2.Rows.Count > 0)
            {
                string recordeddelivery = dataGridView2.Rows[0].Cells[0].Value.ToString().Substring(0,9);
                string todayrecorddate = readingdate.Value.ToString().Substring(0,9);
                if(recordeddelivery == todayrecorddate)
                {
                    button1.Visible = true;
                }
                else
                {
                    button1.Visible = false;
                    movementmeters_lbl.Enabled = movementlitres_lbl.Enabled = false;
                }
            }
            else
            {
                button1.Visible = false;
                movementmeters_lbl.Enabled = movementlitres_lbl.Enabled = false;
            }
            
            //if ()
        }

        private void closedipl_ValueChanged(object sender, EventArgs e)
        {
            decimal autoliters = Convert.ToDecimal(autoOpenlitres_lbl.Text);
            x = autoliters - closediplitres.Value;
            movementlitres_lbl.Value = x;
        }
        string comparedate = "0";
        private void tankname_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadfromDeliveries();
            DbConn.DisplayAndSearch("SELECT ID, readingdate, tankname, autoopenmeters, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres FROM reading WHERE tankname LIKE '%" + tankname.Text + "%' ORDER BY id DESC LIMIT 1", reading_gdv);
            
            if (reading_gdv.Rows.Count > 0)
            {
                if(tankname.SelectedIndex == 0)
                {
                    Loadtables();
                }
                else
                {
                    //comparedate = reading_gdv.Rows[0].Cells[1].Value.ToString();
                    //checking if same date and same tank

                    if (comparedate == readingdate.Value.ToString().Substring(0, 9))
                    {
                        MessageBox.Show("Tank record for the specified date has been captured.", "DATA DUPLICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tankname.SelectedIndex = 0;
                    }
                    else
                    {
                        //assigning value from the previous day
                        autoOpenmeters_lbl.Text = reading_gdv.Rows[0].Cells[6].Value.ToString();
                        autoOpenlitres_lbl.Text = reading_gdv.Rows[0].Cells[7].Value.ToString();
                    }
                }
            }
            else
            {

                //inserting from the opening read table meaning itss a new system
                DbConn.DisplayAndSearch("SELECT ID, date, p1m, p1l, p2m, p2l, d1m, d1l, d2m, d2l FROM openingreadd", dataGridView1);
                if(tankname.Text == "Petrol_1")
                {
                    autoOpenmeters_lbl.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    autoOpenlitres_lbl.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                }
                else if (tankname.Text == "Petrol_2")
                {
                    autoOpenmeters_lbl.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    autoOpenlitres_lbl.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                }
                else if (tankname.Text == "Diesel_1")
                {
                    autoOpenmeters_lbl.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    autoOpenlitres_lbl.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                }
                else if (tankname.Text == "Diesel_2")
                {
                    autoOpenmeters_lbl.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    autoOpenlitres_lbl.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
                }
            }  
        }
        string station;
        decimal x = 0;
        string variationflag = "No";
        string movementflag = "No";

        string recordeddelivery = "record";
        string todayrecorddate = "delivery";
        private void save_btn_Click(object sender, EventArgs e)
        {
            //check if duplicate date record
            if (reading_gdv.Rows.Count > 0)
            {
                 recordeddelivery = reading_gdv.Rows[0].Cells[1].Value.ToString().Substring(0, 9);
                 todayrecorddate = readingdate.Value.ToString().Substring(0, 9);
            }
             
             if (recordeddelivery == todayrecorddate)
             {
                MessageBox.Show("Today's reading for this tank has already been recorded into the system.  \r\nVerify date and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
             {
                //MessageBox.Show(recordeddelivery +" is same as "+ todayrecorddate );
                if ((tankname.Text == "") || (movementlitres_lbl.Value < 1))
                {
                    MessageBox.Show("Some fields where left blank / Fuel balances are now negative values. \r\nComplete and Verify data then try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (x > 5)
                    {
                        variationflag = "Yes";
                    }
                    station = Splashscreen.instance.station;
                    Savereading();
                    reading_pnl.Width = 0;
                    Clear();
                    reading_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            manualread_pnl.Enabled = true;
        }

        private void manualOpenmeters_ValueChanged(object sender, EventArgs e)
        {
            decimal x = manualOpenmeters.Value - decimal.Parse(autoOpenmeters_lbl.Text);
            if (x < 0)
                x *= -1;

            variationMeters_lbl.Text = x.ToString();
        }

        private void manualOpenlitres_ValueChanged(object sender, EventArgs e)
        {
            decimal x = manualOpenlitres.Value - decimal.Parse(autoOpenlitres_lbl.Text);
            if (x < 0)
                x *= -1;

            variationLitres_lbl.Text = x.ToString();

        }

        private void closedipmeters_ValueChanged(object sender, EventArgs e)
        {
            decimal autometers = Convert.ToDecimal(autoOpenmeters_lbl.Text);
            movementmeters_lbl.Value = autometers - closedipmeters.Value;
        }

        //*********************************************************************************************************
        //*********************************************************************************************************
        // save data
        private void Savereading()
        {
            Reading std = new Reading(readingdate.Value, tankname.Text.Trim(), decimal.Parse(autoOpenmeters_lbl.Text), decimal.Parse(autoOpenlitres_lbl.Text),
                manualOpenmeters.Value, manualOpenlitres.Value, decimal.Parse(variationMeters_lbl.Text), decimal.Parse(variationLitres_lbl.Text),
                closedipmeters.Value, closediplitres.Value, movementmeters_lbl.Value, movementlitres_lbl.Value, comments.Text.Trim(),
                variationflag, movementflag, station);
            DbConn.AddReading(std);
            Clear();
            Loadtables();
            Dashboard.instance.Loadtables();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            movementmeters_lbl.Enabled = movementlitres_lbl.Enabled = true;
        }

        private void readingdate_ValueChanged(object sender, EventArgs e)
        {
            //LoadfromDeliveries();
            tankname.SelectedIndex = 0;
            button1.Visible = false;
            movementmeters_lbl.Enabled = movementlitres_lbl.Enabled = false;
        }
    }
}
