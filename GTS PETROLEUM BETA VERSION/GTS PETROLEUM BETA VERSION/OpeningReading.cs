using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class openingreadding
    {
        public DateTime Date { get; set; }
        public decimal P1m { get; set; }
        public decimal P1l { get; set; }
        public decimal P2m { get; set; }
        public decimal P2l { get; set; }
        public decimal D1m { get; set; }
        public decimal D1l { get; set; }
        public decimal D2m { get; set; }
        public decimal D2l { get; set; }

        public openingreadding(DateTime date, decimal p1m, decimal p1l, decimal p2m, decimal p2l, decimal d1m, decimal d1l, decimal d2m, decimal d2l)
        {
            Date = date;
            P1m = p1m;
            P1l = p1l;
            P2m = p2m;
            P2l = p2l;
            D1m = d1m;
            D1l = d1l;
            D2m = d2m;
            D2l = d2l;
        }
    }
}
