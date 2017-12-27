using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NewspaperSellerModels;
namespace NewspaperSellerModels
{
    public class fileBuffer
    {        
        public string path { get; set; }
        public int NumOfNewspapers{ get; set; }
        public int NumOfRecords { get; set; }
        public double PurchasePrice{ get; set; }
        public double ScrapPrice{ get; set; }
        public double SellingPrice{ get; set; }
        public List<double> dtProb{ get; set; }
        public List<int> Demand{ get; set; }
        public List<double> P1 { get; set; }
        public List<double> P2 { get; set; }
        public List<double> P3 { get; set; }
        public fileBuffer()
        {
            dtProb = new List<double>();
            Demand = new List<int>();
            P1 = new List<double>();
            P2 = new List<double>();
            P3 = new List<double>();
        }
        public void ImportFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            string[] lines = File.ReadAllLines(path);
            bool b_NumOfNewspapers = false, b_NumOfRecords = false, b_PurchasePrice = false, b_ScrapPrice = false, b_SellingPrice = false, b_DayTypeDistributions = false, b_DemandDistributions = false;
            foreach (string line in lines)
            {
                if (line != "\n" && line != "\r"&& line.Length>0)
                {
                    DefineLine(line, ref  b_NumOfNewspapers, ref  b_NumOfRecords, ref  b_PurchasePrice, ref  b_ScrapPrice, ref  b_SellingPrice, ref  b_DayTypeDistributions, ref b_DemandDistributions);
                    if (line[0] >= '0' && line[0] <= '9')
                    {
                        if (b_NumOfNewspapers == true)
                        {
                            this.NumOfNewspapers = int.Parse(line);
                        }
                        else if (b_NumOfRecords == true)
                        {
                            this.NumOfRecords = int.Parse(line);
                        }
                        else if (b_PurchasePrice == true)
                        {
                            this.PurchasePrice = double.Parse(line);
                        }
                        else if (b_ScrapPrice == true)
                        {
                            this.ScrapPrice = double.Parse(line);
                        }
                        else if (b_SellingPrice == true)
                        {
                            this.SellingPrice = double.Parse(line);
                        }
                        else if (b_DayTypeDistributions == true)
                        {
                            string[] s = line.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < s.Length; i++)
                            {
                                this.dtProb.Add(double.Parse(s[i]));
                            }
                        }
                        else if (b_DemandDistributions == true)
                        {
                            string[] s = line.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                            this.Demand.Add(int.Parse(s[0]));
                            this.P1.Add(double.Parse(s[1]));
                            this.P2.Add(double.Parse(s[2]));
                            this.P3.Add(double.Parse(s[3]));
                        }
                    }
                }
            }
        }
        void DefineLine(string line, ref bool b_NumOfNewspapers, ref bool b_NumOfRecords, ref bool b_PurchasePrice, ref bool b_ScrapPrice, ref bool b_SellingPrice, ref bool b_DayTypeDistributions, ref bool b_DemandDistributions)
        {
            if (line == "NumOfNewspapers")
            {
                b_NumOfNewspapers = true;
                b_NumOfRecords = b_PurchasePrice = b_ScrapPrice = b_SellingPrice = b_DayTypeDistributions = b_DemandDistributions = false;
            }
            else if (line == "NumOfRecords")
            {
                b_NumOfRecords = true;
                b_NumOfNewspapers = b_PurchasePrice = b_ScrapPrice = b_SellingPrice = b_DayTypeDistributions = b_DemandDistributions = false;
            }
            else if (line == "PurchasePrice")
            {
                b_PurchasePrice = true;
                b_NumOfNewspapers = b_NumOfRecords = b_ScrapPrice = b_SellingPrice = b_DayTypeDistributions = b_DemandDistributions = false;
            }
            else if (line == "ScrapPrice")
            {
                b_ScrapPrice = true;
                b_NumOfNewspapers = b_NumOfRecords = b_PurchasePrice = b_SellingPrice = b_DayTypeDistributions = b_DemandDistributions = false;
            }
            else if (line == "SellingPrice")
            {
                b_SellingPrice = true;
                b_NumOfNewspapers = b_NumOfRecords = b_PurchasePrice = b_ScrapPrice = b_DayTypeDistributions = b_DemandDistributions = false;
            }
            else if (line == "DayTypeDistributions")
            {
                b_DayTypeDistributions = true;
                b_NumOfNewspapers = b_NumOfRecords = b_PurchasePrice = b_ScrapPrice = b_SellingPrice = b_DemandDistributions = false;
            }
            else if (line == "DemandDistributions")
            {
                b_DemandDistributions = true;
                b_NumOfNewspapers = b_NumOfRecords = b_PurchasePrice = b_ScrapPrice = b_SellingPrice = b_DayTypeDistributions = false;
            }
        }

    }
}
