using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class User
    {
        public string Fullname { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Position { get; set; }
        public string IDNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Station { get; set; }

        public User(string fullname, DateTime dob, string sex, string position, string idnumber, string phone, string email, string password, string station)
        {
            Fullname = fullname;
            DOB = dob;
            Sex = sex;
            Position = position;
            IDNumber = idnumber;
            Phone = phone;
            Email = email;
            Password = password;
            Station = station;
        }
    }
}
