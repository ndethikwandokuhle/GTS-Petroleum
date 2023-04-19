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
    public partial class ControlAccount : UserControl
    {
        public static ControlAccount instance;
        public string namecompany;
        public string addresscompany;
        public string phonecompany;
        public string emailcompany;
        public string handler;
        public string typeaccount;
        public string recordid;
        public ControlAccount()
        {
            InitializeComponent();
            instance = this;
        }

        private void ControlAccount_Load(object sender, EventArgs e)
        {
            updateacc_btn.Enabled = false;
            add_pnl.Width = 0;
            Loadtables();
        }

        private void Clear()
        {
            acctype_cbx.SelectedIndex = 0;
            companyname_txt.Text = companyaddress_txt.Text = companyphone_txt.Text = handler_txt.Text = companyemail_txt.Text = "";
        }
        
        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT ID, date, acctype, companyname, companyaddress, companyphone, handler, companyemail FROM accounts", accounts_gdv);
            updateacc_btn.Enabled = false;
            label10.Text = accounts_gdv.Rows.Count.ToString();

        }

        private void addne_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            updateacc_btn.Enabled = false;
            accounts_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
            save_btn.Enabled = true;
            updateacc_btn.Enabled = false;
        }
        private void accounts_gdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = accounts_gdv.Rows[e.RowIndex];
                    date.Value = DateTime.Parse(dgvRow.Cells[1].Value.ToString());
                    id_text.Text = dgvRow.Cells[0].Value.ToString();
                    companyname_txt.Text = dgvRow.Cells[3].Value.ToString();
                    companyphone_txt.Text = dgvRow.Cells[4].Value.ToString();
                    companyaddress_txt.Text = dgvRow.Cells[5].Value.ToString();
                    handler_txt.Text = dgvRow.Cells[6].Value.ToString();
                    companyemail_txt.Text = dgvRow.Cells[7].Value.ToString();
                    string accty = dgvRow.Cells[2].Value.ToString();
                    if (accty == "Post-paid")
                        acctype_cbx.SelectedIndex = 2;
                    else if (accty == "Pre-paid")
                        acctype_cbx.SelectedIndex = 1;
                    timer1.Start();
                    save_btn.Enabled = false;
                    updateacc_btn.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (add_pnl.Width < 320)
            {
                add_pnl.Width += 20;
                //transactions_pnl.Width = 0;
            }
            else
                timer1.Stop();
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
            add_pnl.Width = 0;
            accounts_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
        string station;
        private void fueltype_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if((acctype_cbx.Text == "")||(companyname_txt.Text == "")||(companyaddress_txt.Text == "")||(companyaddress_txt.Text == "")||(companyphone_txt.Text == "")||(handler_txt.Text == ""))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                station = Splashscreen.instance.station;
                Saveaccount();
            }
        }

        private void Saveaccount()
        {
            Accounts std = new Accounts(date.Value, acctype_cbx.Text.Trim(), companyname_txt.Text.Trim(), companyaddress_txt.Text.Trim(),
                companyphone_txt.Text.Trim(), handler_txt.Text.Trim(), companyemail_txt.Text.Trim(), station);
            DbConn.AddAccounts(std);
            Clear();
            Loadtables();
            label10.Text = accounts_gdv.Rows.Count.ToString();
            //Dashboard.instance.Loadtables();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if((companyname_txt.Text == "")||(companyaddress_txt.Text == ""))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                namecompany = companyname_txt.Text;
                addresscompany = companyaddress_txt.Text;
                phonecompany = companyphone_txt.Text;
                emailcompany = companyemail_txt.Text;
                typeaccount = acctype_cbx.Text;
                handler = handler_txt.Text;
                recordid = id_text.Text;
                Transations trans = new Transations();
                trans.ShowDialog();
            }
            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("and then");
            string id = id_text.Text;
            Accounts std = new Accounts(date.Value, acctype_cbx.Text.Trim(), companyname_txt.Text.Trim(), companyaddress_txt.Text.Trim(), 
                companyphone_txt.Text.Trim(), handler_txt.Text.Trim(), companyemail_txt.Text.Trim(), station);
            DbConn.UpdateAccount(std, id);
            Loadtables();
            Clear();
            add_pnl.Width = 0;
            accounts_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void updateacc_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("and then");
            string id = id_text.Text;
            Accounts std = new Accounts(date.Value, acctype_cbx.Text.Trim(), companyname_txt.Text.Trim(), companyaddress_txt.Text.Trim(),
                companyphone_txt.Text.Trim(), handler_txt.Text.Trim(), companyemail_txt.Text.Trim(), station);
            DbConn.UpdateAccount(std, id);
            Loadtables();
            Clear();
            add_pnl.Width = 0;
            accounts_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
