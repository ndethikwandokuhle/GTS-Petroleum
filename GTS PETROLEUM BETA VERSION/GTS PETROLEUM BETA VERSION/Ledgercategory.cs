using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Ledgercategory
    {
        public DateTime Today { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Ledgercategory(DateTime today, string category, string description)
        {
            Today = today;
            Category = category;
            Description = description;
        }
    }
}
