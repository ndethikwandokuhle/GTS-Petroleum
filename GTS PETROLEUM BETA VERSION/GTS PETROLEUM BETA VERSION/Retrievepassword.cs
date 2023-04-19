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
    public partial class Retrievepassword : Form
    {
        public Retrievepassword()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(230, Color.Black);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void email_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionality disabled for offline version.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
