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
    public partial class GetstartedStaff : UserControl
    {
        public static GetstartedStaff instance;
        public string fullname;
        public DateTime dateofbirth;
        public string sex;
        public string position;
        public string idnumber;
        public string phone;
        public string email;
        public string password;
        public GetstartedStaff()
        {
            InitializeComponent();
            instance = this;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if ((fullname_txt.Text == "") || (sex_cbx.Text == "") || (position_cbx.Text == "") || (idno_txt.Text == "") || ((email_txt.Text == "") && (phone_txt.Text == "")) || ((password_txt.Text != confirmpassword_txt.Text)))
                MessageBox.Show("Some fields where left blank.  \r\nComplete data and try again?", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                fullname = fullname_txt.Text;
                dateofbirth = dob.Value;
                sex = sex_cbx.Text;
                position = position_cbx.Text;
                idnumber = idno_txt.Text;
                phone = phone_txt.Text;
                email = email_txt.Text;
                password = password_txt.Text;
                New_system.instance.Fromstaff();
            }
                
        }

        private void Confirmpasswords()
        {
            if(password_txt.Text == confirmpassword_txt.Text)
            {
                label1.Text = "Passwords match";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Passwords donot match";
                label1.ForeColor = Color.Red;
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            Confirmpasswords();
        }

        private void confirmpassword_txt_TextChanged(object sender, EventArgs e)
        {
            Confirmpasswords();
        }
    }
}
