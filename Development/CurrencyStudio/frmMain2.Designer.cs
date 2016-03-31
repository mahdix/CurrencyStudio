namespace CurrencyStudio
{
    partial class frmMain2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdCommonLibs = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSimProgress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPositionsSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPositionCountClosed = new System.Windows.Forms.Label();
            this.lblOpenPositionCount = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDefaultPM = new System.Windows.Forms.Label();
            this.lblDefaultAccount = new System.Windows.Forms.Label();
            this.lblDefaultExpert = new System.Windows.Forms.Label();
            this.lblDefaultMP = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.lblTWR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEquity = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblMaxProfit = new System.Windows.Forms.Label();
            this.lblMaxLoss = new System.Windows.Forms.Label();
            this.lblLossInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProfitInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOpenProfit = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.index = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.type = new System.Windows.Forms.ColumnHeader();
            this.size = new System.Windows.Forms.ColumnHeader();
            this.instrument = new System.Windows.Forms.ColumnHeader();
            this.sl = new System.Windows.Forms.ColumnHeader();
            this.tp = new System.Windows.Forms.ColumnHeader();
            this.profit = new System.Windows.Forms.ColumnHeader();
            this.profitpoint = new System.Windows.Forms.ColumnHeader();
            this.isclosed = new System.Windows.Forms.ColumnHeader();
            this.closetime = new System.Windows.Forms.ColumnHeader();
            this.closeprice = new System.Windows.Forms.ColumnHeader();
            this.closereason = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMouseInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 463);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdCommonLibs);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpStats);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdCommonLibs
            // 
            this.cmdCommonLibs.Location = new System.Drawing.Point(522, 280);
            this.cmdCommonLibs.Name = "cmdCommonLibs";
            this.cmdCommonLibs.Size = new System.Drawing.Size(113, 23);
            this.cmdCommonLibs.TabIndex = 5;
            this.cmdCommonLibs.Text = "common libs";
            this.cmdCommonLibs.UseVisualStyleBackColor = true;
            this.cmdCommonLibs.Click += new System.EventHandler(this.cmdCommonLibs_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(486, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Signal Designer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Portfolio Manager Designer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblSimProgress);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblCurrentTime);
            this.groupBox3.Location = new System.Drawing.Point(622, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 141);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulation Info";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 102);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Simulation Progress:";
            // 
            // lblSimProgress
            // 
            this.lblSimProgress.AutoSize = true;
            this.lblSimProgress.Location = new System.Drawing.Point(120, 27);
            this.lblSimProgress.Name = "lblSimProgress";
            this.lblSimProgress.Size = new System.Drawing.Size(35, 13);
            this.lblSimProgress.TabIndex = 0;
            this.lblSimProgress.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Current Time:";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(88, 59);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTotalPositionsSize);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblPositionCountClosed);
            this.groupBox2.Controls.Add(this.lblOpenPositionCount);
            this.groupBox2.Location = new System.Drawing.Point(18, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Positions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Positions Size:";
            // 
            // lblTotalPositionsSize
            // 
            this.lblTotalPositionsSize.AutoSize = true;
            this.lblTotalPositionsSize.Location = new System.Drawing.Point(128, 26);
            this.lblTotalPositionsSize.Name = "lblTotalPositionsSize";
            this.lblTotalPositionsSize.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPositionsSize.TabIndex = 0;
            this.lblTotalPositionsSize.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Closed Position Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Open Position Count:";
            // 
            // lblPositionCountClosed
            // 
            this.lblPositionCountClosed.AutoSize = true;
            this.lblPositionCountClosed.Location = new System.Drawing.Point(139, 53);
            this.lblPositionCountClosed.Name = "lblPositionCountClosed";
            this.lblPositionCountClosed.Size = new System.Drawing.Size(35, 13);
            this.lblPositionCountClosed.TabIndex = 0;
            this.lblPositionCountClosed.Text = "label1";
            // 
            // lblOpenPositionCount
            // 
            this.lblOpenPositionCount.AutoSize = true;
            this.lblOpenPositionCount.Location = new System.Drawing.Point(128, 80);
            this.lblOpenPositionCount.Name = "lblOpenPositionCount";
            this.lblOpenPositionCount.Size = new System.Drawing.Size(35, 13);
            this.lblOpenPositionCount.TabIndex = 0;
            this.lblOpenPositionCount.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDefaultPM);
            this.groupBox4.Controls.Add(this.lblDefaultAccount);
            this.groupBox4.Controls.Add(this.lblDefaultExpert);
            this.groupBox4.Controls.Add(this.lblDefaultMP);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(18, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulatin Setup";
            // 
            // lblDefaultPM
            // 
            this.lblDefaultPM.AutoSize = true;
            this.lblDefaultPM.Location = new System.Drawing.Point(156, 107);
            this.lblDefaultPM.Name = "lblDefaultPM";
            this.lblDefaultPM.Size = new System.Drawing.Size(13, 13);
            this.lblDefaultPM.TabIndex = 0;
            this.lblDefaultPM.Text = "?";
            // 
            // lblDefaultAccount
            // 
            this.lblDefaultAccount.AutoSize = true;
            this.lblDefaultAccount.Location = new System.Drawing.Point(109, 80);
            this.lblDefaultAccount.Name = "lblDefaultAccount";
            this.lblDefaultAccount.Size = new System.Drawing.Size(13, 13);
            this.lblDefaultAccount.TabIndex = 0;
            this.lblDefaultAccount.Text = "?";
            // 
            // lblDefaultExpert
            // 
            this.lblDefaultExpert.AutoSize = true;
            this.lblDefaultExpert.Location = new System.Drawing.Point(103, 53);
            this.lblDefaultExpert.Name = "lblDefaultExpert";
            this.lblDefaultExpert.Size = new System.Drawing.Size(13, 13);
            this.lblDefaultExpert.TabIndex = 0;
            this.lblDefaultExpert.Text = "?";
            // 
            // lblDefaultMP
            // 
            this.lblDefaultMP.AutoSize = true;
            this.lblDefaultMP.Location = new System.Drawing.Point(148, 26);
            this.lblDefaultMP.Name = "lblDefaultMP";
            this.lblDefaultMP.Size = new System.Drawing.Size(13, 13);
            this.lblDefaultMP.TabIndex = 0;
            this.lblDefaultMP.Text = "?";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Default Portfolio Manager:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Default Account:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Default Expert:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Accounts";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Market Providers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Default Market Provider:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Expert Designer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblInitialDeposit);
            this.groupBox1.Controls.Add(this.lblTWR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblEquity);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(18, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Deposit:";
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Location = new System.Drawing.Point(97, 29);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(35, 13);
            this.lblInitialDeposit.TabIndex = 0;
            this.lblInitialDeposit.Text = "label1";
            // 
            // lblTWR
            // 
            this.lblTWR.AutoSize = true;
            this.lblTWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTWR.Location = new System.Drawing.Point(63, 83);
            this.lblTWR.Name = "lblTWR";
            this.lblTWR.Size = new System.Drawing.Size(41, 13);
            this.lblTWR.TabIndex = 0;
            this.lblTWR.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equity:";
            // 
            // lblEquity
            // 
            this.lblEquity.AutoSize = true;
            this.lblEquity.Location = new System.Drawing.Point(63, 56);
            this.lblEquity.Name = "lblEquity";
            this.lblEquity.Size = new System.Drawing.Size(35, 13);
            this.lblEquity.TabIndex = 0;
            this.lblEquity.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "TWR:";
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblMaxProfit);
            this.grpStats.Controls.Add(this.lblMaxLoss);
            this.grpStats.Controls.Add(this.lblLossInfo);
            this.grpStats.Controls.Add(this.label6);
            this.grpStats.Controls.Add(this.label13);
            this.grpStats.Controls.Add(this.label11);
            this.grpStats.Controls.Add(this.lblProfitInfo);
            this.grpStats.Controls.Add(this.label9);
            this.grpStats.Controls.Add(this.lblOpenProfit);
            this.grpStats.Controls.Add(this.lblTotalProfit);
            this.grpStats.Controls.Add(this.label4);
            this.grpStats.Controls.Add(this.label5);
            this.grpStats.Location = new System.Drawing.Point(238, 183);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(242, 237);
            this.grpStats.TabIndex = 2;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Profit/Loss Statistics";
            // 
            // lblMaxProfit
            // 
            this.lblMaxProfit.AutoSize = true;
            this.lblMaxProfit.Location = new System.Drawing.Point(84, 193);
            this.lblMaxProfit.Name = "lblMaxProfit";
            this.lblMaxProfit.Size = new System.Drawing.Size(35, 13);
            this.lblMaxProfit.TabIndex = 0;
            this.lblMaxProfit.Text = "label1";
            // 
            // lblMaxLoss
            // 
            this.lblMaxLoss.AutoSize = true;
            this.lblMaxLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLoss.Location = new System.Drawing.Point(82, 161);
            this.lblMaxLoss.Name = "lblMaxLoss";
            this.lblMaxLoss.Size = new System.Drawing.Size(41, 13);
            this.lblMaxLoss.TabIndex = 0;
            this.lblMaxLoss.Text = "label1";
            // 
            // lblLossInfo
            // 
            this.lblLossInfo.AutoSize = true;
            this.lblLossInfo.Location = new System.Drawing.Point(176, 129);
            this.lblLossInfo.Name = "lblLossInfo";
            this.lblLossInfo.Size = new System.Drawing.Size(35, 13);
            this.lblLossInfo.TabIndex = 0;
            this.lblLossInfo.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max Profit:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Max Loss:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Closed Loss (Total/Avg/Max):";
            // 
            // lblProfitInfo
            // 
            this.lblProfitInfo.AutoSize = true;
            this.lblProfitInfo.Location = new System.Drawing.Point(178, 97);
            this.lblProfitInfo.Name = "lblProfitInfo";
            this.lblProfitInfo.Size = new System.Drawing.Size(35, 13);
            this.lblProfitInfo.TabIndex = 0;
            this.lblProfitInfo.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Closed Profit (Total/Avg/Max):";
            // 
            // lblOpenProfit
            // 
            this.lblOpenProfit.AutoSize = true;
            this.lblOpenProfit.Location = new System.Drawing.Point(117, 65);
            this.lblOpenProfit.Name = "lblOpenProfit";
            this.lblOpenProfit.Size = new System.Drawing.Size(35, 13);
            this.lblOpenProfit.TabIndex = 0;
            this.lblOpenProfit.Text = "label1";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Location = new System.Drawing.Point(115, 33);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(35, 13);
            this.lblTotalProfit.TabIndex = 0;
            this.lblTotalProfit.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Open Profit/Loss:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Profit/Loss:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Price Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.Black;
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(874, 431);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(880, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 431);
            this.panel4.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(674, 420);
            this.listBox1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(677, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 431);
            this.panel3.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(880, 437);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Positions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.time,
            this.type,
            this.size,
            this.instrument,
            this.sl,
            this.tp,
            this.profit,
            this.profitpoint,
            this.isclosed,
            this.closetime,
            this.closeprice,
            this.closereason});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(874, 431);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "#";
            this.index.Width = 35;
            // 
            // time
            // 
            this.time.Text = "Open Time";
            this.time.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 40;
            // 
            // instrument
            // 
            this.instrument.Text = "Symbol";
            // 
            // sl
            // 
            this.sl.Text = "S/L";
            // 
            // tp
            // 
            this.tp.Text = "T/P";
            // 
            // profit
            // 
            this.profit.Text = "Profit ($)";
            // 
            // profitpoint
            // 
            this.profitpoint.Text = "Profit (Pip)";
            // 
            // isclosed
            // 
            this.isclosed.Text = "Closed";
            this.isclosed.Width = 50;
            // 
            // closetime
            // 
            this.closetime.Text = "Close Time";
            this.closetime.Width = 100;
            // 
            // closeprice
            // 
            this.closeprice.Text = "Close Price";
            this.closeprice.Width = 75;
            // 
            // closereason
            // 
            this.closereason.Text = "Close Reason";
            this.closereason.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStep);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 75);
            this.panel1.TabIndex = 5;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(174, 22);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(100, 20);
            this.txtStep.TabIndex = 6;
            this.txtStep.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Step:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMouseInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 53);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMouseInfo
            // 
            this.lblMouseInfo.Name = "lblMouseInfo";
            this.lblMouseInfo.Size = new System.Drawing.Size(118, 17);
            this.lblMouseInfo.Text = "toolStripStatusLabel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 463);
            this.panel2.TabIndex = 6;
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain2";
            this.Text = "Forex Simulator Console - v0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMouseInfo;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblLossInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProfitInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPositionCountClosed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEquity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxLoss;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblOpenPositionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOpenProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPositionsSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTWR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSimProgress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader instrument;
        private System.Windows.Forms.ColumnHeader sl;
        private System.Windows.Forms.ColumnHeader tp;
        private System.Windows.Forms.ColumnHeader profit;
        private System.Windows.Forms.ColumnHeader profitpoint;
        private System.Windows.Forms.ColumnHeader isclosed;
        private System.Windows.Forms.ColumnHeader closetime;
        private System.Windows.Forms.ColumnHeader closeprice;
        private System.Windows.Forms.ColumnHeader closereason;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDefaultExpert;
        private System.Windows.Forms.Label lblDefaultMP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDefaultAccount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDefaultPM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button cmdCommonLibs;
    }
}

