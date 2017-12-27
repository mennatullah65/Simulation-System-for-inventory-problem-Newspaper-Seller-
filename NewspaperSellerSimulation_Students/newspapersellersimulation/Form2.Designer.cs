namespace NewspaperSellerSimulation
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGoToSimulation = new System.Windows.Forms.Button();
            this.demandFill = new System.Windows.Forms.Button();
            this.daystypeFill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dPoorMaxR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPoorMinR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPoorCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPoorProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFairMaxR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFairMinR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFairCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFairProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGoodMinR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGoodCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGoodProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_d = new System.Windows.Forms.DataGridView();
            this.dGoodMaxR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMaxRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtMinRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCumulativeProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dt = new System.Windows.Forms.DataGridView();
            this.demandReset = new System.Windows.Forms.Button();
            this.daystypeReset = new System.Windows.Forms.Button();
            this.btnBackToSystemInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dt)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(754, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGoToSimulation
            // 
            this.btnGoToSimulation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToSimulation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToSimulation.Location = new System.Drawing.Point(754, 94);
            this.btnGoToSimulation.Name = "btnGoToSimulation";
            this.btnGoToSimulation.Size = new System.Drawing.Size(200, 38);
            this.btnGoToSimulation.TabIndex = 24;
            this.btnGoToSimulation.Text = "Go To Simulation";
            this.btnGoToSimulation.UseVisualStyleBackColor = false;
            this.btnGoToSimulation.Click += new System.EventHandler(this.btnGoToSimulation_Click);
            // 
            // demandFill
            // 
            this.demandFill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.demandFill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandFill.Location = new System.Drawing.Point(536, 191);
            this.demandFill.Name = "demandFill";
            this.demandFill.Size = new System.Drawing.Size(107, 38);
            this.demandFill.TabIndex = 23;
            this.demandFill.Text = "Fill";
            this.demandFill.UseVisualStyleBackColor = false;
            this.demandFill.Click += new System.EventHandler(this.demandFill_Click);
            // 
            // daystypeFill
            // 
            this.daystypeFill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.daystypeFill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daystypeFill.Location = new System.Drawing.Point(536, 5);
            this.daystypeFill.Name = "daystypeFill";
            this.daystypeFill.Size = new System.Drawing.Size(107, 38);
            this.daystypeFill.TabIndex = 22;
            this.daystypeFill.Text = "Fill";
            this.daystypeFill.UseVisualStyleBackColor = false;
            this.daystypeFill.Click += new System.EventHandler(this.daystypeFill_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SandyBrown;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 182);
            this.label5.TabIndex = 25;
            // 
            // dPoorMaxR
            // 
            this.dPoorMaxR.HeaderText = "Poor Max Range";
            this.dPoorMaxR.Name = "dPoorMaxR";
            this.dPoorMaxR.ReadOnly = true;
            // 
            // dPoorMinR
            // 
            this.dPoorMinR.HeaderText = "Poor Min Range";
            this.dPoorMinR.Name = "dPoorMinR";
            this.dPoorMinR.ReadOnly = true;
            // 
            // dPoorCum
            // 
            this.dPoorCum.HeaderText = "Poor Cum. Prob.";
            this.dPoorCum.Name = "dPoorCum";
            this.dPoorCum.ReadOnly = true;
            // 
            // dPoorProb
            // 
            this.dPoorProb.HeaderText = "Poor Prob.";
            this.dPoorProb.Name = "dPoorProb";
            // 
            // dFairMaxR
            // 
            this.dFairMaxR.HeaderText = "Fair Max Range";
            this.dFairMaxR.Name = "dFairMaxR";
            this.dFairMaxR.ReadOnly = true;
            // 
            // dFairMinR
            // 
            this.dFairMinR.HeaderText = "Fair Min Range ";
            this.dFairMinR.Name = "dFairMinR";
            this.dFairMinR.ReadOnly = true;
            // 
            // dFairCum
            // 
            this.dFairCum.HeaderText = "Fair Cum. Prob.";
            this.dFairCum.Name = "dFairCum";
            this.dFairCum.ReadOnly = true;
            // 
            // dFairProb
            // 
            this.dFairProb.HeaderText = "Fair Prob.";
            this.dFairProb.Name = "dFairProb";
            // 
            // dGoodMinR
            // 
            this.dGoodMinR.HeaderText = "Good Min Range";
            this.dGoodMinR.Name = "dGoodMinR";
            this.dGoodMinR.ReadOnly = true;
            // 
            // dGoodCum
            // 
            this.dGoodCum.HeaderText = "Good Cum. Prob.";
            this.dGoodCum.Name = "dGoodCum";
            this.dGoodCum.ReadOnly = true;
            // 
            // dGoodProb
            // 
            this.dGoodProb.HeaderText = "Good Prob.";
            this.dGoodProb.Name = "dGoodProb";
            // 
            // dDemand
            // 
            this.dDemand.HeaderText = "Demand";
            this.dDemand.Name = "dDemand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Distribution of Newspaper demanded";
            // 
            // dgv_d
            // 
            this.dgv_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_d.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_d.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_d.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dDemand,
            this.dGoodProb,
            this.dGoodCum,
            this.dGoodMinR,
            this.dGoodMaxR,
            this.dFairProb,
            this.dFairCum,
            this.dFairMinR,
            this.dFairMaxR,
            this.dPoorProb,
            this.dPoorCum,
            this.dPoorMinR,
            this.dPoorMaxR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_d.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_d.EnableHeadersVisualStyles = false;
            this.dgv_d.Location = new System.Drawing.Point(14, 230);
            this.dgv_d.Name = "dgv_d";
            this.dgv_d.Size = new System.Drawing.Size(980, 254);
            this.dgv_d.TabIndex = 20;
            // 
            // dGoodMaxR
            // 
            this.dGoodMaxR.HeaderText = "Good Max Range";
            this.dGoodMaxR.Name = "dGoodMaxR";
            this.dGoodMaxR.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Type of Newsday Distribution";
            // 
            // dtMaxRange
            // 
            this.dtMaxRange.HeaderText = "Max Range";
            this.dtMaxRange.Name = "dtMaxRange";
            this.dtMaxRange.ReadOnly = true;
            // 
            // dtMinRange
            // 
            this.dtMinRange.HeaderText = "Min Range";
            this.dtMinRange.Name = "dtMinRange";
            this.dtMinRange.ReadOnly = true;
            // 
            // dtCumulativeProbability
            // 
            this.dtCumulativeProbability.HeaderText = "Cumulative Probability";
            this.dtCumulativeProbability.Name = "dtCumulativeProbability";
            this.dtCumulativeProbability.ReadOnly = true;
            // 
            // dtProbability
            // 
            this.dtProbability.HeaderText = "Probability";
            this.dtProbability.Name = "dtProbability";
            // 
            // dtDayType
            // 
            this.dtDayType.HeaderText = "Type Of Newsday";
            this.dtDayType.Name = "dtDayType";
            // 
            // dgv_dt
            // 
            this.dgv_dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtDayType,
            this.dtProbability,
            this.dtCumulativeProbability,
            this.dtMinRange,
            this.dtMaxRange});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dt.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_dt.EnableHeadersVisualStyles = false;
            this.dgv_dt.Location = new System.Drawing.Point(14, 46);
            this.dgv_dt.Name = "dgv_dt";
            this.dgv_dt.Size = new System.Drawing.Size(629, 134);
            this.dgv_dt.TabIndex = 18;
            // 
            // demandReset
            // 
            this.demandReset.BackColor = System.Drawing.Color.DarkRed;
            this.demandReset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandReset.ForeColor = System.Drawing.Color.White;
            this.demandReset.Location = new System.Drawing.Point(423, 191);
            this.demandReset.Name = "demandReset";
            this.demandReset.Size = new System.Drawing.Size(107, 38);
            this.demandReset.TabIndex = 27;
            this.demandReset.Text = "Reset";
            this.demandReset.UseVisualStyleBackColor = false;
            this.demandReset.Click += new System.EventHandler(this.demandReset_Click);
            // 
            // daystypeReset
            // 
            this.daystypeReset.BackColor = System.Drawing.Color.DarkRed;
            this.daystypeReset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daystypeReset.ForeColor = System.Drawing.Color.White;
            this.daystypeReset.Location = new System.Drawing.Point(423, 5);
            this.daystypeReset.Name = "daystypeReset";
            this.daystypeReset.Size = new System.Drawing.Size(107, 38);
            this.daystypeReset.TabIndex = 28;
            this.daystypeReset.Text = "Reset";
            this.daystypeReset.UseVisualStyleBackColor = false;
            this.daystypeReset.Click += new System.EventHandler(this.daystypeReset_Click);
            // 
            // btnBackToSystemInput
            // 
            this.btnBackToSystemInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackToSystemInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSystemInput.Location = new System.Drawing.Point(754, 40);
            this.btnBackToSystemInput.Name = "btnBackToSystemInput";
            this.btnBackToSystemInput.Size = new System.Drawing.Size(200, 38);
            this.btnBackToSystemInput.TabIndex = 29;
            this.btnBackToSystemInput.Text = "Back To System Input";
            this.btnBackToSystemInput.UseVisualStyleBackColor = false;
            this.btnBackToSystemInput.Click += new System.EventHandler(this.btnBackToSystemInput_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 500);
            this.Controls.Add(this.btnBackToSystemInput);
            this.Controls.Add(this.daystypeReset);
            this.Controls.Add(this.demandReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGoToSimulation);
            this.Controls.Add(this.demandFill);
            this.Controls.Add(this.daystypeFill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_d);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dt);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGoToSimulation;
        private System.Windows.Forms.Button demandFill;
        private System.Windows.Forms.Button daystypeFill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPoorMaxR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPoorMinR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPoorCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPoorProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFairMaxR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFairMinR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFairCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFairProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGoodMinR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGoodCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGoodProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDemand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGoodMaxR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtMaxRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtMinRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCumulativeProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDayType;
        private System.Windows.Forms.DataGridView dgv_dt;
        private System.Windows.Forms.Button demandReset;
        private System.Windows.Forms.Button daystypeReset;
        private System.Windows.Forms.Button btnBackToSystemInput;
    }
}