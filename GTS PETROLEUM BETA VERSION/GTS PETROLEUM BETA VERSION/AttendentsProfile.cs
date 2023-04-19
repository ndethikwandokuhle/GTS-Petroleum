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
    public partial class AttendentsProfile : Form
    {
        public AttendentsProfile()
        {
            InitializeComponent();
        }

        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT ID, date, fullname, supervisor, phone, idnumber, sales, shortages, settled, station FROM saleprofile", salesprofile_dgv);
            DbConn.DisplayAndSearch("SELECT date, fullname, supervisor, sales, shortages FROM saleprofile WHERE idnumber LIKE '%" + label2.Text + "%'", dataGridView1);
            DbConn.DisplayAndSearch("SELECT settled FROM saleprofile WHERE idnumber LIKE '%" + label2.Text + "%'", dataGridView2);
            

            

            decimal totalshortage = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalshortage = (totalshortage + decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
            }

            decimal totalsettled = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                totalsettled = (totalsettled + decimal.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()));
            }

            decimal balance = totalshortage - totalsettled;
            label8.Text = balance.ToString();

        }

        private void AttendentsProfile_Load(object sender, EventArgs e)
        {
            Loadtables();
        }

        DateTime date;
        string supervisor;
        string sales;
        string shortages;
        string id;

        private void salesprofile_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = salesprofile_dgv.Rows[e.RowIndex];
                    label1.Text = dgvRow.Cells[2].Value.ToString();
                    label10.Text = dgvRow.Cells[4].Value.ToString();
                    label2.Text = dgvRow.Cells[5].Value.ToString();
                    id = dgvRow.Cells[0].Value.ToString();
                    string mydate = dgvRow.Cells[1].Value.ToString().Substring(0,9);
                    //MessageBox.Show(mydate);
                    date = DateTime.Parse(mydate);
                    supervisor = dgvRow.Cells[3].Value.ToString();
                    sales = dgvRow.Cells[6].Value.ToString();
                    shortages = dgvRow.Cells[7].Value.ToString();

                    Loadtables();

                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (amount.Value > 0)
                Savedeposit();
            else
                MessageBox.Show("Deposit value ccannot be less than 0.00.", "DATA DUPLICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Savedeposit()
        {
            decimal totalsettled = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                totalsettled = (totalsettled + decimal.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()));
            }

            totalsettled += amount.Value;
            string station = Splashscreen.instance.station;
            SaleProfile std = new SaleProfile(date, label1.Text.Trim(), supervisor, label10.Text.Trim(), label2.Text.Trim(), decimal.Parse(sales), decimal.Parse(shortages), totalsettled, station);
            DbConn.UpdateSaleProfile(std, id);
            Loadtables();
        }
    }
}
