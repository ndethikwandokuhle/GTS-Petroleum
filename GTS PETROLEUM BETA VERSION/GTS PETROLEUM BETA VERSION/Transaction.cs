using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Transaction
    {
        public string Companyname { get; set; }
        public string Acctype { get; set; }
        public DateTime Transdate { get; set; }
        public string Fueltype { get; set; }
        public string Transtype { get; set; }
        public string Driver { get; set; }
        public string Vehicleno { get; set; }
        public decimal Quantity { get; set; }
        public decimal Unitprice { get; set; }
        public decimal Totalprice { get; set; }


        public string Discounted { get; set; }
        public decimal Discount { get; set; }
        public decimal Discountedtotal { get; set; }


        public decimal Petrolbuy { get; set; }
        public decimal Petrol { get; set; }
        public decimal Dieselbuy { get; set; }
        public decimal Diesel { get; set; }

        public string Station { get; set; }

        public Transaction(string companyname, string acctype, DateTime transdate, string fueltype, string transtype, string driver, string vehicleno, decimal quantity, decimal unitprice, decimal totalprice, string discounted, decimal discount, decimal discountedtotal, decimal petrolbuy, decimal petrol, decimal dieselbuy, decimal diesel, string station)
        {
            Companyname = companyname;
            Acctype = acctype;
            Transdate = transdate;
            Fueltype = fueltype;
            Transtype = transtype;
            Driver = driver;
            Vehicleno = vehicleno;
            Quantity = quantity;
            Unitprice = unitprice;
            Totalprice = totalprice; 

            Discounted = discounted;
            Discount = discount;
            Discountedtotal = discountedtotal;

            Petrolbuy = petrolbuy;

            Petrol = petrol;
            Dieselbuy = dieselbuy;
            Diesel = diesel;

            Station = station;
        }
    }
}                                                                                                    