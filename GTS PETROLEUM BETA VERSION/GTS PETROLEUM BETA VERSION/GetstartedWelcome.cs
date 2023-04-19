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
    public partial class GetstartedWelcome : UserControl
    {
        public GetstartedWelcome()
        {
            InitializeComponent();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            New_system.instance.Fromwelcome();
        }
    }
}
