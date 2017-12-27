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

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        public NewspaperSellerModels.System s = new NewspaperSellerModels.System();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // s = new NewspaperSellerModels.System();
            s.importDataFromFile = false;
             
            //s.setterSystem();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Reset
            s.PurchasePrice = 0;
            s.SellingPrice = 0;
            s.ScrapPrice = 0;
            s.NumOfNewspapers = 0;
            //Set
            string val = txtPurchasePrice.Text.ToString();
            if (val != "")
            {
                if (Program.f1.s.isNum(val))
                {
                    s.PurchasePrice = double.Parse(txtPurchasePrice.Text.ToString());
                    val = txtSellPrice.Text.ToString();
                    if (val != "")
                    {
                        if (Program.f1.s.isNum(val))
                        {
                            s.SellingPrice = double.Parse(txtSellPrice.Text.ToString());
                            val = txtScrapValue.Text.ToString();
                            if (val != "")
                            {
                                if (Program.f1.s.isNum(val))
                                {
                                    s.ScrapPrice = double.Parse(txtScrapValue.Text.ToString());
                                    val = txtNumOfNewspaper.Text.ToString();
                                    if (val != "")
                                    {
                                        if (Program.f1.s.isNum(val))
                                        {
                                            s.NumOfNewspapers = int.Parse(txtNumOfNewspaper.Text.ToString());
                                            s.UnitProfit = s.SellingPrice - s.PurchasePrice;
                                            Program.f2.Show();
                                            this.Hide();
                                        }
                                        else
                                        { MessageBox.Show("Invalid Number of Papers", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);}                                     
                                    }
                                    else
                                    {MessageBox.Show(" Number of Papers Purchased by News Dealer is empty!");}
                                }
                                else
                                {MessageBox.Show("Invalid Scrap Value", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                            }
                            else
                            {MessageBox.Show("Newspaper Scrap Value is empty!");}
                        }
                        else
                        {MessageBox.Show("Invalid Selling Price", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);}

                    }
                    else
                    {MessageBox.Show("Newspaper Selling Price is empty!");}
                }
                else
                {MessageBox.Show("Invalid Purchase Price", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else
            {MessageBox.Show("Newspaper Purchase Price is empty!");}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnImportFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\CS\Simulation\NewspaperSellerSimulation_Students\newspapersellersimulation\TestCases";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                s.fb.path = path;
                s.importDataFromFile = true;
                s.fb.ImportFromFile(path);
                txtPurchasePrice.Text = s.fb.PurchasePrice.ToString();
                txtSellPrice.Text = s.fb.SellingPrice.ToString();
                txtScrapValue.Text = s.fb.ScrapPrice.ToString();
                txtNumOfNewspaper.Text = s.fb.NumOfNewspapers.ToString();
            }
        }

      
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
           // if (Program.f1.Visible == true)
           // {
           //     s = new NewspaperSellerModels.System();
           //     //MessageBox.Show("HI");
           // }
        }
    }
}
