using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Ledger
    {
        public DateTime Ledgerdate { get; set; }
        public string Entrytype { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Station { get; set; }

        public Ledger(DateTime ledgerdate, string entrytype, string category, string description, decimal debit, decimal credit, string station)
        {
            Ledgerdate = ledgerdate;
            Entrytype = entrytype;
            Category = category;
            Description = description;
            Debit = debit;
            Credit = credit;
            Station = station;
        }
    }
}
