namespace CurrencyStudio
{
    partial class frmSignalDebugger
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignalDebugger));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmdSelectSignal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMarketProvider = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCandleCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDataProvider = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSignalName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSetProps = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpChart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.dpChart, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmdSelectSignal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMarketProvider, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboDataProvider, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmdSetProps, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 451);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dpChart
            // 
            this.dpChart.BorderlineWidth = 2;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.BorderColor = System.Drawing.Color.DarkSalmon;
            chartArea1.Name = "ChartArea1";
            this.dpChart.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.dpChart, 3);
            this.dpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.dpChart.Legends.Add(legend1);
            this.dpChart.Location = new System.Drawing.Point(3, 153);
            this.dpChart.Name = "dpChart";
            this.dpChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series1.Legend = "Legend1";
            series1.Name = "PriceSeries";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SignalSeries";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.dpChart.Series.Add(series1);
            this.dpChart.Series.Add(series2);
            this.dpChart.Size = new System.Drawing.Size(686, 275);
            this.dpChart.TabIndex = 2;
            this.dpChart.Text = "chart1";
            title1.Name = "Title1";
            this.dpChart.Titles.Add(title1);
            // 
            // cmdSelectSignal
            // 
            this.cmdSelectSignal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdSelectSignal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelectSignal.Location = new System.Drawing.Point(3, 83);
            this.cmdSelectSignal.Name = "cmdSelectSignal";
            this.cmdSelectSignal.Size = new System.Drawing.Size(88, 24);
            this.cmdSelectSignal.TabIndex = 3;
            this.cmdSelectSignal.Text = "Select Signal";
            this.cmdSelectSignal.UseVisualStyleBackColor = true;
            this.cmdSelectSignal.Click += new System.EventHandler(this.cmdSelectSignal_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Market Provider:";
            // 
            // cboMarketProvider
            // 
            this.cboMarketProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarketProvider.FormattingEnabled = true;
            this.cboMarketProvider.Location = new System.Drawing.Point(110, 23);
            this.cboMarketProvider.Name = "cboMarketProvider";
            this.cboMarketProvider.Size = new System.Drawing.Size(270, 21);
            this.cboMarketProvider.TabIndex = 1;
            this.cboMarketProvider.SelectedIndexChanged += new System.EventHandler(this.cboMarketProvider_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1,
            this.lblCandleCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(692, 20);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 15);
            this.lblStatus.Text = "Redy";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 15);
            this.toolStripStatusLabel1.Text = "Candles Processed:";
            // 
            // lblCandleCount
            // 
            this.lblCandleCount.Name = "lblCandleCount";
            this.lblCandleCount.Size = new System.Drawing.Size(13, 15);
            this.lblCandleCount.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Provider:";
            // 
            // cboDataProvider
            // 
            this.cboDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataProvider.FormattingEnabled = true;
            this.cboDataProvider.Location = new System.Drawing.Point(110, 53);
            this.cboDataProvider.Name = "cboDataProvider";
            this.cboDataProvider.Size = new System.Drawing.Size(252, 21);
            this.cboDataProvider.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7364F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.2636F));
            this.tableLayoutPanel2.Controls.Add(this.lblSignalName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(107, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(465, 30);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblSignalName
            // 
            this.lblSignalName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSignalName.AutoSize = true;
            this.lblSignalName.Location = new System.Drawing.Point(80, 8);
            this.lblSignalName.Name = "lblSignalName";
            this.lblSignalName.Size = new System.Drawing.Size(13, 13);
            this.lblSignalName.TabIndex = 0;
            this.lblSignalName.Text = "?";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Signal Name:";
            // 
            // cmdSetProps
            // 
            this.cmdSetProps.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdSetProps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSetProps.Location = new System.Drawing.Point(589, 83);
            this.cmdSetProps.Name = "cmdSetProps";
            this.cmdSetProps.Size = new System.Drawing.Size(100, 24);
            this.cmdSetProps.TabIndex = 3;
            this.cmdSetProps.Text = "Set Properties";
            this.cmdSetProps.UseVisualStyleBackColor = true;
            this.cmdSetProps.Click += new System.EventHandler(this.cmdSetProps_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.cmdStart);
            this.panel1.Controls.Add(this.cmdStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(107, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 40);
            this.panel1.TabIndex = 6;
            // 
            // cmdStart
            // 
            this.cmdStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdStart.FlatAppearance.BorderSize = 0;
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Image = ((System.Drawing.Image)(resources.GetObject("cmdStart.Image")));
            this.cmdStart.Location = new System.Drawing.Point(546, 3);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(34, 34);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdStop.Enabled = false;
            this.cmdStop.FlatAppearance.BorderSize = 0;
            this.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStop.Image = global::CurrencyStudio.Properties.Resources.Stop;
            this.cmdStop.Location = new System.Drawing.Point(506, 3);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(34, 34);
            this.cmdStop.TabIndex = 3;
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // frmSignalDebugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSignalDebugger";
            this.Text = "Signal Debugger";
            this.Load += new System.EventHandler(this.frmSignalDebugger_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpChart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dpChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMarketProvider;
        private System.Windows.Forms.ComboBox cboDataProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCandleCount;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSignalName;
        private System.Windows.Forms.Button cmdSelectSignal;
        private System.Windows.Forms.Button cmdSetProps;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Panel panel1;

    }
}