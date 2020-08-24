using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFILE
{
    class IndiaStateCensusData
    {
        [Name("State")]
        public string state { get; set; }

        [Name("Population")]
        public string population { get; set; }

        [Name("AreaInSqKm")]
        public double areaInSqKm { get; set; }

        [Name("DensityPerSqKm")]
        public double densityPerSqKm { get; set; }

        public override string ToString()
        {
            return state + " " + population + + areaInSqKm + " " + densityPerSqKm;
        }
    }
}
