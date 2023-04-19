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
    public partial class DeliveryInfor : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public DeliveryInfor()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryInfor_Load(object sender, EventArgs e)
        {
            label32.Text = ControlDeliveries.instance.deliveryid;


            date_lbl.Text = ControlDeliveries.instance.senddate.Substring(0,9);
            type_lbl.Text = ControlDeliveries.instance.sendtype;
            supplier_lbl.Text = ControlDeliveries.instance.sendsupplier;
            driver_lbl.Text = ControlDeliveries.instance.senddriver;
            lorryno_lbl.Text = ControlDeliveries.instance.sendlorryno;
            invoice_lbl.Text = ControlDeliveries.instance.sendinvoice;
            dnoteno_lbl.Text = ControlDeliveries.instance.senddnotno;
            dnoteqty_lbl.Text = ControlDeliveries.instance.senddnoteqty;
            lorryqty_lbl.Text = ControlDeliveries.instance.sendlorryqty;
            comment_lbl.Text = ControlDeliveries.instance.sendcomments;
            tank1_lbl.Text = ControlDeliveries.instance.sendtank1;
            tank2_lbl.Text = ControlDeliveries.instance.sendtank2;
            total_lbl.Text = ControlDeliveries.instance.sendtotal;
            variation_lbl.Text = ControlDeliveries.instance.sendvariation;
            label22.Text = total_lbl.Text;
            //sendlorryvar
        }

        private void deliveriesprint_btn_Click(object sender, EventArgs e)
        {
            Print(this.print_pnl);
        }

        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            print_pnl = pnl;
            getprintarea(pnl);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }

        private void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.print_pnl.Width / 2), this.print_pnl.Location.Y);
        }
        Bitmap memorying;
        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(print_pnl.Width, print_pnl.Height))
            {
                print_pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"images/" + "Ledger Records " + "kjk" + ".bmp");
                MessageBox.Show("Screen snip image saved to GTS Images Folder on Desktop.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Deliveryallocation2 da2 = new Deliveryallocation2();
            da2.ShowDialog();
        }
    }
}
