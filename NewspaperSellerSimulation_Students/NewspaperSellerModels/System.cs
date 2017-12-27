using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NewspaperSellerModels;

namespace NewspaperSellerModels
{
    public class System
    {
        public bool importDataFromFile { get; set; }
        public fileBuffer fb { get; set; }
        public bool[] invalidprob;
        public void setterSystem()
        {
            invalidprob = new bool[3] { false, false, false };
            fb = new fileBuffer();
            importDataFromFile = false;
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationCases = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        public System()
        {
            invalidprob = new bool[3] { false, false, false };
            fb = new fileBuffer();
            importDataFromFile = false;
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationCases = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }
        public double ScrapPrice { get; set; }
        public double UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DayTypeDistribution> daystypeFill(List<Enums.DayType> DT, List<double> P)
        {
            List<DayTypeDistribution> res = new List<DayTypeDistribution>();
            double cumSum = 0;
            int minRange = 1, count = DT.Count;
            for (int i = 0; i < count; ++i)
            {
                DayTypeDistribution item = new DayTypeDistribution();
                item.setter(DT[i], P[i], ref cumSum, ref minRange);
                res.Add(item);
            }
            if (cumSum != 1)
            {
                res = null;
            }
            return res;
        }
        public List<DemandDistribution> DemandDistributions { get; set; }
        public List<DemandDistribution> demandFill(List<int> D, List<double> P1, List<double> P2, List<double> P3, Enums.DayType DT1, Enums.DayType DT2, Enums.DayType DT3)
        {
            List<DemandDistribution> res = new List<DemandDistribution>();
            int count = D.Count;
            double c1, c2, c3 = c2 = c1 = 0;
            int min1, min2, min3 = min2 = min1 = 1;
            for (int i = 0; i < count; i++)
            {
                DemandDistribution item = new DemandDistribution();
                item.Demand = D[i];
                DayTypeDistribution d1 = new DayTypeDistribution(), d2 = new DayTypeDistribution(), d3 = new DayTypeDistribution();
                //fill d1
                d1.setter(DT1, P1[i], ref c1, ref min1);
                item.DayTypeDistributions.Add(d1);
                //fill d2
                d2.setter(DT2, P2[i], ref c2, ref min2);
                item.DayTypeDistributions.Add(d2);
                //fill d3
                d3.setter(DT3, P3[i], ref c3, ref min3);
                item.DayTypeDistributions.Add(d3);
                res.Add(item);
            }
            if (c1 != 1)
            {
                invalidprob[0] = true;
            }
            if (c2 != 1)
            {
                invalidprob[1] = true;
            }
            if (c3 != 1)
            {
                invalidprob[2] = true;
            }
            return (c1 != 1 || c2 != 1 || c3 != 1) ? null : res;
        }
        public bool checkSum(double c)
        {
            return c == 1;
        }
        public bool isNum(string s)
        {
            int dotCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (((s[i] >= '0' && s[i] <= '9') || s[i] == '.') == false)
                {
                    return false;
                }
                dotCount = (s[i] == '.') ? dotCount + 1 : dotCount;
            }
            return (dotCount > 1) ? false : true;
        }
        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationCases { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        //manar 
        public Enums.DayType gettypeofnewsdays(int rnum)
        {
            Enums.DayType daytype = Enums.DayType.Good;
            int size = this.DayTypeDistributions.Count;
            bool found;
            for (int i = 0; i < size; i++)
            {
                int range = this.DayTypeDistributions[i].MinRange;
                found = false;
                int mx=this.DayTypeDistributions[i].MaxRange;
                if (mx == 0) { mx = 100; }
                while (range <= mx)
                {
                    if (rnum == range)
                    {
                        daytype = this.DayTypeDistributions[i].DayType;
                        found = true;
                        break;
                    }
                    ++range;
                }
                if (found == true)
                {
                    break;
                }
            }//endfor
            return daytype;
        }//end
        public int getdemand(int rnum, Enums.DayType newsdatatype)
        {
            int demand = 0,
            size = this.DemandDistributions.Count,
            ind=(int)newsdatatype;
            bool found;
            for (int i = 0; i < size; i++)
            {
                int range=this.DemandDistributions[i].DayTypeDistributions[ind].MinRange;
                found = false;
                int mx=this.DemandDistributions[i].DayTypeDistributions[ind].MaxRange;
                if (mx == 0) { mx = 100; }
                while (range <=mx )
                {
                    if (rnum == range)
                    {
                        demand = this.DemandDistributions[i].Demand;
                        found = true;
                        break;
                    }
                    ++range;
                }
                if (found == true)
                {
                    break;
                }   
            }//endfor
            return demand;
        }//end
        public void fillsimulationtable()
        {
            Random rand_num = new Random();
            for (int i = 0; i < this.NumOfRecords; i++)
            {
                SimulationCase obj = new SimulationCase();
                obj.DayNo = i + 1;
                obj.RandomNewsDayType = int.Parse(rand_num.Next(1, 100).ToString());
                obj.NewsDayType = gettypeofnewsdays(obj.RandomNewsDayType);
                obj.RandomDemand = int.Parse(rand_num.Next(1, 100).ToString());
                obj.Demand = getdemand(obj.RandomDemand, obj.NewsDayType);
                if (obj.Demand == 0) { obj.Demand = 100; }
                obj.DailyCost = this.NumOfNewspapers * this.PurchasePrice;
                obj.LostProfit = 0;
                obj.ScrapProfit = 0;
                if (obj.Demand > this.NumOfNewspapers)
                {
                    obj.LostProfit = (obj.Demand - this.NumOfNewspapers) * this.UnitProfit;
                    obj.SalesProfit = this.NumOfNewspapers * SellingPrice;
                }
                else if (obj.Demand <= this.NumOfNewspapers)
                {
                    obj.ScrapProfit = (this.NumOfNewspapers - obj.Demand) * this.ScrapPrice;
                    obj.SalesProfit = obj.Demand * SellingPrice;

                }
                obj.DailyNetProfit = obj.SalesProfit - obj.DailyCost - obj.LostProfit + obj.ScrapProfit;
                this.SimulationCases.Add(obj);
            }//endforloop
        }//end                                          
        public void Performance_measures()
        {
            int size = this.NumOfRecords;
            this.PerformanceMeasures.setterPerformanceMeasures();
            for (int i = 0; i < size; i++)
            {
                this.PerformanceMeasures.TotalSalesProfit += this.SimulationCases[i].SalesProfit;
                this.PerformanceMeasures.TotalLostProfit += this.SimulationCases[i].LostProfit;
                this.PerformanceMeasures.TotalScrapProfit += this.SimulationCases[i].ScrapProfit;
                this.PerformanceMeasures.TotalNetProfit += this.SimulationCases[i].DailyNetProfit;
                if (this.SimulationCases[i].Demand > NumOfNewspapers)
                    this.PerformanceMeasures.DaysWithMoreDemand++;
                else if (this.SimulationCases[i].Demand < NumOfNewspapers)
                    this.PerformanceMeasures.DaysWithUnsoldPapers++;

            }//endfor
            this.PerformanceMeasures.TotalCost = this.SimulationCases[0].DailyCost * this.NumOfRecords;
        }//end
    }
}
