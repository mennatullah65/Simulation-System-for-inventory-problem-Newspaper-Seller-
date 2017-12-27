namespace NewspaperSellerSimulation
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.performance_txt = new System.Windows.Forms.TextBox();
            this.btnBackToFillDistro = new System.Windows.Forms.Button();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.nrecordstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DailyNetProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ScrapProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_sim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).BeginInit();
            this.SuspendLayout();
            // 
            // performance_txt
            // 
            this.performance_txt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance_txt.Location = new System.Drawing.Point(141, 387);
            this.performance_txt.Multiline = true;
            this.performance_txt.Name = "performance_txt";
            this.performance_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.performance_txt.Size = new System.Drawing.Size(464, 85);
            this.performance_txt.TabIndex = 43;
            // 
            // btnBackToFillDistro
            // 
            this.btnBackToFillDistro.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackToFillDistro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToFillDistro.ForeColor = System.Drawing.Color.White;
            this.btnBackToFillDistro.Location = new System.Drawing.Point(717, 6);
            this.btnBackToFillDistro.Name = "btnBackToFillDistro";
            this.btnBackToFillDistro.Size = new System.Drawing.Size(282, 38);
            this.btnBackToFillDistro.TabIndex = 42;
            this.btnBackToFillDistro.Text = "Back To Fill Distributions";
            this.btnBackToFillDistro.UseVisualStyleBackColor = false;
            this.btnBackToFillDistro.Click += new System.EventHandler(this.btnBackToFillDistro_Click);
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartSimulation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimulation.Location = new System.Drawing.Point(338, 11);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(200, 38);
            this.btnStartSimulation.TabIndex = 41;
            this.btnStartSimulation.Text = "Start Simulation";
            this.btnStartSimulation.UseVisualStyleBackColor = false;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // nrecordstxt
            // 
            this.nrecordstxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrecordstxt.Location = new System.Drawing.Point(216, 9);
            this.nrecordstxt.Name = "nrecordstxt";
            this.nrecordstxt.Size = new System.Drawing.Size(100, 27);
            this.nrecordstxt.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Enter Number Of Days";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SandyBrown;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(539, 49);
            this.label5.TabIndex = 40;
            // 
            // DailyNetProfit
            // 
            this.DailyNetProfit.HeaderText = "DailyNetProfit";
            this.DailyNetProfit.Name = "DailyNetProfit";
            this.DailyNetProfit.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "performance";
            // 
            // ScrapProfit
            // 
            this.ScrapProfit.HeaderText = "ScrapProfit";
            this.ScrapProfit.Name = "ScrapProfit";
            this.ScrapProfit.ReadOnly = true;
            // 
            // SalesProfit
            // 
            this.SalesProfit.HeaderText = "SalesProfit";
            this.SalesProfit.Name = "SalesProfit";
            this.SalesProfit.ReadOnly = true;
            // 
            // DailyCost
            // 
            this.DailyCost.HeaderText = "DailyCost";
            this.DailyCost.Name = "DailyCost";
            this.DailyCost.ReadOnly = true;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            // 
            // rdDemand
            // 
            this.rdDemand.HeaderText = "rdDemand";
            this.rdDemand.Name = "rdDemand";
            this.rdDemand.ReadOnly = true;
            // 
            // DayType
            // 
            this.DayType.HeaderText = "DayType";
            this.DayType.Name = "DayType";
            this.DayType.ReadOnly = true;
            // 
            // rdDayType
            // 
            this.rdDayType.HeaderText = "rdDayType";
            this.rdDayType.Name = "rdDayType";
            this.rdDayType.ReadOnly = true;
            // 
            // DayNo
            // 
            this.DayNo.HeaderText = "DayNo";
            this.DayNo.Name = "DayNo";
            this.DayNo.ReadOnly = true;
            // 
            // LostProfit
            // 
            this.LostProfit.HeaderText = "LostProfit";
            this.LostProfit.Name = "LostProfit";
            this.LostProfit.ReadOnly = true;
            // 
            // dgv_sim
            // 
            this.dgv_sim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayNo,
            this.rdDayType,
            this.DayType,
            this.rdDemand,
            this.Demand,
            this.DailyCost,
            this.SalesProfit,
            this.LostProfit,
            this.ScrapProfit,
            this.DailyNetProfit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sim.EnableHeadersVisualStyles = false;
            this.dgv_sim.Location = new System.Drawing.Point(12, 92);
            this.dgv_sim.Name = "dgv_sim";
            this.dgv_sim.Size = new System.Drawing.Size(987, 289);
            this.dgv_sim.TabIndex = 37;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 478);
            this.Controls.Add(this.performance_txt);
            this.Controls.Add(this.btnBackToFillDistro);
            this.Controls.Add(this.btnStartSimulation);
            this.Controls.Add(this.nrecordstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_sim);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox performance_txt;
        private System.Windows.Forms.Button btnBackToFillDistro;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.TextBox nrecordstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyNetProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostProfit;
        private System.Windows.Forms.DataGridView dgv_sim;

    }
}