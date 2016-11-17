namespace UI
{
    partial class ProfitAnlsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitAnlsForm));
            this.chartYearProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAnls = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCatg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numudYear = new System.Windows.Forms.NumericUpDown();
            this.autxtGoods = new auto_text.auto_text();
            ((System.ComponentModel.ISupportInitialize)(this.chartYearProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // chartYearProfit
            // 
            this.chartYearProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "月份";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "利润";
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.chartYearProfit.ChartAreas.Add(chartArea1);
            this.chartYearProfit.Location = new System.Drawing.Point(3, 66);
            this.chartYearProfit.Name = "chartYearProfit";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Tomato;
            series1.IsVisibleInLegend = false;
            series1.Label = "#VAL{N}";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 3;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "serProfit";
            series1.ToolTip = "#VALX月 #VAL{C}";
            this.chartYearProfit.Series.Add(series1);
            this.chartYearProfit.Size = new System.Drawing.Size(983, 662);
            this.chartYearProfit.TabIndex = 1;
            this.chartYearProfit.Text = "利润统计";
            title1.Name = "Title1";
            title1.Text = "总计：#TOTAL";
            this.chartYearProfit.Titles.Add(title1);
            // 
            // btnAnls
            // 
            this.btnAnls.Location = new System.Drawing.Point(892, 21);
            this.btnAnls.Name = "btnAnls";
            this.btnAnls.Size = new System.Drawing.Size(85, 30);
            this.btnAnls.TabIndex = 4;
            this.btnAnls.Text = "统计";
            this.btnAnls.UseVisualStyleBackColor = true;
            this.btnAnls.Click += new System.EventHandler(this.btnAnls_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "商品：";
            // 
            // cboxCatg
            // 
            this.cboxCatg.FormattingEnabled = true;
            this.cboxCatg.Location = new System.Drawing.Point(276, 25);
            this.cboxCatg.Name = "cboxCatg";
            this.cboxCatg.Size = new System.Drawing.Size(160, 23);
            this.cboxCatg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "品类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "年份：";
            // 
            // numudYear
            // 
            this.numudYear.Location = new System.Drawing.Point(75, 24);
            this.numudYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.numudYear.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numudYear.Name = "numudYear";
            this.numudYear.Size = new System.Drawing.Size(83, 25);
            this.numudYear.TabIndex = 1;
            this.numudYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // autxtGoods
            // 
            this.autxtGoods.Data = null;
            this.autxtGoods.DropHeight = 139;
            this.autxtGoods.Location = new System.Drawing.Point(551, 23);
            this.autxtGoods.Name = "autxtGoods";
            this.autxtGoods.SelectedObj = null;
            this.autxtGoods.Size = new System.Drawing.Size(301, 26);
            this.autxtGoods.TabIndex = 3;
            this.autxtGoods.Term = null;
            this.autxtGoods.loadData += new auto_text.auto_text.LoadDataHandle(this.autxtGoods_loadData);
            // 
            // SalesAnlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 730);
            this.Controls.Add(this.autxtGoods);
            this.Controls.Add(this.btnAnls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxCatg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numudYear);
            this.Controls.Add(this.chartYearProfit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesAnlsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年利润统计";
            this.Load += new System.EventHandler(this.SalesAnlsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartYearProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearProfit;
        private auto_text.auto_text autxtGoods;
        private System.Windows.Forms.Button btnAnls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCatg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numudYear;
    }
}