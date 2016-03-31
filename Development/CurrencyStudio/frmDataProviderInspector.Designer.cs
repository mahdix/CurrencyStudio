namespace CurrencyStudio
{
    partial class frmDataProviderInspector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataProviderInspector));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMarketProvider = new System.Windows.Forms.ComboBox();
            this.cboDataProvider = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCandleCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTimeFrame = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstruments = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpChart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dpChart, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMarketProvider, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboDataProvider, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboTimeFrame, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtInstruments, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 493);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dpChart
            // 
            this.dpChart.BorderlineWidth = 2;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.BorderColor = System.Drawing.Color.DarkSalmon;
            chartArea1.Name = "ChartArea1";
            this.dpChart.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.dpChart, 2);
            this.dpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.dpChart.Legends.Add(legend1);
            this.dpChart.Location = new System.Drawing.Point(3, 183);
            this.dpChart.Name = "dpChart";
            this.dpChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.dpChart.Series.Add(series1);
            this.dpChart.Size = new System.Drawing.Size(800, 287);
            this.dpChart.TabIndex = 2;
            this.dpChart.Text = "chart1";
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
            this.cboMarketProvider.Location = new System.Drawing.Point(103, 23);
            this.cboMarketProvider.Name = "cboMarketProvider";
            this.cboMarketProvider.Size = new System.Drawing.Size(270, 21);
            this.cboMarketProvider.TabIndex = 1;
            this.cboMarketProvider.SelectedIndexChanged += new System.EventHandler(this.cboMarketProvider_SelectedIndexChanged);
            // 
            // cboDataProvider
            // 
            this.cboDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataProvider.FormattingEnabled = true;
            this.cboDataProvider.Location = new System.Drawing.Point(103, 53);
            this.cboDataProvider.Name = "cboDataProvider";
            this.cboDataProvider.Size = new System.Drawing.Size(252, 21);
            this.cboDataProvider.TabIndex = 1;
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
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel1,
            this.lblCandleCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(806, 20);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Frame:";
            // 
            // cboTimeFrame
            // 
            this.cboTimeFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeFrame.FormattingEnabled = true;
            this.cboTimeFrame.Location = new System.Drawing.Point(103, 113);
            this.cboTimeFrame.Name = "cboTimeFrame";
            this.cboTimeFrame.Size = new System.Drawing.Size(189, 21);
            this.cboTimeFrame.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chart Instrument:";
            // 
            // txtInstruments
            // 
            this.txtInstruments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInstruments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstruments.Location = new System.Drawing.Point(103, 85);
            this.txtInstruments.Name = "txtInstruments";
            this.txtInstruments.Size = new System.Drawing.Size(391, 20);
            this.txtInstruments.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdStart);
            this.panel1.Controls.Add(this.cmdStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(100, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 40);
            this.panel1.TabIndex = 6;
            // 
            // cmdStart
            // 
            this.cmdStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdStart.FlatAppearance.BorderSize = 0;
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Image = ((System.Drawing.Image)(resources.GetObject("cmdStart.Image")));
            this.cmdStart.Location = new System.Drawing.Point(669, 3);
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
            this.cmdStop.Location = new System.Drawing.Point(629, 3);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(34, 34);
            this.cmdStop.TabIndex = 3;
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // frmDataProviderInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDataProviderInspector";
            this.Text = "Data Provider Inspector";
            this.Load += new System.EventHandler(this.frmDataProviderInspector_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDataProviderInspector_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpChart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMarketProvider;
        private System.Windows.Forms.ComboBox cboDataProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart dpChart;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCandleCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTimeFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstruments;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Panel panel1;
    }
}