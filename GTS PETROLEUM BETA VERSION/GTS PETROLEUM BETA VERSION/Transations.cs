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
    public partial class Transations : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public Transations()
        {
            InitializeComponent();
        }
        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT transdate, fueltype, transtype, driver, vehicleno, qty, unitprice, totalprice, discounted, discount, discountedtotal, petrolbuy, petrol, dieselbuy, diesel FROM transaction WHERE companyname LIKE '%" + namecompany + "%'", transactions_gdv);
            //string deposited = "Deposit";
            //string refuell = "Refuel";
            DbConn.DisplayAndSearch("SELECT qty, petrolbuy, petrol, dieselbuy, diesel FROM transaction  WHERE companyname LIKE '%" + namecompany + "%'ORDER BY id DESC LIMIT 1", values_dgv);
            //DbConn.DisplayAndSearch("SELECT qty, petrolbuy, petrol, dieselbuy, diesel FROM transaction WHERE transtype LIKE'%" + refuell + "%' ORDER BY id DESC LIMIT 1", values_dgv);
            decimal totalpaid = 0;
            decimal totalpetrol = 0;
            decimal totaldiesel = 0;

            //TOTAL MONEY PAID
            for (int i = 0; i < transactions_gdv.Rows.Count; i++)
            {
                totalpaid = (totalpaid+decimal.Parse(transactions_gdv.Rows[i].Cells[10].Value.ToString()));
            }
            label9.Text = "USD"+totalpaid.ToString();

            //TOTAL PETROL
            for (int i = 0; i < transactions_gdv.Rows.Count; i++)
            {
                totalpetrol = (totalpetrol + decimal.Parse(transactions_gdv.Rows[i].Cells[11].Value.ToString()));
            }
            label19.Text = totalpetrol.ToString();

            //TOTAL DIESEL
            for (int i = 0; i < transactions_gdv.Rows.Count; i++)
            {
                totaldiesel = (totaldiesel + decimal.Parse(transactions_gdv.Rows[i].Cells[13].Value.ToString()));
            }
            label32.Text = totaldiesel.ToString();
            //decimal totalprice = decimal.Parse(label9.Text);
            //decimal totalprice = decimal.Parse(label9.Text);
            //label24.Text = Label;
            if (values_dgv.Rows.Count > 0)
            {
                label27.Text = values_dgv.Rows[0].Cells[2].Value.ToString();
                label34.Text = values_dgv.Rows[0].Cells[4].Value.ToString();
                label24.Text = transactions_gdv.Rows.Count.ToString();

                string status;
                if((decimal.Parse(label34.Text) < 0) || (decimal.Parse(label27.Text) < 0))
                {
                    status = "One or more fuel balances are negative";
                    label35.Text = status;
                }
                else
                {
                    status = "Fuel balances still positive";
                    label35.Text = status;
                }
            }
            else
            {
                label27.Text = "0.00";
                label34.Text = "0.00";
            }


        }

         string namecompany;
         string addresscompany;
         string phonecompany;
         string emailcompany;
         string typeaccount;


        decimal petrol;
        decimal diesel;
        string station = Splashscreen.instance.station;
        

        private void Clear()
        {
            fueltype_cbx.SelectedIndex = transacttype_cbx.SelectedIndex = 0;
            driver_txt.Text = vehicleno_txt.Text = "";
            quantity.Value = amountpaid.Value = 0;
            unitprice_lbl.Text = totaldue_lbl.Text = "0.00";

            petrolbuy = petroll = dieselbuy = diesell = 0;
            discounted_cbx.SelectedIndex = 1;
            discount.Value = 0;
            grandtotal.Text = "0.00";
        }

        private void Assignvalues()
        {
            if(transacttype_cbx.Text == "Deposit")
            {
                //extracting for fuel balances - petrol
                decimal petrolbal =0;
                decimal dieselbal=0;
                if (values_dgv.Rows.Count > 0) {
                    petrolbal = decimal.Parse(values_dgv.Rows[0].Cells[2].Value.ToString());
                    dieselbal = decimal.Parse(values_dgv.Rows[0].Cells[4].Value.ToString());
                }

                if (fueltype_cbx.Text == "Petrol") {
                    petroll = petrolbal + decimal.Parse(equivqty_lbl.Text);
                    petrolbuy = decimal.Parse(equivqty_lbl.Text);
                    //retain diesel detail
                    diesell = dieselbal;
                    dieselbuy = 0;
                }
                else if (fueltype_cbx.Text == "Diesel") {
                    diesell = dieselbal + decimal.Parse(equivqty_lbl.Text);
                    dieselbuy = decimal.Parse(equivqty_lbl.Text);
                    //retain petrol bal
                    petroll = petrolbal;
                    petrolbuy = 0;
                }
            }
            else if (transacttype_cbx.Text == "Refuel")
            {
                //extracting for fuel balances - petrol
                decimal petrolbal = 0;
                decimal dieselbal = 0;
                if (values_dgv.Rows.Count > 0)
                {
                    petrolbal = decimal.Parse(values_dgv.Rows[0].Cells[2].Value.ToString());
                    dieselbal = decimal.Parse(values_dgv.Rows[0].Cells[4].Value.ToString());
                }

                if (fueltype_cbx.Text == "Petrol")
                {
                    petroll = petrolbal - quantity.Value;
                    petrolbuy = 0;
                    //retain diesel detail
                    diesell = dieselbal;
                    dieselbuy = 0;
                }
                else if (fueltype_cbx.Text == "Diesel")
                {
                    diesell = dieselbal - quantity.Value;
                    dieselbuy = 0;
                    //retain petrol bal
                    petroll = petrolbal;
                    petrolbuy = 0;
                }

            }
        }

        private void fueltype_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbConn.DisplayAndSearch("SELECT petrol, diesel FROM rates ORDER BY id DESC LIMIT 1", rates_dgv);
            if (rates_dgv.Rows.Count > 0)
            {
                petrol = decimal.Parse(rates_dgv.Rows[0].Cells[0].Value.ToString());
                diesel = decimal.Parse(rates_dgv.Rows[0].Cells[1].Value.ToString());
            }
            if (fueltype_cbx.Text == "Petrol")
                unitprice_lbl.Text = petrol.ToString();
            else if (fueltype_cbx.Text == "Diesel")
                unitprice_lbl.Text = diesel.ToString();
            else
                unitprice_lbl.Text = "0.00";
        }


        decimal diesell = 0;
        decimal petroll = 0;
        decimal dieselbuy = 0;
        decimal petrolbuy = 0;
        private void Savetransaction()
        {
            decimal quants;
            decimal unitprice = 0;
            decimal totaldue = 0;
            decimal equivlitres = 0;
            if (transacttype_cbx.Text == "Deposit")
            {
                quants = 0;
                unitprice = Convert.ToDecimal(unitprice_lbl.Text);
                totaldue = Convert.ToDecimal(amountpaid.Value);
            }
            else
            {
                unitprice = Convert.ToDecimal(unitprice_lbl.Text);
                totaldue = Convert.ToDecimal(totaldue_lbl.Text);
                equivlitres = Convert.ToDecimal(equivqty_lbl.Text);
                quants = quantity.Value;
            }
                
            Assignvalues();
            
            Transaction std = new Transaction(namecompany, typeaccount, transactdate_date.Value, fueltype_cbx.Text.Trim(), transacttype_cbx.Text.Trim(), driver_txt.Text.Trim(),
                vehicleno_txt.Text.Trim(), quants, unitprice, totaldue, discounted_cbx.Text, discount.Value, decimal.Parse(grandtotal.Text),
                petrolbuy, petroll, dieselbuy, diesell, station);
            DbConn.AddTransaction(std);
            Loadtables();
            Clear();
            Dashboard.instance.Loadtables();
            quants = unitprice = totaldue = 0;
        }

        private void Transations_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label39.Text = now.ToString("dddd, MMMM dd");

            diesell = 0;
            petroll = 0;
            dieselbuy = 0;
            petrolbuy = 0;

            discounted_cbx.SelectedIndex = 0;
            refuel_pnl.Visible = false;
            deposit_pnl.Visible = false;
            starttrans_pnl.Visible = true;
            transactions_pnl.Width = 0;
            //assigning foreign values
            namecompany = ControlAccount.instance.namecompany;
            addresscompany = ControlAccount.instance.addresscompany;
            phonecompany = ControlAccount.instance.phonecompany;
            emailcompany = ControlAccount.instance.emailcompany;
            typeaccount = ControlAccount.instance.typeaccount;

            label3.Text = namecompany;
            label4.Text = addresscompany;
            label7.Text = ControlAccount.instance.handler;
            id_text.Text = ControlAccount.instance.recordid;

            Loadtables();
        }

        private void transacttype_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(transacttype_cbx.Text == "Refuel")
            {
                if((fueltype_cbx.Text == "")||(transacttype_cbx.Text == ""))
                    MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    refuel_pnl.Visible = true;
                    deposit_pnl.Visible = false;
                    starttrans_pnl.Visible = false;
                }
                
            }
            else if (transacttype_cbx.Text == "Deposit")
            {
                driver_txt.Text = vehicleno_txt.Text = "";
                quantity.Value = amountpaid.Value = 0;
                //unitprice_lbl.Text = totaldue_lbl.Text = "0.00";

                refuel_pnl.Visible = false;
                deposit_pnl.Visible = true;
                starttrans_pnl.Visible = false;
            }
            else
            {
                driver_txt.Text = vehicleno_txt.Text = "";
                quantity.Value = amountpaid.Value = 0;
                //unitprice_lbl.Text = totaldue_lbl.Text = "0.00";

                refuel_pnl.Visible = false;
                 deposit_pnl.Visible = false;
                 starttrans_pnl.Visible = true;
            }
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            decimal x = (quantity.Value * decimal.Parse(unitprice_lbl.Text));
            totaldue_lbl.Text = x.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            transactions_gdv.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
            transactions_pnl.Width = 0;
        }

        private void addne_btn_Click(object sender, EventArgs e)
        {
            transactions_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (transactions_pnl.Width < 350)
                transactions_pnl.Width += 50;
            else
                timer1.Stop();
        }

        private void discounted_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (discounted_cbx.SelectedIndex == 1)
                discount.Enabled = true;
            else
            {
                discount.Enabled = false;
                grandtotal.Text = "0.00";
                discount.Value = 0;
            }
                
        }

        private void discount_ValueChanged(object sender, EventArgs e)
        {
            decimal figure = decimal.Parse(amountpaid.Text);
            decimal discounted = (discount.Value / 100) * figure;
            decimal qty = figure - discounted;
            decimal rndqty = Math.Round(qty, 2);
            grandtotal.Text = rndqty.ToString();
        }

        private void amountpaid_ValueChanged(object sender, EventArgs e)
        {
            decimal x = decimal.Parse(unitprice_lbl.Text);
            decimal qty = amountpaid.Value / x;
            decimal rndqty = Math.Round(qty,2);
            equivqty_lbl.Text = rndqty.ToString();
        }

        private void savetrans_btn_Click(object sender, EventArgs e)
        {
            if(transacttype_cbx.Text == "Refuel")
            {
                if ((quantity.Value < 1)||(driver_txt.Text=="")||(vehicleno_txt.Text == ""))
                    MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Savetransaction();
            }
            else if(transacttype_cbx.Text == "Deposit")
            {
                if (amountpaid.Value < 1)
                    MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Savetransaction();
            }
            else
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(prnt_pnl.Width, prnt_pnl.Height))
            {
                //string x = DateTime.Now.ToString().Replace("/", " ");
                prnt_pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"images/" + "Account Statement " + label39.Text + ".bmp");
                MessageBox.Show("Screen snip image saved to GTS Images Folder on Desktop.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            Print(this.prnt_pnl);
        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            prnt_pnl = pnl;
            getprintarea(pnl);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }

        private void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 1) - (this.prnt_pnl.Width / 1), this.prnt_pnl.Location.Y);
        }
        Bitmap memorying;
        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
