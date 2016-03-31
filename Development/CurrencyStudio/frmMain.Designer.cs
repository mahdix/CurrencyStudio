namespace CurrencyStudio
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioManagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketProviderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonLibrariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataProviderInspectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalDebuggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.marketToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expertDesignerToolStripMenuItem,
            this.signalStudioToolStripMenuItem,
            this.portfolioManagersToolStripMenuItem});
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.expertToolStripMenuItem.Text = "Expert";
            // 
            // signalStudioToolStripMenuItem
            // 
            this.signalStudioToolStripMenuItem.Name = "signalStudioToolStripMenuItem";
            this.signalStudioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.signalStudioToolStripMenuItem.Text = "Signal Studio";
            this.signalStudioToolStripMenuItem.Click += new System.EventHandler(this.signalStudioToolStripMenuItem_Click);
            // 
            // expertDesignerToolStripMenuItem
            // 
            this.expertDesignerToolStripMenuItem.Name = "expertDesignerToolStripMenuItem";
            this.expertDesignerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.expertDesignerToolStripMenuItem.Text = "Expert Designer";
            this.expertDesignerToolStripMenuItem.Click += new System.EventHandler(this.expertDesignerToolStripMenuItem_Click);
            // 
            // portfolioManagersToolStripMenuItem
            // 
            this.portfolioManagersToolStripMenuItem.Name = "portfolioManagersToolStripMenuItem";
            this.portfolioManagersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.portfolioManagersToolStripMenuItem.Text = "Portfolio Managers";
            this.portfolioManagersToolStripMenuItem.Click += new System.EventHandler(this.portfolioManagersToolStripMenuItem_Click);
            // 
            // marketToolStripMenuItem
            // 
            this.marketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketProviderManagementToolStripMenuItem,
            this.accountsSetupToolStripMenuItem});
            this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            this.marketToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.marketToolStripMenuItem.Text = "Market";
            // 
            // marketProviderManagementToolStripMenuItem
            // 
            this.marketProviderManagementToolStripMenuItem.Name = "marketProviderManagementToolStripMenuItem";
            this.marketProviderManagementToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.marketProviderManagementToolStripMenuItem.Text = "Market Provider Management";
            this.marketProviderManagementToolStripMenuItem.Click += new System.EventHandler(this.marketProviderManagementToolStripMenuItem_Click);
            // 
            // accountsSetupToolStripMenuItem
            // 
            this.accountsSetupToolStripMenuItem.Name = "accountsSetupToolStripMenuItem";
            this.accountsSetupToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.accountsSetupToolStripMenuItem.Text = "Account Setup";
            this.accountsSetupToolStripMenuItem.Click += new System.EventHandler(this.accountsSetupToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonLibrariesToolStripMenuItem,
            this.dataProviderInspectorToolStripMenuItem,
            this.accountDetailsToolStripMenuItem,
            this.signalDebuggerToolStripMenuItem,
            this.viewLogsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // commonLibrariesToolStripMenuItem
            // 
            this.commonLibrariesToolStripMenuItem.Name = "commonLibrariesToolStripMenuItem";
            this.commonLibrariesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.commonLibrariesToolStripMenuItem.Text = "Common Libraries";
            this.commonLibrariesToolStripMenuItem.Click += new System.EventHandler(this.commonLibrariesToolStripMenuItem_Click);
            // 
            // dataProviderInspectorToolStripMenuItem
            // 
            this.dataProviderInspectorToolStripMenuItem.Name = "dataProviderInspectorToolStripMenuItem";
            this.dataProviderInspectorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dataProviderInspectorToolStripMenuItem.Text = "Data Provider Inspector";
            this.dataProviderInspectorToolStripMenuItem.Click += new System.EventHandler(this.dataProviderInspectorToolStripMenuItem_Click);
            // 
            // accountDetailsToolStripMenuItem
            // 
            this.accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            this.accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.accountDetailsToolStripMenuItem.Text = "Account Inspector";
            this.accountDetailsToolStripMenuItem.Click += new System.EventHandler(this.accountDetailsToolStripMenuItem_Click);
            // 
            // signalDebuggerToolStripMenuItem
            // 
            this.signalDebuggerToolStripMenuItem.Name = "signalDebuggerToolStripMenuItem";
            this.signalDebuggerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.signalDebuggerToolStripMenuItem.Text = "Signal Debugger";
            this.signalDebuggerToolStripMenuItem.Click += new System.EventHandler(this.signalDebuggerToolStripMenuItem_Click);
            // 
            // viewLogsToolStripMenuItem
            // 
            this.viewLogsToolStripMenuItem.Name = "viewLogsToolStripMenuItem";
            this.viewLogsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewLogsToolStripMenuItem.Text = "View Logs";
            this.viewLogsToolStripMenuItem.Click += new System.EventHandler(this.viewLogsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 17);
            this.lblStatus.Text = "Redy";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Currency Studio - v0.9";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signalStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertDesignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioManagersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketProviderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commonLibrariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem dataProviderInspectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signalDebuggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogsToolStripMenuItem;
    }
}