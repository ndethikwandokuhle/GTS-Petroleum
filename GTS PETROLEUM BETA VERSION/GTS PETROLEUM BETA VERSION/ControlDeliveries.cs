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
    public partial class ControlDeliveries : UserControl
    {
        public static ControlDeliveries instance;
        public string deliveryid;
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


        public string senddate;
        public string sendtype;
        public string sendsupplier;
        public string senddriver;
        public string sendlorryno;
        public string sendinvoice;
        public string senddnotno;
        public string senddnoteqty;
        public string sendlorryqty;
        public string sendcomments;
        public string sendlorryvar;
        public string sendtank1;
        public string sendtank2;
        public string sendtotal;
        public string sendvariation;
        public ControlDeliveries()
        {
            InitializeComponent();
            instance = this;
        }

        private void Clearaftersave()
        {
            //deliverydate.Value;
            type.SelectedIndex = 0;
            supplier.Text = "";
            driver.Text = "";
            lorryno.Text = "";
            invoiceno.Text = "";
            dnotnumber.Text = "";
            dnoteqty.Value = lorryread.Value = 0;
            comments.Text = "";
        }
        //Database functions
        public void Loadtables()
        {
            Clearaftersave();
            DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier, driver, lorryno,invoiceno, dnoteno, dnoteqty, lorryqty, comments, lorryvar, t1received, t2received, qtyreceived, variation FROM deliveries", deliveries_gdv);
            //DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier,                  invoiceno, dnoteno, dnoteqty,  FROM deliveries WHERE ID LIKE'%" + deliveryid + "%'", dataGridView1);
        }

        //******************************************************************************
        //******************************************************************************
        //*************************************************************************************************************************
        private void ControlDeliveries_Load(object sender, EventArgs e)
        {
            Loadtables();
            //hiding data entry panels on form load
            //allocation_pnl.Width = 0;
            delivery_pnl.Width = 0;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            deliverydate.Value = DateTime.Today;
            type.SelectedIndex = 0;
            supplier.Text = driver.Text = lorryno.Text = comments.Text = dnotnumber.Text = invoiceno.Text = "";
            dnoteqty.Value = lorryread.Value = 0;
                //t1dipb4m.Value = t1dipb4l.Value = t1sideAbefore.Value = t1sideAafter.Value = t1dipaftm.Value = t2dipbeforem.Value = t2dipafterm.Value = t2dipbeforel.Value = t2dipfterl.Value = t2p1sideAafter.Value = t2p1sideAbefore.Value = t2p1sideBafter.Value = t2p1sideBbefore.Value = t2p2sideAafter.Value = t2p2sideAbefore.Value = t2p2sideBafter.Value = t2p2sideBbefore.Value = 0;
            //total_lbl.Text = "...";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void addnew_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            deliveries_gdv.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void allocate_btn_Click(object sender, EventArgs e)
        {
            if((type.Text!="")&&(supplier.Text!="")&&(driver.Text != "")&&(lorryno.Text != "")&&(dnotnumber.Text != ""))
            {
                if ((dnoteqty.Value > 100) && (lorryread.Value > 100))
                {
                    if (deliveries_gdv.Rows.Count > 0)
                    {
                        MessageBox.Show("Delivery with same D-NOTE Number has already been recorded.  \r\nVerify DNote Number and try again.", "DATA DUPLICATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //deliveryid;
                        deliveryday = deliverydate.Value;
                        deliverytype = type.Text;
                        deliverysupplier = supplier.Text;
                        deliverydriver = driver.Text;
                        deliverylorrynumber = lorryno.Text;
                        deliveryinvoiceno = invoiceno.Text;
                        deliverydnoteno = dnotnumber.Text;
                        deliverydnoteqty = dnoteqty.Value;
                        deliverylorryqty = lorryread.Value;
                        deliverycomments = comments.Text;
                        //selecting available tanks by station
                        Delliveryallocation da = new Delliveryallocation();
                        da.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Values not accurate. Quantity received cannot be less than 100l.  \r\nCorrect data entry and try again.", "INACCURATE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Some fields were left empty.  \r\nComplete data entry and try again.", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (delivery_pnl.Width < 260)
            {
                delivery_pnl.Width += 20;
                //deliveries_gdv.AutoResizeColumn(fmode)
            }
            else
                timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if ((type.Text!="")||(supplier.Text!="")||(driver.Text !="")||(lorryno.Text!="")||(invoiceno.Text!="")||(dnotnumber.Text!=""))
            {
                if (MessageBox.Show("Are you sure you want to exit application?  \r\nClick YES to proceed?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                       //allocation_pnl.Width = 0;
                    //delivery_pnl.Width = 0;
                    delivery_pnl.Width = 0;
                    deliveries_gdv.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    Clear();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to exit application?  \r\nClick YES to proceed?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //allocation_pnl.Width = 0;
                    //delivery_pnl.Width = 0;
                    delivery_pnl.Width = 0;
                    deliveries_gdv.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    Clear();
                }
            }

            
        }

        private void tankdata_btn_Click(object sender, EventArgs e)
        {
            //Tankdata td = new Tankdata();
            //td.ShowDialog();
            //MessageBox.Show("Some data maybe missing.  \r\nComplete server configuration and try again.", "DATA Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //check if essential data is captured
            
        }
        //string deliverID;
private void deliveries_gdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //firstname, prisonnumber, dob, mother, father, village, qualification, education, nationality, status, kinfullname, phone1, 

                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = deliveries_gdv.Rows[e.RowIndex];
                    deliveryid = dgvRow.Cells[0].Value.ToString();

                    
                    //MessageBox.Show(dgvRow.Cells[0].Value.ToString());
                    
                }
                if (MessageBox.Show("Proceed to view delivery information?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Assignvalues();
                    DeliveryInfor di = new DeliveryInfor();
                    di.ShowDialog();
                }
            }
        }

        private void Assignvalues()
        {
            senddate = deliveries_gdv.Rows[0].Cells[1].Value.ToString();
            sendtype = deliveries_gdv.Rows[0].Cells[2].Value.ToString();
            sendsupplier = deliveries_gdv.Rows[0].Cells[3].Value.ToString();
            senddriver = deliveries_gdv.Rows[0].Cells[4].Value.ToString();
            sendlorryno = deliveries_gdv.Rows[0].Cells[5].Value.ToString();
            sendinvoice = deliveries_gdv.Rows[0].Cells[6].Value.ToString();
            senddnotno = deliveries_gdv.Rows[0].Cells[7].Value.ToString();
            senddnoteqty = deliveries_gdv.Rows[0].Cells[8].Value.ToString();
            sendlorryqty = deliveries_gdv.Rows[0].Cells[9].Value.ToString();
            sendcomments = deliveries_gdv.Rows[0].Cells[10].Value.ToString();
            sendlorryvar = deliveries_gdv.Rows[0].Cells[11].Value.ToString();
            sendtank1 = deliveries_gdv.Rows[0].Cells[12].Value.ToString();
            sendtank2 = deliveries_gdv.Rows[0].Cells[13].Value.ToString();
            sendtotal = deliveries_gdv.Rows[0].Cells[14].Value.ToString();
            sendvariation = deliveries_gdv.Rows[0].Cells[15].Value.ToString();
        }

        //*****************************************************************************************************
        //*****************************************************************************************************
        //*****************************************************************************************************
        //*****************************************************************************************************
        //TANK BALANCES

        private void CalculateTank1()
        {
            //decimal tank1quantity_by_dips = t1dipaftl.Value - t1dipb4l.Value;
            //tank1quantity_by_pumpmeter = ((t1sideAafter.Value - t1sideAbefore.Value) + (t1sideBafter.Value - t1sideBbefore.Value));
            //tank1receieved = tank1quantity_by_dips + tank1quantity_by_pumpmeter;

        }

        private void CalcualteTank2()
        {
            //decimal tank2quantity_by_dips = t2dipfterl.Value - t2dipbeforel.Value;
            //decimal tank2quantity_by_pumpmeter = ((t2p1sideAafter.Value - t2p1sideAbefore.Value) + (t2p1sideBafter.Value - t2p1sideBbefore.Value));
            //tank2_2quantity_by_pumpmeter = ((t2p2sideAafter.Value - t2p2sideAbefore.Value) + (t2p2sideBafter.Value - t2p2sideBbefore.Value));

            //tank2receieved = tank2quantity_by_dips + tank2quantity_by_pumpmeter+ tank2_2quantity_by_pumpmeter;
        }


        //Calculating the difference between quantity on dnote and quantity on tanks after allocation. Jus returns a message of awareness to the user
        private void Recieved_vs_Dnote()
        {
            
        }

        private void recordtank1_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void recordtank2_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void dnotnumber_TextChanged(object sender, EventArgs e)
        {
            DbConn.DisplayAndSearch("SELECT ID, deliverydate, fueltype, supplier, invoiceno, dnoteno, dnoteqty, qtyreceived FROM deliveries WHERE dnoteno LIKE'%" + dnotnumber.Text + "%'", deliveries_gdv);
        }

        //*********************************************************************************************************************************
        //*********************************************************************************************************************************
        //*********************************************************************************************************************************
    }
}
