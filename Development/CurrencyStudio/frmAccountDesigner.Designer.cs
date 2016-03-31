namespace CurrencyStudio
{
    partial class frmAccountDesigner
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
            this.cmdNewAccount = new System.Windows.Forms.ToolStripButton();
            this.cmdDeleteAccount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblDefaultAccount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.txtLeverage = new System.Windows.Forms.TextBox();
            this.txtCallMargin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMinTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinPosSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPosInc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxOpenPosTotalSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxOpenPosCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinSL = new System.Windows.Forms.TextBox();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNewAccount,
            this.cmdDeleteAccount,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.lblDefaultAccount,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Image = global::CurrencyStudio.Properties.Resources.New;
            this.cmdNewAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cmdNewAccount.Size = new System.Drawing.Size(57, 22);
            this.cmdNewAccount.Text = "New";
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdDeleteAccount
            // 
            this.cmdDeleteAccount.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.cmdDeleteAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDeleteAccount.Name = "cmdDeleteAccount";
            this.cmdDeleteAccount.Size = new System.Drawing.Size(60, 22);
            this.cmdDeleteAccount.Text = "Delete";
            this.cmdDeleteAccount.Click += new System.EventHandler(this.cmdDeleteAccount_Click);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel1.Text = "Default Account:";
            // 
            // lblDefaultAccount
            // 
            this.lblDefaultAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDefaultAccount.Name = "lblDefaultAccount";
            this.lblDefaultAccount.Size = new System.Drawing.Size(12, 22);
            this.lblDefaultAccount.Text = "?";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::CurrencyStudio.Properties.Resources.SetDefault;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton5.Text = "Set as Default";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::CurrencyStudio.Properties.Resources.CloseSave;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolStripButton3.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton3.Text = "Save and Close";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::CurrencyStudio.Properties.Resources.CloseNoSave;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(127, 22);
            this.toolStripButton4.Text = "Close without Save";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtInitialDeposit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLeverage, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCallMargin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAccName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtMinTP, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtMinPosSize, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtPosInc, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtMaxOpenPosTotalSize, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtMaxOpenPosCount, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMinSL, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.lstAccounts, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 423);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Accounts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Depositor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Call Margin Threshold:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Leverage Factor:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Minimum Stop Loss (pts) :";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInitialDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitialDeposit.Location = new System.Drawing.Point(453, 72);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(144, 20);
            this.txtInitialDeposit.TabIndex = 3;
            // 
            // txtLeverage
            // 
            this.txtLeverage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLeverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeverage.Location = new System.Drawing.Point(453, 107);
            this.txtLeverage.Name = "txtLeverage";
            this.txtLeverage.Size = new System.Drawing.Size(144, 20);
            this.txtLeverage.TabIndex = 3;
            // 
            // txtCallMargin
            // 
            this.txtCallMargin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCallMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCallMargin.Location = new System.Drawing.Point(453, 142);
            this.txtCallMargin.Name = "txtCallMargin";
            this.txtCallMargin.Size = new System.Drawing.Size(144, 20);
            this.txtCallMargin.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Account Name:";
            // 
            // txtAccName
            // 
            this.txtAccName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccName.Location = new System.Drawing.Point(453, 37);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(144, 20);
            this.txtAccName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Minimum Take Profit (pts):";
            // 
            // txtMinTP
            // 
            this.txtMinTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMinTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinTP.Location = new System.Drawing.Point(453, 347);
            this.txtMinTP.Name = "txtMinTP";
            this.txtMinTP.Size = new System.Drawing.Size(144, 20);
            this.txtMinTP.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Minimum Position Size:";
            // 
            // txtMinPosSize
            // 
            this.txtMinPosSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMinPosSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinPosSize.Location = new System.Drawing.Point(453, 312);
            this.txtMinPosSize.Name = "txtMinPosSize";
            this.txtMinPosSize.Size = new System.Drawing.Size(144, 20);
            this.txtMinPosSize.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Position Size Increment:";
            // 
            // txtPosInc
            // 
            this.txtPosInc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPosInc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosInc.Location = new System.Drawing.Point(453, 277);
            this.txtPosInc.Name = "txtPosInc";
            this.txtPosInc.Size = new System.Drawing.Size(144, 20);
            this.txtPosInc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Open Position Total Size:";
            // 
            // txtMaxOpenPosTotalSize
            // 
            this.txtMaxOpenPosTotalSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaxOpenPosTotalSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxOpenPosTotalSize.Location = new System.Drawing.Point(453, 242);
            this.txtMaxOpenPosTotalSize.Name = "txtMaxOpenPosTotalSize";
            this.txtMaxOpenPosTotalSize.Size = new System.Drawing.Size(144, 20);
            this.txtMaxOpenPosTotalSize.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maximum Open Position Count:";
            // 
            // txtMaxOpenPosCount
            // 
            this.txtMaxOpenPosCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaxOpenPosCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxOpenPosCount.Location = new System.Drawing.Point(453, 207);
            this.txtMaxOpenPosCount.Name = "txtMaxOpenPosCount";
            this.txtMaxOpenPosCount.Size = new System.Drawing.Size(144, 20);
            this.txtMaxOpenPosCount.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(253, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(431, 30);
            this.label12.TabIndex = 1;
            this.label12.Text = "Account Position Properties:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMinSL
            // 
            this.txtMinSL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMinSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinSL.Location = new System.Drawing.Point(453, 389);
            this.txtMinSL.Name = "txtMinSL";
            this.txtMinSL.Size = new System.Drawing.Size(144, 20);
            this.txtMinSL.TabIndex = 3;
            // 
            // lstAccounts
            // 
            this.lstAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.Location = new System.Drawing.Point(3, 33);
            this.lstAccounts.Name = "lstAccounts";
            this.tableLayoutPanel1.SetRowSpan(this.lstAccounts, 11);
            this.lstAccounts.Size = new System.Drawing.Size(244, 381);
            this.lstAccounts.TabIndex = 2;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // frmAccountDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 448);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAccountDesigner";
            this.ShowInTaskbar = false;
            this.Text = "Account Management";
            this.Load += new System.EventHandler(this.frmAccountDesigner_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdNewAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton cmdDeleteAccount;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblDefaultAccount;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.TextBox txtLeverage;
        private System.Windows.Forms.TextBox txtCallMargin;
        private System.Windows.Forms.TextBox txtMaxOpenPosCount;
        private System.Windows.Forms.TextBox txtMaxOpenPosTotalSize;
        private System.Windows.Forms.TextBox txtPosInc;
        private System.Windows.Forms.TextBox txtMinPosSize;
        private System.Windows.Forms.TextBox txtMinTP;
        private System.Windows.Forms.TextBox txtMinSL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.Label label12;
    }
}