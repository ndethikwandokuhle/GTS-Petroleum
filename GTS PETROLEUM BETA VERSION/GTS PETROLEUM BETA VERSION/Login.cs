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
    public partial class Login : Form
    {
        public static Login instance;
        public string position;
        public string fullname;
        //string checker = "guest";
        public Login()
        {
            InitializeComponent();
            instance = this;
            //panel1.BackColor = Color.FromArgb(200, Color.Black);
        }

        //private void Clear()
        //{
        //    checker = "guest";
        //}
        //public void Assignnames()
        //{
        //    if (checker == "verified")
        //        AssignfromDB();
        //    else if(checker == "guest")
        //        AssignfromLocal();

        //    Clear(); 
        //}

        //public void AssignfromDB()
        //{
        //    position = "Supervisor";
        //    fullname = "Gerry Wapunza";
        //}

        //public void AssignfromLocal()
        //{
        //    position = "GUEST";
        //    fullname = "Read-Only Priviledges";
        //}

        private void password_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Retrievepassword rpass = new Retrievepassword();
            rpass.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if ((username_txt.Text == "") || (passord_txt.Text == ""))
            {
                MessageBox.Show("Email and/or password cannot be NULL", "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string myposition = "Supervisor";
                string station = Splashscreen.instance.station;
                DbConn.DisplayAndSearch("SELECT fullname, position, email, password, station FROM users WHERE email LIKE'%" + username_txt.Text + "%' AND password LIKE'%" + passord_txt.Text + "%'", login_dgv);
                
                if (login_dgv.Rows.Count > 0)
                {

                    string user = login_dgv.Rows[0].Cells[2].Value.ToString();
                    string pass = login_dgv.Rows[0].Cells[3].Value.ToString();
                    myposition = login_dgv.Rows[0].Cells[1].Value.ToString();
                    string myname = login_dgv.Rows[0].Cells[0].Value.ToString();
                    string mystation = login_dgv.Rows[0].Cells[4].Value.ToString();
                    string userrname = login_dgv.Rows[0].Cells[0].Value.ToString();
                    if ((username_txt.Text == user) && (passord_txt.Text == pass))
                    {
                        string location = Splashscreen.instance.station;
                        //checker = "verified";
                        if (location == mystation)
                        {
                            position = myposition;
                            userrname = myname;
                            fullname = myname;
                            this.Hide();
                            Dashboard dash = new Dashboard();
                            dash.ShowDialog();
                        }
                        else
                            MessageBox.Show("No user with name "+userrname+" in "+ Splashscreen.instance.station, "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                        MessageBox.Show("Email/Password is incorrect. Access denied!!!", "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Email/Password is incorrect. Access denied!!!", "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            username_txt.Text = "";
            passord_txt.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
