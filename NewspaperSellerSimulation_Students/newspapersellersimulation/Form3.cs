using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;
namespace NewspaperSellerSimulation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Program.f1.s.importDataFromFile == true)
            {
                nrecordstxt.Text = Program.f1.s.fb.NumOfRecords.ToString();
            }
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            Program.f1.s.NumOfRecords = 0;
            Program.f1.s.SimulationCases.Clear();
            Program.f1.s.PerformanceMeasures.setterPerformanceMeasures();
            string val = nrecordstxt.Text.ToString();
            if (Program.f1.s.isNum(val) == false)
            {
                performance_txt.Text = "";
                MessageBox.Show("Invalid Value " + val + " for Number of Days", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //write simulation code here
                performance_txt.Text = "";
                Program.f1.s.NumOfRecords = int.Parse(val);
                dgv_sim.Rows.Clear();
                Program.f1.s.fillsimulationtable();
                foreach (SimulationCase s in Program.f1.s.SimulationCases)
                {
                    dgv_sim.Rows.Add(s.DayNo, s.RandomNewsDayType, s.NewsDayType, s.RandomDemand, s.Demand, s.DailyCost, s.SalesProfit, s.LostProfit, s.ScrapProfit, s.DailyNetProfit);
                }//endforeach
                ///////////////////////////////
                Program.f1.s.Performance_measures();
                performance_txt.Text +="Total Cost of Newspapers : "+Program.f1.s.PerformanceMeasures.TotalCost.ToString() + Environment.NewLine;
                performance_txt.Text += "Total Sales Revenue ; " + Program.f1.s.PerformanceMeasures.TotalSalesProfit.ToString() + Environment.NewLine;
                performance_txt.Text +="Total Lost Profit from Excess Demand : "+Program.f1.s.PerformanceMeasures.TotalLostProfit.ToString() + Environment.NewLine;
                performance_txt.Text +="Total Salvage from sale of Scrap papers : "+Program.f1.s.PerformanceMeasures.TotalScrapProfit.ToString() + Environment.NewLine;
                performance_txt.Text +="Net Profit "+Program.f1.s.PerformanceMeasures.TotalNetProfit.ToString() + Environment.NewLine;
                performance_txt.Text += "Number of days having excess demand : " + Program.f1.s.PerformanceMeasures.DaysWithMoreDemand.ToString() + Environment.NewLine;
                performance_txt.Text += "Number of days having unsold papers : " + Program.f1.s.PerformanceMeasures.DaysWithUnsoldPapers.ToString() + Environment.NewLine;
                //Test
                int n = Program.f1.s.fb.path.LastIndexOf("TestCase") + 8;
                string testRes="";
                if (Program.f1.s.fb.path[n] == '1')
                {
                    testRes = TestingManager.Test(Program.f1.s, Constants.FileNames.TestCase1);
                }
                else if (Program.f1.s.fb.path[n] == '2')
                {
                    testRes = TestingManager.Test(Program.f1.s, Constants.FileNames.TestCase2);
                }
                else if (Program.f1.s.fb.path[n] == '3')
                {
                    testRes = TestingManager.Test(Program.f1.s, Constants.FileNames.TestCase3);
                }
                //MessageBox.Show(Program.f1.s.fb.path[n].ToString());
                MessageBox.Show(testRes);

            }
        }

        private void btnBackToFillDistro_Click(object sender, EventArgs e)
        {
            Program.f2.Show();
            this.Hide();
        }

       
    }
}
