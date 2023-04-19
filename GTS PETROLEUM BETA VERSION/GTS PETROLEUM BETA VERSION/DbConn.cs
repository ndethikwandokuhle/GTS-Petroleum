using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class DbConn
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gtsdb";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                //MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return con;
        }
        //******************************************************************************************************************************************


        public static void AddStation(Station std)
        {
            string sql = "INSERT INTO station VALUES (NULL, @StationStati)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@StationStati", MySqlDbType.VarChar).Value = std.Stati;

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("S Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException)
                {
                    //MessageBox.Show("System Error; Account not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
        public static void Addopeningreadding(openingreadding std)
        {
            string sql = "INSERT INTO openingreadd VALUES (NULL, @openingreaddingDate, @openingreaddingP1m, @openingreaddingP1l, @openingreaddingP2m, @openingreaddingP2l, @openingreaddingD1m, @openingreaddingD1l, @openingreaddingD2m, @openingreaddingD2l)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@openingreaddingDate", MySqlDbType.DateTime).Value = std.Date;
                cmd.Parameters.Add("@openingreaddingP1m", MySqlDbType.Decimal).Value = std.P1m;
                cmd.Parameters.Add("@openingreaddingP1l", MySqlDbType.Decimal).Value = std.P1l;
                cmd.Parameters.Add("@openingreaddingP2m", MySqlDbType.Decimal).Value = std.P2m;
                cmd.Parameters.Add("@openingreaddingP2l", MySqlDbType.Decimal).Value = std.P2l;
                cmd.Parameters.Add("@openingreaddingD1m", MySqlDbType.Decimal).Value = std.D1m; ;
                cmd.Parameters.Add("@openingreaddingD1l", MySqlDbType.Decimal).Value = std.D1l;
                cmd.Parameters.Add("@openingreaddingD2m", MySqlDbType.Decimal).Value = std.D2m;
                cmd.Parameters.Add("@openingreaddingD2l", MySqlDbType.Decimal).Value = std.D2l;

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Opening read Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException)
                {
                    //MessageBox.Show("System Error; User not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }


        public static void AddOpeningMeter(OpeningMeter std)
        {
            string sql = "INSERT INTO openingmeter VALUES (NULL, @OpeningMeterDate, @OpeningMeterP1p1A, @OpeningMeterP1p1B, @OpeningMeterP2p1A, @OpeningMeterP2p1B, @OpeningMeterD1p1A, @OpeningMeterD1p1B, @OpeningMeterD2p1A, @OpeningMeterD2p1B, @OpeningMeterD2p2A, @OpeningMeterD2p2B)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@OpeningMeterDate", MySqlDbType.DateTime).Value = std.Date;
                cmd.Parameters.Add("@OpeningMeterP1p1A", MySqlDbType.Decimal).Value = std.P1p1A;
                cmd.Parameters.Add("@OpeningMeterP1p1B", MySqlDbType.Decimal).Value = std.P1p1B;
                cmd.Parameters.Add("@OpeningMeterP2p1A", MySqlDbType.Decimal).Value = std.P2p1A;
                cmd.Parameters.Add("@OpeningMeterP2p1B", MySqlDbType.Decimal).Value = std.P2p1B;
                cmd.Parameters.Add("@OpeningMeterD1p1A", MySqlDbType.Decimal).Value = std.D1p1A;
                cmd.Parameters.Add("@OpeningMeterD1p1B", MySqlDbType.Decimal).Value = std.D1p1B;
                cmd.Parameters.Add("@OpeningMeterD2p1A", MySqlDbType.Decimal).Value = std.D2p1A;
                cmd.Parameters.Add("@OpeningMeterD2p1B", MySqlDbType.Decimal).Value = std.D2p1B;
                cmd.Parameters.Add("@OpeningMeterD2p2A", MySqlDbType.Decimal).Value = std.D2p2A;
                cmd.Parameters.Add("@OpeningMeterD2p2B", MySqlDbType.Decimal).Value = std.D2p2B;

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Opening read Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException)
                {
                    //MessageBox.Show("System Error; User not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }



        //******************************************************************************************************************************************


        public static void AddDelivery(Delivery std)
        {
            string sql = "INSERT INTO deliveries VALUES (NULL, @DeliveryDeliverydate,@DeliveryType,@DeliverySupplier,@DeliveryDriver,@DeliveryLorryno, @DeliveryInvoiceno,@DeliveryDnoteno, @DeliveryDnoteqty,@DeliveryLorryread,@DeliveryComments,@DeliveryLorryvariation,@DeliveryLorryflag, @DeliveryT1dipbeforem,@DeliveryT1dipafterm,@DeliveryT1dipbeforel,@DeliveryT1dipafterl,@DeliveryT1sideAbefore,@DeliveryT1sideAafter,@DeliveryT1sideBbefore,@DeliveryT1sideBafter,@DeliveryTank1pumpmeter,@DeliveryTank1receieved, @DeliveryT2dipbeforem, @DeliveryT2dipafterm, @DeliveryT2dipbeforel,@DeliveryT2dipfterl,@DeliveryT2sideAbefore, @DeliveryT2sideAafter,@DeliveryT2sideBbefore, @DeliveryT2sideBafter,@DeliveryTank2pumpmeter, @DeliveryTank2receieved, @DeliveryTankflag,  @DeliveryTnakflagstatus, @DeliveryQtybefore ,@DeliveryQtyafter, @DeliveryQtymove, @DeliveryQtyreceived, @DeliveryVariation, @DeliveryStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@DeliveryDeliveryDate", MySqlDbType.DateTime).Value = std.Deliverydate;
                cmd.Parameters.Add("@DeliveryType", MySqlDbType.VarChar).Value = std.Type;
                cmd.Parameters.Add("@DeliverySupplier", MySqlDbType.VarChar).Value = std.Supplier;
                cmd.Parameters.Add("@DeliveryDriver", MySqlDbType.VarChar).Value = std.Driver;
                cmd.Parameters.Add("@DeliveryLorryno", MySqlDbType.VarChar).Value = std.Lorryno;
                cmd.Parameters.Add("@DeliveryInvoiceno", MySqlDbType.VarChar).Value = std.Invoiceno;
                cmd.Parameters.Add("@DeliveryDnoteno", MySqlDbType.VarChar).Value = std.Dnoteno;
                cmd.Parameters.Add("@DeliveryDnoteqty", MySqlDbType.Decimal).Value = std.Dnoteqty;
                cmd.Parameters.Add("@DeliveryLorryread", MySqlDbType.Decimal).Value = std.Lorryread;
                cmd.Parameters.Add("@DeliveryComments", MySqlDbType.VarChar).Value = std.Comments;
                cmd.Parameters.Add("@DeliveryLorryvariation", MySqlDbType.Decimal).Value = std.Lorryvariation;
                cmd.Parameters.Add("@DeliveryLorryflag", MySqlDbType.VarChar).Value = std.Lorryflag;
                cmd.Parameters.Add("@DeliveryT1dipbeforem", MySqlDbType.Decimal).Value = std.T1dipbeforem;
                cmd.Parameters.Add("@DeliveryT1dipafterm", MySqlDbType.Decimal).Value = std.T1dipafterm;
                cmd.Parameters.Add("@DeliveryT1dipbeforel", MySqlDbType.Decimal).Value = std.T1dipbeforel;
                cmd.Parameters.Add("@DeliveryT1dipafterl", MySqlDbType.Decimal).Value = std.T1dipafterl;
                cmd.Parameters.Add("@DeliveryT1sideAbefore", MySqlDbType.Decimal).Value = std.T1sideAbefore;
                cmd.Parameters.Add("@DeliveryT1sideAafter", MySqlDbType.Decimal).Value = std.T1sideAafter;
                cmd.Parameters.Add("@DeliveryT1sideBbefore", MySqlDbType.Decimal).Value = std.T1sideBbefore;
                cmd.Parameters.Add("@DeliveryT1sideBafter", MySqlDbType.Decimal).Value = std.T1sideBafter;
                cmd.Parameters.Add("@DeliveryTank1pumpmeter", MySqlDbType.Decimal).Value = std.Tank1pumpmeter;
                cmd.Parameters.Add("@DeliveryTank1receieved", MySqlDbType.Decimal).Value = std.Tank1receieved;
                cmd.Parameters.Add("@DeliveryT2dipbeforem", MySqlDbType.Decimal).Value = std.T2dipbeforem;
                cmd.Parameters.Add("@DeliveryT2dipafterm", MySqlDbType.Decimal).Value = std.T2dipafterm;
                cmd.Parameters.Add("@DeliveryT2dipbeforel", MySqlDbType.Decimal).Value = std.T2dipbeforel;
                cmd.Parameters.Add("@DeliveryT2dipfterl", MySqlDbType.Decimal).Value = std.T2dipfterl;
                cmd.Parameters.Add("@DeliveryT2sideAbefore", MySqlDbType.Decimal).Value = std.T2sideAbefore;
                cmd.Parameters.Add("@DeliveryT2sideAafter", MySqlDbType.Decimal).Value = std.T2sideAafter;
                cmd.Parameters.Add("@DeliveryT2sideBbefore", MySqlDbType.Decimal).Value = std.T2sideBbefore;
                cmd.Parameters.Add("@DeliveryT2sideBafter", MySqlDbType.Decimal).Value = std.T2sideBafter;
                cmd.Parameters.Add("@DeliveryTank2pumpmeter", MySqlDbType.Decimal).Value = std.Tank2pumpmeter;
                cmd.Parameters.Add("@DeliveryTank2receieved", MySqlDbType.Decimal).Value = std.Tank2receieved;
                cmd.Parameters.Add("@DeliveryTankflag", MySqlDbType.Decimal).Value = std.Tankflag;
                cmd.Parameters.Add("@DeliveryTnakflagstatus", MySqlDbType.VarChar).Value = std.Tnakflagstatus;
                cmd.Parameters.Add("@DeliveryQtybefore", MySqlDbType.Decimal).Value = std.Qtybefore;
                cmd.Parameters.Add("@DeliveryQtyafter", MySqlDbType.Decimal).Value = std.Qtyafter;
                cmd.Parameters.Add("@DeliveryQtymove", MySqlDbType.Decimal).Value = std.Qtymove;
                cmd.Parameters.Add("@DeliveryQtyreceived", MySqlDbType.Decimal).Value = std.Qtyreceived;
                cmd.Parameters.Add("@DeliveryVariation", MySqlDbType.Decimal).Value = std.Variation;
                cmd.Parameters.Add("@DeliveryStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delivery Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Delivery not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }


        public static void AddReading(Reading std)
        {
            string sql = "INSERT INTO reading VALUES (NULL, @ReadingReadingdate,@ReadingTankname,@ReadingAutoopenmeters,@ReadingAutoopemlitres,@ReadingManualopenmeters, @ReadingManualopenlitres, @ReadingVariationmeters, @ReadingVariationlitres, @ReadingClosedipmeters, @ReadingClosediplitres, @ReadingMovementmeters, @ReadingMovementlitres, @ReadingComments, @ReadingVariationflag, @ReadingMovementflag, @ReadingStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ReadingReadingdate", MySqlDbType.DateTime).Value = std.Readingdate;
                cmd.Parameters.Add("@ReadingTankname", MySqlDbType.VarChar).Value = std.Tankname;
                cmd.Parameters.Add("@ReadingAutoopenmeters", MySqlDbType.Decimal).Value = std.Autoopenmeters;
                cmd.Parameters.Add("@ReadingAutoopemlitres", MySqlDbType.Decimal).Value = std.Autoopenlitres;
                cmd.Parameters.Add("@ReadingManualopenmeters", MySqlDbType.Decimal).Value = std.Manualopenmeters;
                cmd.Parameters.Add("@ReadingManualopenlitres", MySqlDbType.Decimal).Value = std.Manualopenlitres; ;
                cmd.Parameters.Add("@ReadingVariationmeters", MySqlDbType.Decimal).Value = std.Variationmeters;
                cmd.Parameters.Add("@ReadingVariationlitres", MySqlDbType.Decimal).Value = std.Variationlitres;
                cmd.Parameters.Add("@ReadingClosedipmeters", MySqlDbType.Decimal).Value = std.Closedipmeters;
                cmd.Parameters.Add("@ReadingClosediplitres", MySqlDbType.Decimal).Value = std.Closediplitres;
                cmd.Parameters.Add("@ReadingMovementmeters", MySqlDbType.Decimal).Value = std.Movementmeters;
                cmd.Parameters.Add("@ReadingMovementlitres", MySqlDbType.Decimal).Value = std.Movementlitres;
                cmd.Parameters.Add("@ReadingComments", MySqlDbType.VarChar).Value = std.Comments;
                cmd.Parameters.Add("@ReadingVariationflag", MySqlDbType.VarChar).Value = std.Variationflag;
                cmd.Parameters.Add("@ReadingMovementflag", MySqlDbType.VarChar).Value = std.Movementflag;
                cmd.Parameters.Add("@ReadingStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reading Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Reading not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void AddAccounts(Accounts std)
        {
            string sql = "INSERT INTO accounts VALUES (NULL, @AccountsDatee, @AccountsAcctype, @AccountsCompanyname, @AccountsCompanyaddress, @AccountsCompanyphone, @AccountsHandler, @AccountsCompanyemail, @AccountsStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@AccountsDatee", MySqlDbType.DateTime).Value = std.Datee;
                cmd.Parameters.Add("@AccountsAcctype", MySqlDbType.VarChar).Value = std.Acctype;
                cmd.Parameters.Add("@AccountsCompanyname", MySqlDbType.VarChar).Value = std.Companyname;
                cmd.Parameters.Add("@AccountsCompanyaddress", MySqlDbType.VarChar).Value = std.Companyaddress;
                cmd.Parameters.Add("@AccountsCompanyphone", MySqlDbType.VarChar).Value = std.Companyphone;
                cmd.Parameters.Add("@AccountsHandler", MySqlDbType.VarChar).Value = std.Handler; ;
                cmd.Parameters.Add("@AccountsCompanyemail", MySqlDbType.VarChar).Value = std.Companyemail;
                cmd.Parameters.Add("@AccountsStation", MySqlDbType.VarChar).Value = std.Station;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            con.Close();
        }

        public static void UpdateAccount(Accounts std, string id)
        {
            string sql = "Update accounts SET date = @AccountsDatee, acctype = @AccountsAcctype, companyname = @AccountsCompanyname, companyaddress = @AccountsCompanyaddress, companyphone = @AccountsCompanyphone,  handler = @AccountsHandler, companyemail = @AccountsCompanyemail, station = @AccountsStation WHERE ID ='" + id + "'";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@AccountsID", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@AccountsDatee", MySqlDbType.DateTime).Value = std.Datee;
                cmd.Parameters.Add("@AccountsAcctype", MySqlDbType.VarChar).Value = std.Acctype;
                cmd.Parameters.Add("@AccountsCompanyname", MySqlDbType.VarChar).Value = std.Companyname;
                cmd.Parameters.Add("@AccountsCompanyaddress", MySqlDbType.VarChar).Value = std.Companyaddress;
                cmd.Parameters.Add("@AccountsCompanyphone", MySqlDbType.VarChar).Value = std.Companyphone;
                cmd.Parameters.Add("@AccountsHandler", MySqlDbType.VarChar).Value = std.Handler; ;
                cmd.Parameters.Add("@AccountsCompanyemail", MySqlDbType.VarChar).Value = std.Companyemail;
                cmd.Parameters.Add("@AccountsStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Account not added. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            con.Close();
        }


        public static void AddSaleProfile(SaleProfile std)
        {
            string sql = "INSERT INTO saleprofile VALUES (NULL, @SaleProfileDate, @SaleProfileFullname, @SaleProfileSupervisor, @SaleProfilePhone, @SaleProfileIdnumber, @SaleProfileSales, @SaleProfileShortages, @SaleProfileSettled, @SaleProfileStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@SaleProfileDate", MySqlDbType.DateTime).Value = std.Date;
                cmd.Parameters.Add("@SaleProfileFullname", MySqlDbType.VarChar).Value = std.Fullname;
                cmd.Parameters.Add("@SaleProfileSupervisor", MySqlDbType.VarChar).Value = std.Supervisor;
                cmd.Parameters.Add("@SaleProfilePhone", MySqlDbType.VarChar).Value = std.Phone;
                cmd.Parameters.Add("@SaleProfileIdnumber", MySqlDbType.VarChar).Value = std.Idnumber;
                cmd.Parameters.Add("@SaleProfileSales", MySqlDbType.Decimal).Value = std.Sales; 
                cmd.Parameters.Add("@SaleProfileShortages", MySqlDbType.Decimal).Value = std.Shortages;
                cmd.Parameters.Add("@SaleProfileSettled", MySqlDbType.Decimal).Value = std.Settled;
                cmd.Parameters.Add("@SaleProfileStation", MySqlDbType.VarChar).Value = std.Station;

                
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale profile Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            con.Close();
        }


        public static void UpdateSaleProfile(SaleProfile std, string id)
        {                                                                                                                                                                                       
            string sql = "Update saleprofile SET date = @SaleProfileDate, fullname = @SaleProfileFullname, supervisor = @SaleProfileSupervisor, phone = @SaleProfilePhone, idnumber = @SaleProfileIdnumber, sales = @SaleProfileSales, shortages = @SaleProfileShortages, settled = @SaleProfileSettled, station = @SaleProfileStation WHERE ID ='" + id + "'";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@AccountsID", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@SaleProfileDate", MySqlDbType.DateTime).Value = std.Date;
                cmd.Parameters.Add("@SaleProfileFullname", MySqlDbType.VarChar).Value = std.Fullname;
                cmd.Parameters.Add("@SaleProfileSupervisor", MySqlDbType.VarChar).Value = std.Supervisor;
                cmd.Parameters.Add("@SaleProfilePhone", MySqlDbType.VarChar).Value = std.Phone;
                cmd.Parameters.Add("@SaleProfileIdnumber", MySqlDbType.VarChar).Value = std.Idnumber;
                cmd.Parameters.Add("@SaleProfileSales", MySqlDbType.Decimal).Value = std.Sales;
                cmd.Parameters.Add("@SaleProfileShortages", MySqlDbType.Decimal).Value = std.Shortages;
                cmd.Parameters.Add("@SaleProfileSettled", MySqlDbType.Decimal).Value = std.Settled;
                cmd.Parameters.Add("@SaleProfileStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale profile Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; User not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }


        public static void AddTransaction(Transaction std)
        {
            string sql = "INSERT INTO transaction VALUES (NULL, @TransactionCompanyname, @TransactionAcctype, @TransactionTransdate, @TransactionFueltype, @TransactionTranstype, @TransactionDriver, @TransactionVehicleno, @TransactionQuantity, @TransactionUnitprice, @TransactionTotalprice, @TransactionDiscounted, @TransactionDiscount, @TransactionDiscountedtotal, @TransactionPetrolbuy,  @TransactionPetrol, @TransactionDieselbuy, @TransactionDiesel, @TransactionStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@TransactionCompanyname", MySqlDbType.VarChar).Value = std.Companyname;
                cmd.Parameters.Add("@TransactionAcctype", MySqlDbType.VarChar).Value = std.Acctype;
                cmd.Parameters.Add("@TransactionTransdate", MySqlDbType.DateTime).Value = std.Transdate;
                cmd.Parameters.Add("@TransactionFueltype", MySqlDbType.VarChar).Value = std.Fueltype;
                cmd.Parameters.Add("@TransactionTranstype", MySqlDbType.VarChar).Value = std.Transtype;
                cmd.Parameters.Add("@TransactionDriver", MySqlDbType.VarChar).Value = std.Driver;
                cmd.Parameters.Add("@TransactionVehicleno", MySqlDbType.VarChar).Value = std.Vehicleno;
                cmd.Parameters.Add("@TransactionQuantity", MySqlDbType.Decimal).Value = std.Quantity; 
                cmd.Parameters.Add("@TransactionUnitprice", MySqlDbType.Decimal).Value = std.Unitprice;
                cmd.Parameters.Add("@TransactionTotalprice", MySqlDbType.Decimal).Value = std.Totalprice;
                cmd.Parameters.Add("@TransactionDiscounted", MySqlDbType.VarChar).Value = std.Discounted;
                cmd.Parameters.Add("@TransactionDiscount", MySqlDbType.Decimal).Value = std.Discount;
                cmd.Parameters.Add("@TransactionDiscountedtotal", MySqlDbType.Decimal).Value = std.Discountedtotal;
                cmd.Parameters.Add("@TransactionPetrolbuy", MySqlDbType.Decimal).Value = std.Petrolbuy;
                cmd.Parameters.Add("@TransactionPetrol", MySqlDbType.Decimal).Value = std.Petrol;
                cmd.Parameters.Add("@TransactionDieselbuy", MySqlDbType.Decimal).Value = std.Dieselbuy;
                cmd.Parameters.Add("@TransactionDiesel", MySqlDbType.Decimal).Value = std.Diesel;
                cmd.Parameters.Add("@TransactionStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Transaction not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void AddLedger(Ledger std)
        {
            string sql = "INSERT INTO ledger VALUES (NULL, @LedgerLedgerdate, @LedgerEntrytype, @LedgerCategory, @LedgerDescription, @LedgerDebit, @LedgerCredit, @LedgerStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@LedgerLedgerdate", MySqlDbType.DateTime).Value = std.Ledgerdate;
                cmd.Parameters.Add("@LedgerEntrytype", MySqlDbType.VarChar).Value = std.Entrytype;
                cmd.Parameters.Add("@LedgerCategory", MySqlDbType.VarChar).Value = std.Category;
                cmd.Parameters.Add("@LedgerDescription", MySqlDbType.VarChar).Value = std.Description;
                cmd.Parameters.Add("@LedgerDebit", MySqlDbType.Decimal).Value = std.Debit;
                cmd.Parameters.Add("@LedgerCredit", MySqlDbType.Decimal).Value = std.Credit; ;
                cmd.Parameters.Add("@LedgerStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ledger record Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Ledegr record not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void AddSale(Sale std)
        {
            string sql = "INSERT INTO sales VALUES (NULL, @SaleSaledate,@SaleTankname,@SalePumpname,@SaleOpenqty,@SaleSideaopen, @SaleSideaclose," +
                "@SaleSideasale, @SaleSidebopen,@SaleSidebclose,@SaleSidebsale,@SaleTotalsales,@SaleAmount, @SaleDipopenm,@SaleDipclosem," +
                "@SaleDipopenl,@SaleDipclosel,@SaleDipmovement,@SalePumpstock,@SaleDipstock,@SaleVariation,@SaleCashsubmitted,@SaleCashshort,@SaleCashtotal,@SaleSupervisor," +
                " @SaleAttendant,@SalePrepaid,@SalePostpaid, @SaleStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@SaleSaledate", MySqlDbType.DateTime).Value = std.Saledate;
                cmd.Parameters.Add("@SaleTankname", MySqlDbType.VarChar).Value = std.Tankname;
                cmd.Parameters.Add("@SalePumpname", MySqlDbType.VarChar).Value = std.Pumpname;
                cmd.Parameters.Add("@SaleOpenqty", MySqlDbType.VarChar).Value = std.Openinglitres;
                cmd.Parameters.Add("@SaleSideaopen", MySqlDbType.VarChar).Value = std.Sideaopen;
                cmd.Parameters.Add("@SaleSideaclose", MySqlDbType.Decimal).Value = std.Sideaclose;
                cmd.Parameters.Add("@SaleSideasale", MySqlDbType.VarChar).Value = std.Sideasale;
                cmd.Parameters.Add("@SaleSidebopen", MySqlDbType.VarChar).Value = std.Sidebopen;
                cmd.Parameters.Add("@SaleSidebclose", MySqlDbType.Decimal).Value = std.Sidebclose;
                cmd.Parameters.Add("@SaleSidebsale", MySqlDbType.VarChar).Value = std.Sidebsale;
                cmd.Parameters.Add("@SaleTotalsales", MySqlDbType.VarChar).Value = std.Totalsales;
                cmd.Parameters.Add("@SaleAmount", MySqlDbType.VarChar).Value = std.Amount;
                cmd.Parameters.Add("@SaleDipopenm", MySqlDbType.VarChar).Value = std.Dipopenm;
                cmd.Parameters.Add("@SaleDipclosem", MySqlDbType.VarChar).Value = std.Dipclosem;
                cmd.Parameters.Add("@SaleDipopenl", MySqlDbType.VarChar).Value = std.Dipopenl;
                cmd.Parameters.Add("@SaleDipclosel", MySqlDbType.VarChar).Value = std.Dipclosel;
                cmd.Parameters.Add("@SaleDipmovement", MySqlDbType.VarChar).Value = std.Dipmovement;
                cmd.Parameters.Add("@SalePumpstock", MySqlDbType.VarChar).Value = std.Pumpstock;
                cmd.Parameters.Add("@SaleDipstock", MySqlDbType.VarChar).Value = std.Dipstock;
                cmd.Parameters.Add("@SaleVariation", MySqlDbType.VarChar).Value = std.Variation;
                cmd.Parameters.Add("@SaleCashsubmitted", MySqlDbType.Decimal).Value = std.Cashsubmitted;
                cmd.Parameters.Add("@SaleCashshort", MySqlDbType.VarChar).Value = std.Cashshort;
                cmd.Parameters.Add("@SaleCashtotal", MySqlDbType.VarChar).Value = std.Cashtotal;
                cmd.Parameters.Add("@SaleSupervisor", MySqlDbType.VarChar).Value = std.Supervisor;
                cmd.Parameters.Add("@SaleAttendant", MySqlDbType.VarChar).Value = std.Attendant;
                cmd.Parameters.Add("@SalePrepaid", MySqlDbType.Decimal).Value = std.Prepaid;
                cmd.Parameters.Add("@SalePostpaid", MySqlDbType.Decimal).Value = std.Postpaid;
                cmd.Parameters.Add("@SaleStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sale Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Sale not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }


        //MAINTENANCE QUERY

        public static void AddUser(User std)
        {
            string sql = "INSERT INTO users VALUES (NULL, @UserFullname, @UserDate, @UserSex, @UserPosition, @UserIDNumber, @UserPhone, @UserEmail, @UserPassword, @UserStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@UserFullname", MySqlDbType.VarChar).Value = std.Fullname;
                cmd.Parameters.Add("@UserDate", MySqlDbType.DateTime).Value = std.DOB;
                cmd.Parameters.Add("@UserSex", MySqlDbType.VarChar).Value = std.Sex;
                cmd.Parameters.Add("@UserPosition", MySqlDbType.VarChar).Value = std.Position;
                cmd.Parameters.Add("@UserIDNumber", MySqlDbType.VarChar).Value = std.IDNumber;
                cmd.Parameters.Add("@UserPhone", MySqlDbType.VarChar).Value = std.Phone; ;
                cmd.Parameters.Add("@UserEmail", MySqlDbType.VarChar).Value = std.Email;
                cmd.Parameters.Add("@UserPassword", MySqlDbType.VarChar).Value = std.Password;
                cmd.Parameters.Add("@UserStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; User not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void AddEmployee(Employee std)
        {
            string sql = "INSERT INTO employee VALUES (NULL, @EmployeeFullname, @EmployeeDOB, @EmployeeSex, @EmployeePosition, @EmployeeIDNumber, @EmployeePhone, @EmployeeEmail, @EmployeePassword, @EmployeeStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@EmployeeFullname", MySqlDbType.VarChar).Value = std.Fullname;
                cmd.Parameters.Add("@EmployeeDOB", MySqlDbType.DateTime).Value = std.DOB;
                cmd.Parameters.Add("@EmployeeSex", MySqlDbType.VarChar).Value = std.Sex;
                cmd.Parameters.Add("@EmployeePosition", MySqlDbType.VarChar).Value = std.Position;
                cmd.Parameters.Add("@EmployeeIDNumber", MySqlDbType.VarChar).Value = std.IDNumber;
                cmd.Parameters.Add("@EmployeePhone", MySqlDbType.VarChar).Value = std.Phone; ;
                cmd.Parameters.Add("@EmployeeEmail", MySqlDbType.VarChar).Value = std.Email;
                cmd.Parameters.Add("@EmployeePassword", MySqlDbType.VarChar).Value = std.Password;
                cmd.Parameters.Add("@EmployeeStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Employee not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }


        public static void AddLedgercategory(Ledgercategory std)
        {
            string sql = "INSERT INTO ledgercategory VALUES (NULL, @LedgercategoryToday, @LedgercategoryCategory, @LedgercategoryDescription)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@LedgercategoryToday", MySqlDbType.DateTime).Value = std.Today;
                cmd.Parameters.Add("@LedgercategoryCategory", MySqlDbType.VarChar).Value = std.Category;
                cmd.Parameters.Add("@LedgercategoryDescription", MySqlDbType.VarChar).Value = std.Description;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Category Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Category not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void AddFeedback(Feedback std)
        {
            string sql = "INSERT INTO feedback VALUES (NULL, @FeedbackToday, @FeedbackLoglevel, @FeedbackFeedbacktext, @FeedbackStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@FeedbackToday", MySqlDbType.DateTime).Value = std.Today;
                cmd.Parameters.Add("@FeedbackLoglevel", MySqlDbType.VarChar).Value = std.Loglevel;
                cmd.Parameters.Add("@FeedbackFeedbacktext", MySqlDbType.VarChar).Value = std.Feedbacktext;
                cmd.Parameters.Add("@FeedbackStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Feedback Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Feed not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        public static void AddRates(Rates std)
        {
            string sql = "INSERT INTO rates VALUES (NULL, @RatesToday, @RatesPetrol, @RatesDiesel, @RatesStation)";
            MySqlConnection con = GetConnection();
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@RatesToday", MySqlDbType.DateTime).Value = std.Today;
                cmd.Parameters.Add("@RatesPetrol", MySqlDbType.Decimal).Value = std.Petrol;
                cmd.Parameters.Add("@RatesDiesel", MySqlDbType.Decimal).Value = std.Diesel;
                cmd.Parameters.Add("@RatesStation", MySqlDbType.VarChar).Value = std.Station;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rates Saved Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("System Error; Rates not added. \n" + ex.Message, "SAVING ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        //********************************SEARCH DATABASES
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            try
            {
                string sql = query;
                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl;
                con.Close();
            }
            catch (Exception)
            {
                //Application.Exit();
            }
            
        }

    }
}