using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public Enums.DayType DayType { get; set; }
        public double Probability { get; set; }
        public double CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public void setter(Enums.DayType DT,double P,ref double cumSum,ref int minRange)
        {
            this.DayType = DT;
            this.Probability = P;
            cumSum += P;
            this.CummProbability = cumSum;
            this.MinRange = minRange;
            this.MaxRange = int.Parse((cumSum * 100).ToString());
            minRange = this.MaxRange + 1;
            if (cumSum == 1)
            {
                this.MaxRange = 0;
                minRange = 0;
            }
        }
    }
}
