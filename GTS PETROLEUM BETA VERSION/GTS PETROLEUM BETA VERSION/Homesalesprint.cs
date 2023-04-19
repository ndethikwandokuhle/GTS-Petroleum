using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class Homesalesprint : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public Homesalesprint()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            Print(this.records_pnl);
        }

        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            records_pnl = pnl;
            getprintarea(pnl);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }

        private void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.records_pnl.Width / 2), this.records_pnl.Location.Y);
        }

        Bitmap memorying;
        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(records_pnl.Width, records_pnl.Height))
            {
                //string x = DateTime.Now.ToString().Replace("/"," ");
                records_pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"images/" + "Daily Sales " + label1.Text + ".bmp");
                MessageBox.Show("Screen snip image saved to GTS Images Folder on Desktop.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Homesalesprint_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("dddd, MMMM dd");

            DateTime d = ControlHome.instance.date;
            label189.Text = d.ToString();
            tankname_lbl.Text = ControlHome.instance.tankname;
            pumpname.Text = ControlHome.instance.pumpname;
            openingstock.Text = ControlHome.instance.sp1openingstock;
            sideaopen.Text = ControlHome.instance.sp1sideaopen;
            sideaclose.Text = ControlHome.instance.sp1sideaclose;
            sideasales.Text = ControlHome.instance.sp1sideasales;
            sidebopen.Text = ControlHome.instance.sp1sidebopen;
            sidebclose.Text = ControlHome.instance.sp1sidebclose;
            sidebsales.Text = ControlHome.instance.sp1sidebsales;
            totalsales.Text = ControlHome.instance.sp1totalsales;
            salesamount.Text = ControlHome.instance.sp1amount;
            opendipm.Text = ControlHome.instance.sp1dipopenm;
            closedipm.Text = ControlHome.instance.sp1dipclosem;
            opendipl.Text = ControlHome.instance.sp1dipopenl;
            closedipl.Text = ControlHome.instance.sp1dipclosel;
            dipmovements.Text = ControlHome.instance.sp1dipmovement;
            pumpstock.Text = ControlHome.instance.sp1pumpstock;
            dipstock.Text = ControlHome.instance.sp1dipstock;
            variation.Text = ControlHome.instance.sp1variation;
            cashsubmited.Text = ControlHome.instance.sp1cashsubmitted;
            cashshort.Text = ControlHome.instance.sp1cashshortage;
            cashtotal.Text = ControlHome.instance.sp1total;
            attend.Text = ControlHome.instance.sattendant;
            super.Text = ControlHome.instance.ssupervisor;
        }
    }
}