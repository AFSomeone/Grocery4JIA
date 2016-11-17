namespace UI
{
    partial class SalesmanProfitAnlsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanProfitAnlsForm));
            this.btnAnls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartUsrProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpBeginDt = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDt = new System.Windows.Forms.DateTimePicker();
            this.lblQyDt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsrProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnls
            // 
            this.btnAnls.Location = new System.Drawing.Point(630, 15);
            this.btnAnls.Name = "btnAnls";
            this.btnAnls.Size = new System.Drawing.Size(85, 30);
            this.btnAnls.TabIndex = 3;
            this.btnAnls.Text = "统计";
            this.btnAnls.UseVisualStyleBackColor = true;
            this.btnAnls.Click += new System.EventHandler(this.btnAnls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "日期范围：";
            // 
            // chartUsrProfit
            // 
            this.chartUsrProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 45;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "销售利润";
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.chartUsrProfit.ChartAreas.Add(chartArea1);
            this.chartUsrProfit.Location = new System.Drawing.Point(3, 64);
            this.chartUsrProfit.Name = "chartUsrProfit";
            series1.BorderColor = System.Drawing.Color.FloralWhite;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.CornflowerBlue;
            series1.IsVisibleInLegend = false;
            series1.Label = "#VAL{N}";
            series1.Name = "serProfit";
            series1.ToolTip = "#AXISLABEL";
            this.chartUsrProfit.Series.Add(series1);
            this.chartUsrProfit.Size = new System.Drawing.Size(983, 662);
            this.chartUsrProfit.TabIndex = 13;
            this.chartUsrProfit.Text = "利润统计";
            // 
            // dtpBeginDt
            // 
            this.dtpBeginDt.CustomFormat = "yyyy-MM-dd";
            this.dtpBeginDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginDt.Location = new System.Drawing.Point(112, 18);
            this.dtpBeginDt.Name = "dtpBeginDt";
            this.dtpBeginDt.Size = new System.Drawing.Size(190, 25);
            this.dtpBeginDt.TabIndex = 1;
            // 
            // dtpEndDt
            // 
            this.dtpEndDt.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDt.Location = new System.Drawing.Point(368, 18);
            this.dtpEndDt.Name = "dtpEndDt";
            this.dtpEndDt.Size = new System.Drawing.Size(200, 25);
            this.dtpEndDt.TabIndex = 2;
            // 
            // lblQyDt
            // 
            this.lblQyDt.AutoSize = true;
            this.lblQyDt.Location = new System.Drawing.Point(324, 23);
            this.lblQyDt.Name = "lblQyDt";
            this.lblQyDt.Size = new System.Drawing.Size(22, 15);
            this.lblQyDt.TabIndex = 19;
            this.lblQyDt.Text = "—";
            // 
            // SalesmanProfitAnlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 730);
            this.Controls.Add(this.lblQyDt);
            this.Controls.Add(this.dtpEndDt);
            this.Controls.Add(this.dtpBeginDt);
            this.Controls.Add(this.btnAnls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartUsrProfit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesmanProfitAnlsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售人员业绩统计";
            this.Load += new System.EventHandler(this.SalesmanProfitAnlsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsrProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsrProfit;
        private System.Windows.Forms.DateTimePicker dtpBeginDt;
        private System.Windows.Forms.DateTimePicker dtpEndDt;
        private System.Windows.Forms.Label lblQyDt;
    }
}