using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Feedback
    {
        public DateTime Today { get; set; }
        public string Loglevel { get; set; }
        public string Feedbacktext { get; set; }
        public string Station { get; set; }

        public Feedback(DateTime today, string loglevel, string feedbacktext, string station)
        {
            Today = today;
            Loglevel = loglevel;
            Feedbacktext = feedbacktext;
            Station = station;
        }
    }
}
