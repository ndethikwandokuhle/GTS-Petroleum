using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Delivery
    {
        public DateTime Deliverydate { get; set; }
        public string Type { get; set; }
        public string Supplier { get; set; }
        public string Driver { get; set; }
        public string Lorryno { get; set; }
        public string Invoiceno { get; set; }
        public string Dnoteno { get; set; }
        public decimal Dnoteqty { get; set; }
        public decimal Lorryread { get; set; }
        public string Comments { get; set; }
        public decimal Lorryvariation { get; set; }
        public string Lorryflag { get; set; }
        public decimal T1dipbeforem { get; set; }
        public decimal T1dipafterm { get; set; }
        public decimal T1dipbeforel { get; set; }
        public decimal T1dipafterl { get; set; }
        public decimal T1sideAbefore { get; set; }
        public decimal T1sideAafter { get; set; }
        public decimal T1sideBbefore { get; set; }
        public decimal T1sideBafter { get; set; }
        public decimal Tank1pumpmeter { get; set; }
        public decimal Tank1receieved { get; set; }
        public decimal T2dipbeforem { get; set; }
        public decimal T2dipafterm { get; set; }
        public decimal T2dipbeforel { get; set; }
        public decimal T2dipfterl { get; set; }
        public decimal T2sideAbefore { get; set; }
        public decimal T2sideAafter { get; set; }
        public decimal T2sideBbefore { get; set; }
        public decimal T2sideBafter { get; set; }
        public decimal Tank2pumpmeter { get; set; }
        public decimal Tank2receieved { get; set; }
        public decimal Tankflag { get; set; }
        public string Tnakflagstatus { get; set; }
        public decimal Qtybefore { get; set; }
        public decimal Qtyafter { get; set; }
        public decimal Qtymove { get; set; }
        public decimal Qtyreceived { get; set; }
        public decimal Variation { get; set; }
        public string Station { get; set; }

        public Delivery(DateTime deliverydate, string type, string supplier, string driver, string lorryno, string invoiceno, string dnoteno, decimal dnoteqty, 
            decimal lorryread, string comments, decimal lorryvariation, string lorryflag, decimal t1dipbeforem, decimal t1dipafterm, decimal t1dipbeforel, decimal t1dipafterl,
            decimal t1sideAbefore, decimal t1sideAafter, decimal t1sideBbefore, decimal t1sideBafter, decimal tank1pumpmeter, decimal tank1receieved, decimal t2dipbeforem, 
            decimal t2dipafterm, decimal t2dipbeforel, decimal t2dipfterl, decimal t2sideAbefore, decimal t2sideAafter, decimal t2sideBbefore, decimal t2sideBafter,
            decimal tankfalg, string tankflagstatus, decimal tank2pumpmeter, decimal tank2receieved, 
            decimal qtybefore, decimal qtyafter, decimal qtymove, decimal qtyreceived, decimal variation, string station)
        {
            Deliverydate = deliverydate;
            Type = type;
            Supplier = supplier;
            Driver = driver;
            Lorryno = lorryno;
            Invoiceno = invoiceno;
            Dnoteno = dnoteno;
            Dnoteqty = dnoteqty;
            Lorryread = lorryread;
            Comments = comments;
            Lorryvariation = lorryvariation;
            Lorryflag = lorryflag;
            T1dipbeforem = t1dipbeforem;
            T1dipafterm = t1dipafterm;
            T1dipbeforel = t1dipbeforel;
            T1dipafterl = t1dipafterl;
            T1sideAbefore = t1sideAbefore;
            T1sideAafter = t1sideAafter;
            T1sideBbefore = t1sideBbefore;
            T1sideBafter = t1sideBafter;
            Tank1pumpmeter = tank1pumpmeter;
            Tank1receieved = tank1receieved;
            T2dipbeforem = t2dipbeforem;
            T2dipafterm = t2dipafterm;
            T2dipbeforel = t2dipbeforel;
            T2dipfterl = t2dipfterl;
            T2sideAbefore = t2sideAbefore;
            T2sideAafter = t2sideAafter;
            T2sideBbefore = t2sideBbefore;
            T2sideBafter = t2sideBafter;
            Tank2pumpmeter = tank2pumpmeter;
            Tank2receieved = tank2receieved;
            Tankflag = tankfalg;
            Tnakflagstatus = tankflagstatus;
            Qtybefore = qtybefore;
            Qtyafter = qtyafter;
            Qtymove = qtymove;
            Qtyreceived = qtyreceived;
            Variation = variation;
            Station = station;
        }
    }
}
