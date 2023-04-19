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
    public partial class Delliveryallocation : Form
    {
        public Delliveryallocation()
        {
            InitializeComponent();
        }
        public int deliveryid;
        public DateTime deliveryday;
        public string deliverytype;
        public string deliverysupplier;
        public string deliverydriver;
        public string deliverylorrynumber;
        public string deliveryinvoiceno;
        public string deliverydnoteno;
        public decimal deliverydnoteqty;
        public decimal deliverylorryqty;
        public string deliverycomments;
        decimal lorryflag;
        string lorryflagstatus;
        decimal tankflag;
        string tankflagstatus;

        //decimal tank1receieved = 0;
        //decimal tank2receieved = 0;
        //decimal lorryvariation = 0;
        //string lorryflagged = "No";
        //string tankflagged = "No";
        //decimal tank1quantity_by_pumpmeter = 0;
        //decimal tank2_2quantity_by_pumpmeter = 0;
        //decimal totalrecievedfuel = 0;
        //decimal tanksvariation = 0;
        //string station;
        decimal variation;
        string station = Splashscreen.instance.station;
        private void login_btn_Click(object sender, EventArgs e)
        {
            //calculations
            Calculations();

            //get variation
            variation = (Convert.ToDecimal(label51.Text) - Convert.ToDecimal(label25.Text));
            if (variation < 0)
                variation *= -1;

            if (variation > 10)
                MessageBox.Show("Variation between received fuel and allocated fuel is more than 10 litres.  \r\nClick OK to proceed.", "FUEL VARIATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Calculate lorry flag
            lorryflagstatus = "No";
            lorryflag = deliverylorryqty - deliverydnoteqty;
            if (lorryflag < 0)
                lorryflagstatus = "Yes";

            //Calculate tank flag
            tankflagstatus = "No";
            tankflag = deliverylorryqty - deliverydnoteqty;
            if (tankflag < 0)
                tankflagstatus = "Yes";

            if (t1dipaftl.Value >= t1dipb4l.Value)
            {
                if (t2dipafterl.Value >= t2dipbeforel.Value)
                {
                    if(t1sideAafter.Value >= t1sideAbefore.Value)
                    {
                        if (t1sideBafter.Value >= t1sideBbefore.Value)
                        {
                            if (t2sideAafter.Value >= t2sideAbefore.Value)
                            {
                                if (t2sideBafter.Value >= t2sideBbefore.Value)
                                {
                                    Savedelivery();
                                }
                                else
                                    MessageBox.Show("Tank 2 Pump quantity for side B before refill cannot be more than quantity after refill.  \r\nVerify data and try again.", "TANK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Tank 2 Pump quantity for side A before refill cannot be more than quantity after refill.  \r\nVerify data and try again.", "TANK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Tank 1 Pump quantity for side B before refill cannot be more than quantity after refill.  \r\nVerify data and try again.", "TANK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Tank 1 Pump quantity for side A before refill cannot be more than quantity after refill.  \r\nVerify data and try again.", "TANK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Tank 2 quantity before refill cannot be more than quantity after refill.  \r\nVerify data and try again.", "TANK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tank 1 quantity before refill cannot be more than quantity after refill.  \r\nVerify data and try again.", "TANK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Savedelivery()
        {
        Delivery std = new Delivery(deliveryday, deliverytype, deliverysupplier, deliverydriver, deliverylorrynumber, deliveryinvoiceno,
            deliverydnoteno, deliverydnoteqty, deliverylorryqty, deliverycomments, lorryflag, lorryflagstatus, t1dipb4m.Value, t1dipaftm.Value, t1dipb4l.Value, t1dipaftl.Value, 
            t1sideAbefore.Value, t1sideAafter.Value, t1sideBbefore.Value, t1sideBafter.Value, decimal.Parse(label45.Text), decimal.Parse(label49.Text), t2dipbeforem.Value, 
            t2dipafterm.Value, t2dipbeforel.Value, t2dipafterl.Value, t2sideAbefore.Value, t2sideAafter.Value, t2sideBbefore.Value, t2sideBafter.Value, tankflag, tankflagstatus,
            decimal.Parse(label48.Text), decimal.Parse(label50.Text), decimal.Parse(label30.Text), decimal.Parse(label31.Text), decimal.Parse(label32.Text), decimal.Parse(label51.Text), variation, station);
            DbConn.AddDelivery(std);
            ControlDeliveries.instance.Loadtables();
            this.Close();
            //Dashboard.instance.Loadtables();
        }

        private void recordtank1_btn_Click(object sender, EventArgs e)
        {
            //CalculateTank1();
            ////total_lbl.Text = (tank1receieved + tank2receieved).ToString();
            //totalrecievedfuel = tank1receieved + tank2receieved;
            //Recieved_vs_Dnote();
        }

        private void recordtank2_btn_Click(object sender, EventArgs e)
        {
            //CalcualteTank2();
            ////total_lbl.Text = (tank1receieved + tank2receieved).ToString();
            //totalrecievedfuel = tank1receieved + tank2receieved;
            //Recieved_vs_Dnote();
        }

        private void Delliveryallocation_Load(object sender, EventArgs e)
        {
            deliveryday = ControlDeliveries.instance.deliveryday;
            deliverytype = ControlDeliveries.instance.deliverytype;
            deliverysupplier = ControlDeliveries.instance.deliverysupplier;
            deliverydriver = ControlDeliveries.instance.deliverydriver;
            deliverylorrynumber = ControlDeliveries.instance.deliverylorrynumber;
            deliveryinvoiceno = ControlDeliveries.instance.deliveryinvoiceno;
            deliverydnoteno = ControlDeliveries.instance.deliverydnoteno;
            deliverydnoteqty = ControlDeliveries.instance.deliverydnoteqty;
            deliverylorryqty = ControlDeliveries.instance.deliverylorryqty;
            deliverycomments = ControlDeliveries.instance.deliverycomments;

            label25.Text = deliverydnoteqty.ToString();
            
        }

        private void Calculations()
        {
            label43.Text = t1dipb4l.Value.ToString();
            label46.Text = t2dipbeforel.Value.ToString();
            label44.Text = t1dipaftl.Value.ToString();
            label47.Text = t2dipafterl.Value.ToString();
            decimal t1 = ((t1sideAafter.Value - t1sideAbefore.Value) + (t1sideBafter.Value - t1sideBbefore.Value));
            label45.Text = t1.ToString();
            decimal t2 = ((t2sideAafter.Value - t2sideAbefore.Value) + (t2sideBafter.Value - t2sideBbefore.Value));
            label48.Text = t2.ToString();
            label30.Text = ((Convert.ToDecimal(label43.Text) + Convert.ToDecimal(label46.Text))).ToString();
            label31.Text = ((Convert.ToDecimal(label44.Text) + Convert.ToDecimal(label47.Text))).ToString();
            label32.Text = ((Convert.ToDecimal(label45.Text) + Convert.ToDecimal(label48.Text))).ToString();
            label49.Text = (Convert.ToDecimal(label45.Text)+(Convert.ToDecimal(label44.Text) - Convert.ToDecimal(label43.Text))).ToString();
            label50.Text = (Convert.ToDecimal(label48.Text) + (Convert.ToDecimal(label47.Text) - Convert.ToDecimal(label46.Text))).ToString();
            label51.Text = ((Convert.ToDecimal(label49.Text) + Convert.ToDecimal(label50.Text))).ToString();

        }

        private void t1dipb4l_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t1dipaftl_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t2dipbeforel_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t2dipafterl_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t1sideAbefore_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t1sideBbefore_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t1sideAafter_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t1sideBafter_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t2sideAbefore_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t2sideBbefore_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t2sideAafter_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void t2sideBafter_ValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }
    }
}
