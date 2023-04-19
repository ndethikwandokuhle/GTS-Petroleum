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
    public partial class VerifySale : Form
    {
        public VerifySale()
        {
            InitializeComponent();
        }
        string nationalid;
        private void VerifySale_Load(object sender, EventArgs e)
        {
            label4.Text = ControlSales.instance.activeuser;
            nationalid = ControlSales.instance.mynid;
            label1.Text = nationalid;
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            if ((username_txt.Text == "") || (passord_txt.Text == ""))
            {
                MessageBox.Show("Email and/or password cannot be NULL", "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DbConn.DisplayAndSearch("SELECT email, password FROM employee WHERE email LIKE '%" + username_txt.Text + "%' ORDER BY id DESC LIMIT 1", login_dgv);
                if (login_dgv.Rows.Count > 0)
                {
                    string user = login_dgv.Rows[0].Cells[0].Value.ToString();
                    string pass = login_dgv.Rows[0].Cells[1].Value.ToString();
                    if ((username_txt.Text == user) && (passord_txt.Text == pass))
                    {
                        ControlSales.instance.Savedata();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Email/Password is incorrect. Access denied!!!", "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Email/Password is incorrect. Access denied!!!", "LOGIN ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
