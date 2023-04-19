using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Rates
    {
        public DateTime Today { get; set; }
        public decimal Petrol { get; set; }
        public decimal Diesel { get; set; }
        public string Station { get; set; }

        public Rates(DateTime today, decimal petrol, decimal diesel, string station)
        {
            Today = today;
            Petrol = petrol;
            Diesel = diesel;
            Station = station;
        }
    }
}
