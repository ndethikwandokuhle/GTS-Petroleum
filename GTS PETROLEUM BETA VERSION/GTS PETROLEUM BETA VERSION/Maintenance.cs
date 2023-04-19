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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
            //panel2.BackColor = Color.FromArgb(200, Color.Black);
            panel3.BackColor = Color.FromArgb(200, Color.Black);
            panel4.BackColor = Color.FromArgb(200, Color.Black);
            panel5.BackColor = Color.FromArgb(200, Color.Black);
            panel6.BackColor = Color.FromArgb(200, Color.Black);
            //accounts_gdv.BackColor = Color.FromArgb(200, Color.Black);
        }

        private void Clear()
        {
            profilesemail_txt.Text = profilespassword_txt.Text = pemail_txt.Text = ppassword_txt.Text = pconfirmpasswword_txt.Text =  feeddescription_txt.Text = fullname_txt.Text = idno_txt.Text = phone_txt.Text = email_txt.Text = password_txt.Text = confirmpassword_txt.Text = categoryname_txt.Text = description_txt.Text = "";
            dob.Value = DateTime.Now;
            fullname_cbx.SelectedIndex = loglevel_cbx.SelectedIndex =  sex_cbx.SelectedIndex = position_cbx.SelectedIndex = 0;
        }

        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT ID, fullname, dob, sex, position, idnumber, phone, email FROM employee", employee_dgv);
            DbConn.DisplayAndSearch("SELECT ID, date, category, description FROM ledgercategory", ledgercategory_dgv);
            DbConn.DisplayAndSearch("SELECT ID, date, petrol, diesel FROM rates", rates_dgv);


            foreach (DataGridViewRow row in employee_dgv.Rows)
            {
                fullname_cbx.Items.Add(row.Cells[1].Value);
            }
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            Loadtables();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void saveleger_btn_Click(object sender, EventArgs e)
        {
            if ((categoryname_txt.Text == "") || (description_txt.Text == ""))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Saveledgercategory();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void saverate_btn_Click(object sender, EventArgs e)
        {
            if ((petrolprice.Value < 0) || (dieselprice.Value < 0))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                station = Splashscreen.instance.station;
                Saverates();
            }
                

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //string

        private void button5_Click(object sender, EventArgs e)
        {
            if ((loglevel_cbx.Text == "") || (feeddescription_txt.Text == ""))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                station = Splashscreen.instance.station;
                Savefeedback();
        }
        private void clearprofile_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void dob_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        string station = "Null";
        private void save_btn_Click(object sender, EventArgs e)
        {
            if ((fullname_txt.Text == "") || (sex_cbx.Text == "") || (position_cbx.Text == "") || (idno_txt.Text == "") || ((email_txt.Text == "") && (phone_txt.Text == "")) || (label32.Text == "Passwords donot match."))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DateChecker dd = new DateChecker(dob.Value, today.Value);
                string years = dd.ToString();
                int agee = (Convert.ToInt32(years)) / 365;
                //age.Text = agee.ToString();
                if (agee < 18)
                {
                    MessageBox.Show("Employee's age cannot be below 18 years", "INACCURATE DATA::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //savedata = "no";
                }
                else
                {
                    station = Splashscreen.instance.station;
                    Saveemployee();
                }
            }
                
        }

        private void password_txt_Click(object sender, EventArgs e)
        {
            confirmpassword_txt.Text = "";
        }

        private void confirmpassword_txt_TextChanged(object sender, EventArgs e)
        {
            if(password_txt.Text == confirmpassword_txt.Text)
            {
                label32.Text = "Passwords match.";
                label32.ForeColor = Color.Green;
            }
            else
            {
                label32.Text = "Passwords donot match.";
                label32.ForeColor = Color.Red;
            }
        }
        private void Saveemployee()
        {
            Employee std = new Employee(fullname_txt.Text.Trim(), dob.Value, sex_cbx.Text.Trim(), position_cbx.Text, idno_txt.Text.Trim(),
                phone_txt.Text.Trim(), email_txt.Text.Trim(), password_txt.Text.Trim(), station);
            DbConn.AddEmployee(std);
            Clear();
            Loadtables();
            //Dashboard.instance.Loadtables();
        }
        private void Saveledgercategory()
        {
            Ledgercategory std = new Ledgercategory(today.Value, categoryname_txt.Text.Trim(), description_txt.Text.Trim());
            DbConn.AddLedgercategory(std);
            Clear();
            Loadtables();
            //Dashboard.instance.Loadtables();
        }
        private void Savefeedback()
        {
            Feedback std = new Feedback(feeddate.Value, loglevel_cbx.Text.Trim(), feeddescription_txt.Text.Trim(), station);
            DbConn.AddFeedback(std);
            Clear();
            Loadtables();
            //Dashboard.instance.Loadtables();
        }

        private void Saverates()
        {
            Rates std = new Rates(ratedate.Value, petrolprice.Value, dieselprice.Value, station);
            DbConn.AddRates(std);
            Clear();
            Loadtables();
            //Dashboard.instance.Loadtables();
        }

        
    }
}
