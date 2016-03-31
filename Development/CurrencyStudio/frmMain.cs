using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CurrencyStudio
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void commonLibrariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCommonLib().ShowDialog();
        }

        private void marketProviderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMarketProviderDesigner().ShowDialog();
        }

        private void accountsSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAccountDesigner().ShowDialog();
        }

        private void signalStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSignals().ShowDialog();
        }

        private void expertDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmExpertDesigner().ShowDialog();
        }

        private void portfolioManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPortfolioManagers().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new frmSplash().ShowDialog();
            this.Focus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void dataProviderInspectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDataProviderInspector().ShowDialog();
        }

        private void signalDebuggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSignalDebugger().ShowDialog();
        }

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAccountInspector().ShowDialog();
        }

        private void viewLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLogs().ShowDialog();
        }
    }
}
