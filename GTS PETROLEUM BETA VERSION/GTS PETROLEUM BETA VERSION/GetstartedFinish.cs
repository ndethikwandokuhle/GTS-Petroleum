using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class GetstartedFinish : UserControl
    {
        public GetstartedFinish()
        {
            InitializeComponent();
        }


        //station data
            string station;

        //staff data
        string fullname;
        DateTime dob;
        string sex;
        string position;
        string idnumber;
        string phone;
        string email;
        string password;

        //rates data
        decimal petrol;
        decimal diesel;

        //meter reading data
        decimal p1p1a;
        decimal p1p1b;
        decimal p2p1a;
        decimal p2p1b;
        decimal d1p1a;
        decimal d1p1b;
        decimal d2p1a;
        decimal d2p1b;
        decimal d2p2a;
        decimal d2p2b;

        //dip readings
        decimal p1m;
        decimal p2m;
        decimal p1l;
        decimal p2l;
        decimal d1m;
        decimal d2m;
        decimal d1l;
        decimal d2l;


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Getstartedalldata gsdata = new Getstartedalldata();
            gsdata.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //station data
            station = GetstartedStation.instance.station;
            
            //staff data
            fullname = GetstartedStaff.instance.fullname;
            dob = GetstartedStaff.instance.dateofbirth;
            sex = GetstartedStaff.instance.sex;
            position = GetstartedStaff.instance.position;
            idnumber = GetstartedStaff.instance.idnumber;
            phone = GetstartedStaff.instance.phone;
            email = GetstartedStaff.instance.email;
            password = GetstartedStaff.instance.password;

            //rates data
            petrol = GetstartedRates.instance.petrolprice;
            diesel = GetstartedRates.instance.dieselprice;

            //meter reading data
            p1p1a = GetstartedMeterreading.instance.petrol_1pump1a;
            p1p1b = GetstartedMeterreading.instance.petrol_1pump1b;
            p2p1a = GetstartedMeterreading.instance.petrol_2pump1a;
            p2p1b = GetstartedMeterreading.instance.petrol_2pump1b;
            d1p1a = GetstartedMeterreading.instance.diesel_1pump1a;
            d1p1b = GetstartedMeterreading.instance.diesel_1pump1b;
            d2p1a = GetstartedMeterreading.instance.diesel_2pump1a;
            d2p1b = GetstartedMeterreading.instance.diesel_2pump1b;
            d2p2a = GetstartedMeterreading.instance.diesel_2pump2a;
            d2p2b = GetstartedMeterreading.instance.diesel_2pump2b;

            //dip readings
            p1m = GetstartedDipreading.instance.petrol_1meter;
            p2m = GetstartedDipreading.instance.petrol_1litre;
            p1l = GetstartedDipreading.instance.petrol_2meter;
            p2l = GetstartedDipreading.instance.petrol_2litre;
            d1m = GetstartedDipreading.instance.diesel_1meter;
            d2m = GetstartedDipreading.instance.diesel_1litre;
            d1l = GetstartedDipreading.instance.diesel_2meter;
            d2l = GetstartedDipreading.instance.diesel_2litre;

            Savestation();
            Saverates();
            Saveusers();
            Savedip();
            Savemeter();
            Iamclosing();
            this.Hide();
        }

        private void Savestation()
        {
            Station std = new Station(station);
            DbConn.AddStation(std);
        }

        private void Saverates()
        {
            string stati = station;
            DateTime date = DateTime.Now;
            Rates std = new Rates(date, petrol, diesel, stati);
            DbConn.AddRates(std);
        }
        private void Saveusers()
        {  
            User std = new User(fullname, dob, sex, position, idnumber,phone, email, password, station);
            DbConn.AddUser(std);
        }
        private void Savedip()
        {
            DateTime date = DateTime.Now;
            openingreadding std = new openingreadding(date, p1m, p1l, p2m, p2l, d1m, d1l, d2m, d2l);
            DbConn.Addopeningreadding(std);
        }
        private void Savemeter()
        {
            DateTime date = DateTime.Now;
            OpeningMeter std = new OpeningMeter(date, p1p1a,p1p1b, p2p1a, p2p1b, d1p1a, d1p1b, d2p1a, d2p1b, d2p2a, d2p2b);
            DbConn.AddOpeningMeter(std);
        }
        public void Iamclosing()
        {
           New_system.instance.Callmeonclosing();
        }
    }
}
