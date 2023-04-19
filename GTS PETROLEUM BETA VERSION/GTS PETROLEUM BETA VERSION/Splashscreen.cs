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
    public partial class Splashscreen : Form
    {
        public static Splashscreen instance;
        public string station;
        
        public Splashscreen()
        {
            InitializeComponent();
            instance = this;
            //this.BackColor = Color.White;
            panel3.BackColor = Color.FromArgb(195, Color.Black);
            panel4.BackColor = Color.FromArgb(195, Color.Black);
            panel7.BackColor = Color.FromArgb(10, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Black, 0, 0, 100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var shortTimeStr = DateTime.Now.ToShortTimeString().Substring(0, 5);
            label1.Text = shortTimeStr;
            DateTime now = DateTime.Now;
            string today = now.ToString("dddd, MMMM dd");
            label2.Text = today;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(panel6.Width < 270)
            {
                panel6.Width += 1;
                //label4.Text = panel6.Width.ToString();
            }
            else
            {
                //DbConn.DisplayAndSearch("SELECT ID, readingdate FROM reading", reading_gdv);
                DbConn.DisplayAndSearch("SELECT ID, station FROM station", station_dgv);

                if (station_dgv.Rows.Count < 1)
                {
                    timer2.Stop();
                    //MessageBox.Show("akula jeki");
                    New_system ns = new New_system();
                    ns.ShowDialog();
                }
                else
                {
                    panel4.Enabled = true;
                    label5.Text = "READY";
                    station_lbl.Text = station_dgv.Rows[0].Cells[1].Value.ToString();
                }
                //label5.Text = "READY!";
                //label5.ForeColor = Color.White;
                //panel4.Enabled = true;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (station_lbl.Text == "Station")
                MessageBox.Show("Station name not found. Contact IT Support to avoid more data lose.", "STATION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                station = station_lbl.Text;
                Login logi = new Login();
                logi.ShowDialog();
            }
        }

        private void about_btn_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            Appstats ap = new Appstats();
            ap.ShowDialog();
        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            //if (station_cbx.Text == "")
            //    MessageBox.Show("Make sure you select GTS site to view", "STATION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            //    station = station_cbx.Text;
            //    Dashboard dash = new Dashboard();
            //    dash.ShowDialog();
            //}
            MessageBox.Show("Guest Mode will be activated once the system goes ONLINE", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void station_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(station_cbx.Text == "Management")
            //{
            //    MessageBox.Show("Insufficient data to view management portal.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    station_cbx.SelectedIndex = 0;
            //}
            //else
            //   station = station_cbx.Text;
        }

        public void Callmeonclosing()
        {
            station_lbl.Text = GetstartedStation.instance.station;
            panel4.Enabled = true;
            label5.Text = "READY";
        }
    }
}
