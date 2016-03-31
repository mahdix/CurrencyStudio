namespace CurrencyStudio
{
    partial class frmMarketProviderDesigner
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblDefaultMP = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lstMarketProviders = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataProvProp = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lstDataProviders = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDPProps = new System.Windows.Forms.Panel();
            this.tblDPProps = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDPType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsLive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInstruments = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.marketProp = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lstInstruments = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkInstTimeFrames = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInstSpread = new System.Windows.Forms.TextBox();
            this.txtInstContractSize = new System.Windows.Forms.TextBox();
            this.txtInstPointSize = new System.Windows.Forms.TextBox();
            this.txtInstrumentName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.dataProvProp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlDPProps.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.marketProp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton8,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.lblDefaultMP,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::CurrencyStudio.Properties.Resources.New;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolStripButton4.Size = new System.Drawing.Size(144, 22);
            this.toolStripButton4.Text = "New Market Provider";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(147, 22);
            this.toolStripButton8.Text = "Delete Market Provider";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(147, 22);
            this.toolStripLabel1.Text = "Default Market Provider:";
            // 
            // lblDefaultMP
            // 
            this.lblDefaultMP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDefaultMP.Name = "lblDefaultMP";
            this.lblDefaultMP.Size = new System.Drawing.Size(12, 22);
            this.lblDefaultMP.Text = "?";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::CurrencyStudio.Properties.Resources.SetDefault;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton3.Text = "Set as Default";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::CurrencyStudio.Properties.Resources.CloseSave;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton1.Text = "Save and Close";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::CurrencyStudio.Properties.Resources.CloseNoSave;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(127, 22);
            this.toolStripButton2.Text = "Close without Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstMarketProviders, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 460);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 30);
            this.label14.TabIndex = 0;
            this.label14.Text = "Market Providers";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMarketProviders
            // 
            this.lstMarketProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMarketProviders.FormattingEnabled = true;
            this.lstMarketProviders.Location = new System.Drawing.Point(3, 33);
            this.lstMarketProviders.Name = "lstMarketProviders";
            this.lstMarketProviders.Size = new System.Drawing.Size(163, 420);
            this.lstMarketProviders.TabIndex = 0;
            this.lstMarketProviders.SelectedIndexChanged += new System.EventHandler(this.lstMarketProviders_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataProvProp);
            this.tabControl1.Controls.Add(this.marketProp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(172, 3);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl1, 2);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // dataProvProp
            // 
            this.dataProvProp.Controls.Add(this.panel1);
            this.dataProvProp.Controls.Add(this.toolStrip2);
            this.dataProvProp.Location = new System.Drawing.Point(4, 22);
            this.dataProvProp.Name = "dataProvProp";
            this.dataProvProp.Padding = new System.Windows.Forms.Padding(3);
            this.dataProvProp.Size = new System.Drawing.Size(662, 428);
            this.dataProvProp.TabIndex = 0;
            this.dataProvProp.Text = "Properties";
            this.dataProvProp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 397);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.lstDataProviders, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMPName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pnlDPProps, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtDPName, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cboDPType, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkIsLive, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtInstruments, 2, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 397);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lstDataProviders
            // 
            this.lstDataProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataProviders.FormattingEnabled = true;
            this.lstDataProviders.Location = new System.Drawing.Point(3, 108);
            this.lstDataProviders.Name = "lstDataProviders";
            this.tableLayoutPanel2.SetRowSpan(this.lstDataProviders, 4);
            this.lstDataProviders.Size = new System.Drawing.Size(166, 277);
            this.lstDataProviders.TabIndex = 5;
            this.lstDataProviders.SelectedIndexChanged += new System.EventHandler(this.lstDataProviders_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name:";
            // 
            // txtMPName
            // 
            this.txtMPName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.txtMPName, 2);
            this.txtMPName.Location = new System.Drawing.Point(175, 28);
            this.txtMPName.Name = "txtMPName";
            this.txtMPName.Size = new System.Drawing.Size(447, 20);
            this.txtMPName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Providers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDPProps
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pnlDPProps, 2);
            this.pnlDPProps.Controls.Add(this.tblDPProps);
            this.pnlDPProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDPProps.Location = new System.Drawing.Point(175, 183);
            this.pnlDPProps.Name = "pnlDPProps";
            this.pnlDPProps.Size = new System.Drawing.Size(478, 211);
            this.pnlDPProps.TabIndex = 6;
            // 
            // tblDPProps
            // 
            this.tblDPProps.ColumnCount = 2;
            this.tblDPProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDPProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDPProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDPProps.Location = new System.Drawing.Point(0, 0);
            this.tblDPProps.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tblDPProps.Name = "tblDPProps";
            this.tblDPProps.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.tblDPProps.RowCount = 9;
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDPProps.Size = new System.Drawing.Size(478, 211);
            this.tblDPProps.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // txtDPName
            // 
            this.txtDPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDPName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDPName.Location = new System.Drawing.Point(255, 108);
            this.txtDPName.Name = "txtDPName";
            this.txtDPName.Size = new System.Drawing.Size(398, 20);
            this.txtDPName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // cboDPType
            // 
            this.cboDPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDPType.FormattingEnabled = true;
            this.cboDPType.Location = new System.Drawing.Point(255, 158);
            this.cboDPType.Name = "cboDPType";
            this.cboDPType.Size = new System.Drawing.Size(309, 21);
            this.cboDPType.TabIndex = 7;
            this.cboDPType.SelectedIndexChanged += new System.EventHandler(this.cboDPType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(175, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 30);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(650, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Note that all Data Providers must cover the same time period with the same timefr" +
                "ame. Offline Data Providers can have only one instrument.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsLive
            // 
            this.chkIsLive.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chkIsLive, 2);
            this.chkIsLive.Location = new System.Drawing.Point(175, 53);
            this.chkIsLive.Name = "chkIsLive";
            this.chkIsLive.Size = new System.Drawing.Size(93, 17);
            this.chkIsLive.TabIndex = 10;
            this.chkIsLive.Text = "Is Live Market";
            this.chkIsLive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Instruments:";
            // 
            // txtInstruments
            // 
            this.txtInstruments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstruments.Location = new System.Drawing.Point(255, 133);
            this.txtInstruments.Name = "txtInstruments";
            this.txtInstruments.Size = new System.Drawing.Size(398, 20);
            this.txtInstruments.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(656, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::CurrencyStudio.Properties.Resources.NewProperty;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripButton6.Size = new System.Drawing.Size(137, 22);
            this.toolStripButton6.Text = "New Data Provider";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripButton7.Size = new System.Drawing.Size(146, 22);
            this.toolStripButton7.Text = "Delete Data Provider";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // marketProp
            // 
            this.marketProp.Controls.Add(this.panel2);
            this.marketProp.Controls.Add(this.toolStrip3);
            this.marketProp.Location = new System.Drawing.Point(4, 22);
            this.marketProp.Name = "marketProp";
            this.marketProp.Padding = new System.Windows.Forms.Padding(3);
            this.marketProp.Size = new System.Drawing.Size(662, 428);
            this.marketProp.TabIndex = 1;
            this.marketProp.Text = "Market";
            this.marketProp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 397);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstInstruments, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.chkInstTimeFrames, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtInstSpread, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtInstContractSize, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtInstPointSize, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtInstrumentName, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(656, 397);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Market Provider Instruments";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstInstruments
            // 
            this.lstInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInstruments.FormattingEnabled = true;
            this.lstInstruments.Location = new System.Drawing.Point(3, 33);
            this.lstInstruments.Name = "lstInstruments";
            this.tableLayoutPanel3.SetRowSpan(this.lstInstruments, 5);
            this.lstInstruments.Size = new System.Drawing.Size(248, 355);
            this.lstInstruments.TabIndex = 1;
            this.lstInstruments.SelectedIndexChanged += new System.EventHandler(this.lstInstruments_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Time Frames:";
            // 
            // chkInstTimeFrames
            // 
            this.chkInstTimeFrames.CheckOnClick = true;
            this.chkInstTimeFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkInstTimeFrames.FormattingEnabled = true;
            this.chkInstTimeFrames.Location = new System.Drawing.Point(436, 133);
            this.chkInstTimeFrames.Name = "chkInstTimeFrames";
            this.chkInstTimeFrames.Size = new System.Drawing.Size(217, 259);
            this.chkInstTimeFrames.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Default Spread (points):";
            // 
            // txtInstSpread
            // 
            this.txtInstSpread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstSpread.Location = new System.Drawing.Point(436, 108);
            this.txtInstSpread.Name = "txtInstSpread";
            this.txtInstSpread.Size = new System.Drawing.Size(217, 20);
            this.txtInstSpread.TabIndex = 2;
            // 
            // txtInstContractSize
            // 
            this.txtInstContractSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstContractSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstContractSize.Location = new System.Drawing.Point(436, 83);
            this.txtInstContractSize.Name = "txtInstContractSize";
            this.txtInstContractSize.Size = new System.Drawing.Size(217, 20);
            this.txtInstContractSize.TabIndex = 2;
            // 
            // txtInstPointSize
            // 
            this.txtInstPointSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstPointSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstPointSize.Location = new System.Drawing.Point(436, 58);
            this.txtInstPointSize.Name = "txtInstPointSize";
            this.txtInstPointSize.Size = new System.Drawing.Size(217, 20);
            this.txtInstPointSize.TabIndex = 2;
            // 
            // txtInstrumentName
            // 
            this.txtInstrumentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstrumentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstrumentName.Location = new System.Drawing.Point(436, 33);
            this.txtInstrumentName.Name = "txtInstrumentName";
            this.txtInstrumentName.Size = new System.Drawing.Size(217, 20);
            this.txtInstrumentName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contract Size:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Point Size:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name:";
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton11});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(656, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = global::CurrencyStudio.Properties.Resources.NewProperty;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripButton9.Size = new System.Drawing.Size(124, 22);
            this.toolStripButton9.Text = "New Instrument";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripButton11.Size = new System.Drawing.Size(133, 22);
            this.toolStripButton11.Text = "Delete Instrument";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // frmMarketProviderDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 485);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMarketProviderDesigner";
            this.Text = "Market Provider Manaement";
            this.Load += new System.EventHandler(this.frmMarketProviderDesigner_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.dataProvProp.ResumeLayout(false);
            this.dataProvProp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlDPProps.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.marketProp.ResumeLayout(false);
            this.marketProp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lstMarketProviders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dataProvProp;
        private System.Windows.Forms.TabPage marketProp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstInstruments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDPName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInstrumentName;
        private System.Windows.Forms.TextBox txtInstPointSize;
        private System.Windows.Forms.TextBox txtInstContractSize;
        private System.Windows.Forms.TextBox txtInstSpread;
        private System.Windows.Forms.CheckedListBox chkInstTimeFrames;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblDefaultMP;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ListBox lstDataProviders;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDPProps;
        private System.Windows.Forms.ComboBox cboDPType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel tblDPProps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsLive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInstruments;
    }
}