using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Accounts
    {
        public DateTime Datee { get; set; }
        public string Acctype { get; set; }
        public string Companyname { get; set; }
        public string Companyaddress { get; set; }
        public string Companyphone { get; set; }
        public string Handler { get; set; }
        public string Companyemail { get; set; }
        public string Station { get; set; }

        public Accounts(DateTime datee, string acctype, string companyname, string companyaddress, string companyphone, string handler, string companyemail, string station)
        {
            Datee = datee;
            Acctype = acctype;
            Companyname = companyname;
            Companyaddress = companyaddress;
            Companyphone = companyphone;
            Handler = handler;
            Companyemail = companyemail;
            Station = station;
        }
    }
}
