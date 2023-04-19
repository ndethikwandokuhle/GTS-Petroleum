using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS_PETROLEUM_BETA_VERSION
{
    class Reading
    {
        public DateTime Readingdate { get; set; }
        public string Tankname { get; set; }
        public decimal Autoopenmeters { get; set; }
        public decimal Autoopenlitres { get; set; }
        public decimal Manualopenmeters { get; set; }
        public decimal Manualopenlitres { get; set; }
        public decimal Variationmeters { get; set; }
        public decimal Variationlitres { get; set; }
        public decimal Closedipmeters { get; set; }
        public decimal Closediplitres { get; set; }
        public decimal Movementmeters { get; set; }
        public decimal Movementlitres { get; set; }
        public string Comments { get; set; }
        public string Variationflag { get; set; }
        public string Movementflag { get; set; }
        public string Station { get; set; }

        public Reading(DateTime readingdate, string tankname, decimal autoopenmeters, decimal autoopenlitres, decimal manualopenmeters, decimal manualopenlitres, decimal variationmeters,
            decimal variationlitres, decimal closedipmeters, decimal closediplitres, decimal movementmeters, decimal movementlitres, string comments, string variationflag, string movementflag, string station)
        {
            Readingdate = readingdate;
            Tankname = tankname;
            Autoopenmeters = autoopenmeters;
            Autoopenlitres = autoopenlitres;
            Manualopenmeters = manualopenmeters;
            Manualopenlitres = manualopenlitres;
            Variationmeters = variationmeters;
            Variationlitres = variationlitres;
            Closedipmeters = closedipmeters;
            Closediplitres = closediplitres;
            Movementmeters = movementmeters;
            Movementlitres = movementlitres;
            Comments = comments;
            Variationflag = variationflag;
            Movementflag = movementflag;
            Station = station;
        }
    }
}
