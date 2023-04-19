using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class SaleProfile
    {
        public DateTime Date { get; set; }
        public string Fullname { get; set; }
        public string Supervisor { get; set; }
        public string Phone { get; set; }
        public string Idnumber { get; set; }
        public decimal Sales { get; set; }
        public decimal Shortages { get; set; }
        public decimal Settled { get; set; }
        public string Station { get; set; }


        public SaleProfile(DateTime date, string fullname, string supervisor, string phone, string idnumber, decimal sales, decimal shortages, decimal settled,  string station)
        {
            Date = date;
            Fullname = fullname;
            Supervisor = supervisor;
            Phone = phone;
            Idnumber = idnumber;
            Sales = sales;
            Shortages = shortages;
            Settled = settled;
            Station = station;
        }
    }
}
