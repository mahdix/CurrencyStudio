namespace CurrencyStudio
{
    partial class frmPortfolioManagers
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
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.cmdNewPM = new System.Windows.Forms.ToolStripButton();
            this.cmdNewAssembly = new System.Windows.Forms.ToolStripButton();
            this.cmdDeletePM = new System.Windows.Forms.ToolStripButton();
            this.cmdSavePM = new System.Windows.Forms.ToolStripButton();
            this.cmdSetDefaultPM = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lblDefaultPortfolioManager = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdCloseSave = new System.Windows.Forms.ToolStripButton();
            this.cmdCloseNoSave = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdRefreshProps = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lstPMs = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PMProperties = new System.Windows.Forms.PropertyGrid();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPMRRR = new System.Windows.Forms.TextBox();
            this.lblPMCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdTestMM = new System.Windows.Forms.Button();
            this.lblPMAssemblyName = new System.Windows.Forms.Label();
            this.txtPMCode = new ScintillaNet.Scintilla();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPMCode)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip7
            // 
            this.toolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNewPM,
            this.cmdNewAssembly,
            this.cmdDeletePM,
            this.cmdSavePM,
            this.cmdSetDefaultPM,
            this.toolStripSeparator5,
            this.toolStripLabel5,
            this.lblDefaultPortfolioManager,
            this.toolStripSeparator1,
            this.cmdCloseSave,
            this.cmdCloseNoSave});
            this.toolStrip7.Location = new System.Drawing.Point(0, 0);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(906, 25);
            this.toolStrip7.TabIndex = 5;
            this.toolStrip7.Text = "toolStrip7";
            // 
            // cmdNewPM
            // 
            this.cmdNewPM.Image = global::CurrencyStudio.Properties.Resources.New;
            this.cmdNewPM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNewPM.Name = "cmdNewPM";
            this.cmdNewPM.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cmdNewPM.Size = new System.Drawing.Size(89, 22);
            this.cmdNewPM.Text = "New Inline";
            this.cmdNewPM.Click += new System.EventHandler(this.cmdNewPM_Click);
            // 
            // cmdNewAssembly
            // 
            this.cmdNewAssembly.Image = global::CurrencyStudio.Properties.Resources.NewProperty;
            this.cmdNewAssembly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNewAssembly.Name = "cmdNewAssembly";
            this.cmdNewAssembly.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cmdNewAssembly.Size = new System.Drawing.Size(111, 22);
            this.cmdNewAssembly.Text = "New Assembly";
            this.cmdNewAssembly.Click += new System.EventHandler(this.cmdNewAssembly_Click);
            // 
            // cmdDeletePM
            // 
            this.cmdDeletePM.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.cmdDeletePM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDeletePM.Name = "cmdDeletePM";
            this.cmdDeletePM.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cmdDeletePM.Size = new System.Drawing.Size(66, 22);
            this.cmdDeletePM.Text = "Delete";
            this.cmdDeletePM.Click += new System.EventHandler(this.cmdDeletePM_Click);
            // 
            // cmdSavePM
            // 
            this.cmdSavePM.Image = global::CurrencyStudio.Properties.Resources.Save;
            this.cmdSavePM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSavePM.Name = "cmdSavePM";
            this.cmdSavePM.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cmdSavePM.Size = new System.Drawing.Size(57, 22);
            this.cmdSavePM.Text = "Save";
            this.cmdSavePM.Click += new System.EventHandler(this.cmdSavePM_Click);
            // 
            // cmdSetDefaultPM
            // 
            this.cmdSetDefaultPM.Image = global::CurrencyStudio.Properties.Resources.SetDefault;
            this.cmdSetDefaultPM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSetDefaultPM.Name = "cmdSetDefaultPM";
            this.cmdSetDefaultPM.Size = new System.Drawing.Size(98, 22);
            this.cmdSetDefaultPM.Text = "Set as Default";
            this.cmdSetDefaultPM.Click += new System.EventHandler(this.cmdSetDefaultPM_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(156, 22);
            this.toolStripLabel5.Text = "Default Portfolio Manager:";
            // 
            // lblDefaultPortfolioManager
            // 
            this.lblDefaultPortfolioManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDefaultPortfolioManager.Name = "lblDefaultPortfolioManager";
            this.lblDefaultPortfolioManager.Size = new System.Drawing.Size(12, 22);
            this.lblDefaultPortfolioManager.Text = "?";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdCloseSave
            // 
            this.cmdCloseSave.Image = global::CurrencyStudio.Properties.Resources.CloseSave;
            this.cmdCloseSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCloseSave.Name = "cmdCloseSave";
            this.cmdCloseSave.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cmdCloseSave.Size = new System.Drawing.Size(102, 22);
            this.cmdCloseSave.Text = "Save && Close";
            this.cmdCloseSave.Click += new System.EventHandler(this.cmdCloseSave_Click);
            // 
            // cmdCloseNoSave
            // 
            this.cmdCloseNoSave.Image = global::CurrencyStudio.Properties.Resources.CloseNoSave;
            this.cmdCloseNoSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCloseNoSave.Name = "cmdCloseNoSave";
            this.cmdCloseNoSave.Size = new System.Drawing.Size(127, 22);
            this.cmdCloseNoSave.Text = "Close without Save";
            this.cmdCloseNoSave.Click += new System.EventHandler(this.cmdCloseNoSave_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel5.Controls.Add(this.cmdRefreshProps, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lstPMs, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label18, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.PMProperties, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtPMRRR, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblPMCode, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtPMCode, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(906, 405);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // cmdRefreshProps
            // 
            this.cmdRefreshProps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdRefreshProps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefreshProps.Image = global::CurrencyStudio.Properties.Resources.Refresh;
            this.cmdRefreshProps.Location = new System.Drawing.Point(873, 33);
            this.cmdRefreshProps.Name = "cmdRefreshProps";
            this.cmdRefreshProps.Size = new System.Drawing.Size(25, 23);
            this.cmdRefreshProps.TabIndex = 1;
            this.cmdRefreshProps.UseVisualStyleBackColor = true;
            this.cmdRefreshProps.Click += new System.EventHandler(this.cmdRefreshProps_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 30);
            this.label14.TabIndex = 0;
            this.label14.Text = "Portfolio Managers";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstPMs
            // 
            this.lstPMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPMs.FormattingEnabled = true;
            this.lstPMs.Location = new System.Drawing.Point(3, 33);
            this.lstPMs.Name = "lstPMs";
            this.tableLayoutPanel5.SetRowSpan(this.lstPMs, 3);
            this.lstPMs.Size = new System.Drawing.Size(126, 368);
            this.lstPMs.TabIndex = 1;
            this.lstPMs.SelectedIndexChanged += new System.EventHandler(this.lstPMs_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel5.SetColumnSpan(this.label18, 2);
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(615, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(247, 30);
            this.label18.TabIndex = 0;
            this.label18.Text = "Portfolio Manager Properties";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PMProperties
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.PMProperties, 3);
            this.PMProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMProperties.HelpVisible = false;
            this.PMProperties.Location = new System.Drawing.Point(615, 63);
            this.PMProperties.Name = "PMProperties";
            this.PMProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.tableLayoutPanel5.SetRowSpan(this.PMProperties, 2);
            this.PMProperties.Size = new System.Drawing.Size(288, 339);
            this.PMProperties.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(135, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Risk to Reward Ratio:";
            // 
            // txtPMRRR
            // 
            this.txtPMRRR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPMRRR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPMRRR.Location = new System.Drawing.Point(285, 35);
            this.txtPMRRR.Name = "txtPMRRR";
            this.txtPMRRR.Size = new System.Drawing.Size(305, 20);
            this.txtPMRRR.TabIndex = 12;
            // 
            // lblPMCode
            // 
            this.lblPMCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPMCode.AutoSize = true;
            this.lblPMCode.Location = new System.Drawing.Point(135, 71);
            this.lblPMCode.Name = "lblPMCode";
            this.lblPMCode.Size = new System.Drawing.Size(121, 13);
            this.lblPMCode.TabIndex = 0;
            this.lblPMCode.Text = "Portfolio Manager Code:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmdTestMM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPMAssemblyName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(282, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 35);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // cmdTestMM
            // 
            this.cmdTestMM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdTestMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTestMM.Image = global::CurrencyStudio.Properties.Resources.Test;
            this.cmdTestMM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdTestMM.Location = new System.Drawing.Point(252, 6);
            this.cmdTestMM.Name = "cmdTestMM";
            this.cmdTestMM.Size = new System.Drawing.Size(75, 23);
            this.cmdTestMM.TabIndex = 14;
            this.cmdTestMM.Text = "Test";
            this.cmdTestMM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTestMM.UseVisualStyleBackColor = true;
            this.cmdTestMM.Click += new System.EventHandler(this.cmdTestMM_Click);
            // 
            // lblPMAssemblyName
            // 
            this.lblPMAssemblyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPMAssemblyName.AutoSize = true;
            this.lblPMAssemblyName.Location = new System.Drawing.Point(3, 11);
            this.lblPMAssemblyName.Name = "lblPMAssemblyName";
            this.lblPMAssemblyName.Size = new System.Drawing.Size(13, 13);
            this.lblPMAssemblyName.TabIndex = 0;
            this.lblPMAssemblyName.Text = "?";
            // 
            // txtPMCode
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.txtPMCode, 2);
            this.txtPMCode.ConfigurationManager.Language = "cs";
            this.txtPMCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPMCode.Location = new System.Drawing.Point(135, 98);
            this.txtPMCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.txtPMCode.Margins.Margin0.Width = 25;
            this.txtPMCode.Margins.Margin1.Width = 0;
            this.txtPMCode.Margins.Margin2.Width = 20;
            this.txtPMCode.Name = "txtPMCode";
            this.txtPMCode.Size = new System.Drawing.Size(474, 299);
            this.txtPMCode.Styles.BraceBad.FontName = "Verdana";
            this.txtPMCode.Styles.BraceLight.FontName = "Verdana";
            this.txtPMCode.Styles.ControlChar.FontName = "Verdana";
            this.txtPMCode.Styles.Default.FontName = "Verdana";
            this.txtPMCode.Styles.IndentGuide.FontName = "Verdana";
            this.txtPMCode.Styles.LastPredefined.FontName = "Verdana";
            this.txtPMCode.Styles.LineNumber.FontName = "Verdana";
            this.txtPMCode.Styles.Max.FontName = "Verdana";
            this.txtPMCode.TabIndex = 7;
            // 
            // frmPortfolioManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 430);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.toolStrip7);
            this.Name = "frmPortfolioManagers";
            this.Text = "Portfolio Manager Studio";
            this.Load += new System.EventHandler(this.frmPortfolioManagers_Load);
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPMCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton cmdNewPM;
        private System.Windows.Forms.ToolStripButton cmdDeletePM;
        private System.Windows.Forms.ToolStripButton cmdSavePM;
        private System.Windows.Forms.ToolStripButton cmdSetDefaultPM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lblDefaultPortfolioManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstPMs;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button cmdRefreshProps;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPMRRR;
        private System.Windows.Forms.Label lblPMCode;
        private ScintillaNet.Scintilla txtPMCode;
        private System.Windows.Forms.PropertyGrid PMProperties;
        private System.Windows.Forms.Button cmdTestMM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdCloseSave;
        private System.Windows.Forms.ToolStripButton cmdCloseNoSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton cmdNewAssembly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPMAssemblyName;
    }
}