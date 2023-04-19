using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using filter_with_dateRange_mysql.myclass;

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class ControlReports : UserControl
    {
        public static ControlReports instance;
        public ControlReports()
        {
            InitializeComponent();
            instance = this;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

        private void ControlReports_Load(object sender, EventArgs e)
        {
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");
            sales_gdv.Rows.Add("#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####", "#####");

            contentpanel.Visible = false;
            coverpanel.Visible = true;
        }

        private void reportname_txt_TextChanged(object sender, EventArgs e)
        {
            //reportname_lbl.Text = reportname_txt.Text;
            if(reportname_txt.Text == "")
            {
                contentpanel.Visible = false;
                coverpanel.Visible = true;
            }
            else
            {
                contentpanel.Visible = true;
                coverpanel.Visible = false;
            }
        }

        private void databackup_btn_Click(object sender, EventArgs e)
        {
            Backup bu = new Backup();
            bu.ShowDialog();
        }

        private void dataAnalysis_btn_Click(object sender, EventArgs e)
        {

        }

        private void tabulated_btn_Click(object sender, EventArgs e)
        {

        }

        private void graphical_btn_Click(object sender, EventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {
            
        }
    }
}
