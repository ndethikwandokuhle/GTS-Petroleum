using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Sale
    {
        public DateTime Saledate { get; set; }
        public string Tankname { get; set; }
        public string Pumpname { get; set; }
        public string Openinglitres { get; set; }
        public string Sideaopen { get; set; }
        public decimal Sideaclose { get; set; }
        public string Sideasale { get; set; }
        public string Sidebopen { get; set; }
        public decimal Sidebclose { get; set; }
        public string Sidebsale { get; set; }
        public string Totalsales { get; set; }
        public string Amount { get; set; }
        public string Dipopenm { get; set; }
        public string Dipclosem { get; set; }
        public string Dipopenl { get; set; }
        public string Dipclosel { get; set; }
        public string Dipmovement { get; set; }
        public string Pumpstock { get; set; }
        public string Dipstock { get; set; }
        public string Variation { get; set; }
        public decimal Cashsubmitted { get; set; }
        public string Cashshort { get; set; }
        public string Cashtotal { get; set; }
        public string Supervisor { get; set; }
        public string Attendant { get; set; }
        public decimal Prepaid { get; set; }
        public decimal Postpaid { get; set; }
        public string Station { get; set; }

        public Sale(DateTime saledate, string tankname, string pumpname, string openinglitres, string sideaopen, decimal sideaclose, string sideasale, string sidebopen, decimal sidebclose, string sidebsale, string totalsales, string amount, string dipopenm, string dipclosem, string dipopenl, string dipclosel, string dipmovement, string pumpstock, string dipstock, string variation, decimal cashsubmitted, string cashshort, string cashtotal, string supervisor ,string attendant, decimal prepaid, decimal postpaid, string station)
        {
            Saledate = saledate;
            Tankname = tankname;
            Pumpname = pumpname;
            Openinglitres = openinglitres;
            Sideaopen = sideaopen;
            Sideaclose = sideaclose;
            Sideasale = sideasale;
            Sidebopen = sidebopen;
            Sidebclose = sidebclose;
            Sidebsale = sidebsale;
            Totalsales = totalsales;
            Amount = amount;
            Dipopenm = dipopenm;
            Dipclosem = dipclosem;
            Dipopenl = dipopenl;
            Dipclosel = dipclosel;
            Dipmovement = dipmovement;
            Pumpstock = pumpstock;
            Dipstock = dipstock;
            Variation = variation;
            Cashsubmitted = cashsubmitted;
            Cashshort = cashshort;
            Cashtotal = cashtotal;
            Supervisor = supervisor;
            Attendant = attendant;
            Prepaid = prepaid;
            Postpaid = postpaid;
            Station = station;
        }
    }
}