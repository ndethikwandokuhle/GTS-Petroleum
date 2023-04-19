using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class OpeningMeter
    {
        public DateTime Date { get; set; }
        public decimal P1p1A { get; set; }
        public decimal P1p1B { get; set; }
        public decimal P2p1A { get; set; }
        public decimal P2p1B { get; set; }
        public decimal D1p1A { get; set; }
        public decimal D1p1B { get; set; }
        public decimal D2p1A { get; set; }
        public decimal D2p1B { get; set; }
        public decimal D2p2A { get; set; }
        public decimal D2p2B { get; set; }

        public OpeningMeter(DateTime date, decimal p1p1a, decimal p1p1b, decimal p2p1a, decimal p2p1b, decimal d1p1a, decimal d1p1b, decimal d2p1a, decimal d2p1b, decimal d2p2a, decimal d2p2b)
        {
            Date = date;
            P1p1A = p1p1a;
            P1p1B = p1p1b;
            P2p1A = p2p1a;
            P2p1B = p2p1b;
            D1p1A = d1p1a;
            D1p1B = d1p1b;
            D2p1A = d2p1a;
            D2p1B = d2p1b;
            D2p2A = d2p2a;
            D2p2B = d2p2b;
        }
    }
}
