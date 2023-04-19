using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class DateChecker
    {
        public int Days;

        public DateChecker(DateTime fromDateValue, DateTime toDateValue)
        {
            var difference = toDateValue - fromDateValue;
            Days = (int)difference.TotalDays;
        }

        public override string ToString()
        {
            return $"{Days}";
        }
    }
}
