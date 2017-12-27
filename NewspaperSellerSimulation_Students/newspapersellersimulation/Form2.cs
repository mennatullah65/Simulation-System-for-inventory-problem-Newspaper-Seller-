using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;
using System.IO;

namespace NewspaperSellerSimulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Program.f1.s.importDataFromFile == true)
            {
                dgv_dt.Rows.Clear();
                List<double> dt=Program.f1.s.fb.dtProb;
                string[] s ={"Good","Fair","Poor" };
                int ind = 0;
                foreach (double i in dt)
                {
                    dgv_dt.Rows.Add(s[ind],i);
                    ++ind;
                }
                dgv_d.Rows.Clear();
                List<int> d = Program.f1.s.fb.Demand;
                List<double> P1 = Program.f1.s.fb.P1;
                List<double> P2 = Program.f1.s.fb.P2;
                List<double> P3 = Program.f1.s.fb.P3;
                ind = 0;
                foreach (int i in d)
                {
                    dgv_d.Rows.Add(i, P1[ind], null, null, null, P2[ind], null, null, null, P3[ind], null, null, null);
                    ++ind;
                }
            }
        }
        private void daystypeFill_Click(object sender, EventArgs e)
        {
            Program.f1.s.DayTypeDistributions.Clear();
            List<Enums.DayType> dt = new List<Enums.DayType>();
            List<double> prob = new List<double>();
            for (int i = 0; i < dgv_dt.Rows.Count - 1; ++i)
            {
                string val;
                if (dgv_dt.Rows[i].Cells["dtDayType"].Value != null)
                {
                    val = dgv_dt.Rows[i].Cells["dtDayType"].Value.ToString();
                    if (val == Enums.DayType.Good.ToString())
                        dt.Add(Enums.DayType.Good);
                    else if (val == Enums.DayType.Fair.ToString())
                        dt.Add(Enums.DayType.Fair);
                    else if (val == Enums.DayType.Poor.ToString())
                        dt.Add(Enums.DayType.Poor);
                }
                if (dgv_dt.Rows[i].Cells["dtProbability"].Value != null)
                {
                    val = dgv_dt.Rows[i].Cells["dtProbability"].Value.ToString();
                    if (Program.f1.s.isNum(val) == true)
                    {
                        prob.Add(double.Parse(val));
                    }
                    else
                    {
                        MessageBox.Show("Invalid Probability Cell "+(i+1).ToString()+" in DayType Distro.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Fill empty probabilities with zero
            while (prob.Count < dt.Count) { prob.Add(0); }
            if (prob.Count > dt.Count)
            {
                MessageBox.Show("Error,Probability Fields with no DayType matched fields!\nAdd the incomplete Daytypes", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<DayTypeDistribution> dtd = new List<DayTypeDistribution>();
                dtd = Program.f1.s.daystypeFill(dt, prob);
                if (dtd != null)
                {
                    Program.f1.s.DayTypeDistributions = dtd;
                    dgv_dt.Rows.Clear();
                    //Fill Data Grid View
                    foreach (DayTypeDistribution item in dtd)
                    {
                        dgv_dt.Rows.Add(item.DayType, item.Probability, item.CummProbability, item.MinRange, item.MaxRange);
                    }
                    MessageBox.Show(" Done :) ");
                }
                else
                {
                    MessageBox.Show("Probability Input Invalid!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void demandFill_Click(object sender, EventArgs e)
        {
            Program.f1.s.DemandDistributions.Clear();
            List<int> D = new List<int>();
            List<double> P1 = new List<double>(), P2 = new List<double>(), P3 = new List<double>();
            Enums.DayType DT11 = Enums.DayType.Good, DT2 = Enums.DayType.Fair, DT3 = Enums.DayType.Poor;
            for (int i = 0; i < dgv_d.Rows.Count - 1; ++i)
            {
                string val;
                if (dgv_d.Rows[i].Cells["dDemand"].Value != null)
                {
                    val = dgv_d.Rows[i].Cells["dDemand"].Value.ToString();
                    if (Program.f1.s.isNum(val) == true)
                    {
                        D.Add(int.Parse(val));
                    }
                    else
                    {
                        MessageBox.Show("Invalid Demand Cell " + (i + 1).ToString() + " in Demand Distro.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               
                }
                if (dgv_d.Rows[i].Cells["dGoodProb"].Value != null)
                {
                    val = dgv_d.Rows[i].Cells["dGoodProb"].Value.ToString();
                    if (Program.f1.s.isNum(val) == true)
                    {
                        P1.Add(double.Parse(val));
                    }
                    else
                    {
                        MessageBox.Show("Invalid Good Probability Cell " + (i + 1).ToString() + " in Demand Distro.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
                if (dgv_d.Rows[i].Cells["dFairProb"].Value != null)
                {
                    val = dgv_d.Rows[i].Cells["dFairProb"].Value.ToString();
                    if (Program.f1.s.isNum(val) == true)
                    {
                        P2.Add(double.Parse(val));
                    }
                    else
                    {
                        MessageBox.Show("Invalid Fair Probability Cell " + (i + 1).ToString() + " in Demand Distro.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
                if (dgv_d.Rows[i].Cells["dPoorProb"].Value != null)
                {
                    val = dgv_d.Rows[i].Cells["dPoorProb"].Value.ToString();
                    if (Program.f1.s.isNum(val) == true)
                    {
                        P3.Add(double.Parse(val));
                    }
                    else
                    {
                        MessageBox.Show("Invalid Fair Probability Cell " + (i + 1).ToString() + " in Demand Distro.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                 
                }
            }
            while (P1.Count < D.Count) { P1.Add(0); }
            while (P2.Count < D.Count) { P2.Add(0); }
            while (P3.Count < D.Count) { P3.Add(0); }
            if (D.Count < P1.Count || D.Count < P2.Count || D.Count < P3.Count)
            {
                MessageBox.Show("Error,Probability Fields with no Demands matched fields!\nAdd the incomplete Demands", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<DemandDistribution> d = new List<DemandDistribution>();
                d = Program.f1.s.demandFill(D, P1, P2, P3, DT11, DT2, DT3);
                if (d == null)
                {
                    //Good Wrong Cumulative Sum
                    if (Program.f1.s.invalidprob[0]==true)
                    {
                        MessageBox.Show("Probability Input for Good Days Invalid!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Fair Wrong Cumulative Sum
                    if (Program.f1.s.invalidprob[1] == true)
                    {
                        MessageBox.Show("Probability Input for Fair Days Invalid!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Poor Wrong Cumulative Sum
                    if (Program.f1.s.invalidprob[2] == true)
                    {
                        MessageBox.Show("Probability Input for Poor Days Invalid!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Program.f1.s.DemandDistributions = d;
                    dgv_d.Rows.Clear();
                    //Fill Data Grid View
                    foreach (DemandDistribution item in d)
                    {
                        dgv_d.Rows.Add(
                                       item.Demand,
                                       //Good
                                       item.DayTypeDistributions[0].Probability,
                                       item.DayTypeDistributions[0].CummProbability,
                                       item.DayTypeDistributions[0].MinRange,
                                       item.DayTypeDistributions[0].MaxRange,
                                       //Fair
                                       item.DayTypeDistributions[1].Probability,
                                       item.DayTypeDistributions[1].CummProbability,
                                       item.DayTypeDistributions[1].MinRange,
                                       item.DayTypeDistributions[1].MaxRange,
                                       //Poor
                                       item.DayTypeDistributions[2].Probability,
                                       item.DayTypeDistributions[2].CummProbability,
                                       item.DayTypeDistributions[2].MinRange,
                                       item.DayTypeDistributions[2].MaxRange
                                       );
                    }
                    MessageBox.Show(" Done :) ");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnGoToSimulation_Click(object sender, EventArgs e)
        {
            Program.f3.Show();
            this.Hide();
        }
        private void daystypeReset_Click(object sender, EventArgs e)
        {
            dgv_dt.Rows.Clear();
            Program.f1.s.DayTypeDistributions.Clear();
        }
        private void demandReset_Click(object sender, EventArgs e)
        {
            dgv_d.Rows.Clear();
            Program.f1.s.DemandDistributions.Clear();
        }
        private void btnBackToSystemInput_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }       
    }
}
