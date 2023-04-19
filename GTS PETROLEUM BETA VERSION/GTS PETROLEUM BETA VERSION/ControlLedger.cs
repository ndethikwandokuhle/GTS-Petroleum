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
    public partial class ControlLedger : UserControl
    {
        public ControlLedger()
        {
            InitializeComponent();
        }

        private void ControlLedger_Load(object sender, EventArgs e)
        {
            Loadtables();
            DbConn.DisplayAndSearch("SELECT category FROM ledgercategory", ledgercategory_dgv);
            foreach (DataGridViewRow row in ledgercategory_dgv.Rows)
            {
                category.Items.Add(row.Cells[0].Value);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Clear()
        {
            ledgerdate.Value = DateTime.Now;
            entrytype.SelectedIndex = category.SelectedIndex = 0;
            description.Text = "";
            amount.Value = 0;
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Loadtables()
        {
            DbConn.DisplayAndSearch("SELECT ID, ledgerdate, category, description, debit, credit FROM ledger", ledger_dgv);
            decimal allcredits = 0;
            decimal alldebits = 0;
            for (int i = 0; i < ledger_dgv.Rows.Count; i++)
            {
                alldebits = (alldebits + decimal.Parse(ledger_dgv.Rows[i].Cells[4].Value.ToString()));
                allcredits = (allcredits + decimal.Parse(ledger_dgv.Rows[i].Cells[5].Value.ToString()));
            }
            alldr.Text = alldebits.ToString();
            allcr.Text = allcredits.ToString();
            total.Text = (alldebits - allcredits).ToString();
        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        decimal debit = 0;
        decimal credit = 0;
        string station;
        private void save_btn_Click(object sender, EventArgs e)
        {
            if ((entrytype.Text == "") || (category.Text == "") || amount.Value < 0)
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (entrytype.Text == "Debit Entry")
                {
                    debit = amount.Value;
                    credit = 0;
                }
                else if (entrytype.Text == "Credit Entry")
                {
                    credit = amount.Value;
                    debit = 0;
                }
                station = Splashscreen.instance.station;
                Saveledger();
            }
        }

        private void Saveledger()
        {
            Ledger std = new Ledger(ledgerdate.Value, entrytype.Text.Trim(), category.Text, description.Text.Trim(),
                debit, credit, station);
            DbConn.AddLedger(std);
            Clear();
            Loadtables();
            //Dashboard.instance.Loadtables();
        }

        
    }
}
