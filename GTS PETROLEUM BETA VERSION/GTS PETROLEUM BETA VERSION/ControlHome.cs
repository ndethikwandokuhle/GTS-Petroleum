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
    public partial class ControlHome : UserControl
    {
        public static ControlHome instance;
        public DateTime date;
        public string tankname;
        public string pumpname;

        public string sp1openingstock;
        public string sp1sideaopen;
        public string sp1sideaclose;
        public string sp1sideasales;
        public string sp1sidebopen;
        public string sp1sidebclose;
        public string sp1sidebsales;
        public string sp1totalsales;
        public string sp1amount;
        public string sp1dipopenm;
        public string sp1dipclosem;
        public string sp1dipopenl;
        public string sp1dipclosel;
        public string sp1dipmovement;
        public string sp1pumpstock;
        public string sp1dipstock;
        public string sp1variation;
        public string sp1cashsubmitted;
        public string sp1cashshortage;
        public string sp1total;
        public string sattendant;
        public string ssupervisor;
        public ControlHome()
        {
            InitializeComponent();
            instance = this;
        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel52_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            tankname = label188.Text;
            pumpname = label187.Text;

            sp1openingstock = p1openingstock.Text;
            sp1sideaopen = p1sideaopen.Text;
            sp1sideaclose = p1sideaclose.Text;
            sp1sideasales = p1sideasales.Text;
            sp1sidebopen = p1sidebopen.Text;
            sp1sidebclose = p1sidebclose.Text;
            sp1sidebsales = p1sidebsales.Text;
            sp1totalsales = p1totalsales.Text;
            sp1amount = p1amount.Text;
            sp1dipopenm = p1dipopenm.Text;
            sp1dipclosem = p1dipclosem.Text;
            sp1dipopenl = p1dipopenl.Text;
            sp1dipclosel = p1dipclosel.Text;
            sp1dipmovement = p1dipmovement.Text;
            sp1pumpstock = p1pumpstock.Text;
            sp1dipstock = p1dipstock.Text;
            sp1variation = p1variation.Text;
            sp1cashsubmitted = p1cashsubmitted.Text;
            sp1cashshortage = p1cashshortage.Text;
            sp1total = p1total.Text;
            sattendant = label48.Text;
            ssupervisor = label49.Text;

            Homesalesprint hsp = new Homesalesprint();
            hsp.ShowDialog();
        }

        private void ControlHome_Load(object sender, EventArgs e)
        {
            Loadtables();
        }

        public void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT date, tankname, pumpname, dipquantity, sideaopen, sideaclose, sideasale, sidebopen, sidebclose, sidebsale, totalsales, amount, dipopenm, dipclosem, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, supervisor, attendant FROM sales", sales_gdv);
        }

        private void sales_gdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = sales_gdv.Rows[e.RowIndex];
                    dateTimePicker1.Value = DateTime.Parse(dgvRow.Cells[0].Value.ToString());
                    label188.Text = dgvRow.Cells[1].Value.ToString();
                    label187.Text = dgvRow.Cells[2].Value.ToString();

                    p1openingstock.Text = dgvRow.Cells[3].Value.ToString();
                    p1sideaopen.Text = dgvRow.Cells[4].Value.ToString();
                    p1sideaclose.Text = dgvRow.Cells[5].Value.ToString();
                    p1sideasales.Text = dgvRow.Cells[6].Value.ToString();
                    p1sidebopen.Text = dgvRow.Cells[7].Value.ToString();
                    p1sidebclose.Text = dgvRow.Cells[8].Value.ToString();
                    p1sidebsales.Text = dgvRow.Cells[9].Value.ToString();
                    p1totalsales.Text = dgvRow.Cells[10].Value.ToString();
                    p1amount.Text = dgvRow.Cells[11].Value.ToString();
                    p1dipopenm.Text = dgvRow.Cells[12].Value.ToString();
                    p1dipclosem.Text = dgvRow.Cells[13].Value.ToString();
                    p1dipopenl.Text = dgvRow.Cells[14].Value.ToString();
                    p1dipclosel.Text = dgvRow.Cells[15].Value.ToString();
                    p1dipmovement.Text = dgvRow.Cells[16].Value.ToString();
                    p1pumpstock.Text = dgvRow.Cells[17].Value.ToString();
                    p1dipstock.Text = dgvRow.Cells[18].Value.ToString();
                    p1variation.Text = dgvRow.Cells[19].Value.ToString();
                    p1cashsubmitted.Text = dgvRow.Cells[20].Value.ToString();
                    p1cashshortage.Text = dgvRow.Cells[21].Value.ToString();
                    p1total.Text = dgvRow.Cells[22].Value.ToString();
                    label48.Text = dgvRow.Cells[24].Value.ToString();
                    label49.Text = dgvRow.Cells[23].Value.ToString();

                    label283.Text = p1total.Text;
                    label284.Text = p1cashshortage.Text;
                    label278.Text = label48.Text;
                    label11.Text = dateTimePicker1.Value.ToString().Substring(0,9);
                }
            }
        }

        private void attendant_profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttendentsProfile ap = new AttendentsProfile();
            ap.ShowDialog();
        }

        private void sales_gdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void panel472_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
