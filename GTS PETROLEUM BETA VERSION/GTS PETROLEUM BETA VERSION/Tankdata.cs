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
    public partial class Tankdata : Form
    {
        public Tankdata()
        {
            InitializeComponent();
        }

        private void selecttank_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (selecttank_cbx.SelectedIndex == 0)
            //    tankname_lbl.Text = "--Select Tank";
            //else
            //    tankname_lbl.Text = selecttank_cbx.Text;
        }

        private void chart_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void table_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
    }
}
