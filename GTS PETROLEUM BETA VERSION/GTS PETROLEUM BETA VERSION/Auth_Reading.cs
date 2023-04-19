using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Auth_Reading
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public Auth_Reading(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;

            Sum(num1, num2);
        }

        public static int Sum(int dig1, int dig2)
        {
            return dig1 + dig2;
        }
    }
}
