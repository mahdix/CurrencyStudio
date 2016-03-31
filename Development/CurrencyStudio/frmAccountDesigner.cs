using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.Trade.Descriptor;
using CurrencyStudio.Core.Trade;

namespace CurrencyStudio
{
    public partial class frmAccountDesigner : Form
    {
        private AccountManager accMan = null;
        private AccountDescriptor selectedAccount = null;
        private bool isSaving = false;

        public frmAccountDesigner()
        {
            InitializeComponent();
        }

        private void frmAccountDesigner_Load(object sender, EventArgs e)
        {
            accMan = AccountManager.GetInstance();

            foreach (AccountDescriptor ad in accMan.Accounts)
            {
                lstAccounts.Items.Add(ad.Name);
            }

            if (lstAccounts.Items.Count > 0)
            {
                lstAccounts.SelectedIndex = 0;
            }
        }

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSaving) return;

            if (lstAccounts.SelectedIndex == -1) return;

            if (selectedAccount != null) SaveSelectedAccount();

            selectedAccount = accMan.Accounts[lstAccounts.SelectedIndex];

            txtInitialDeposit.Text = selectedAccount.InitialDeposit.ToString();
            txtLeverage.Text = selectedAccount.LeverageFactor.ToString();
            txtCallMargin.Text = selectedAccount.CallMarginThreshold.ToString();
            txtMaxOpenPosCount.Text = selectedAccount.MaxOpenPositionCountLimitation.ToString();
            txtMaxOpenPosTotalSize.Text = selectedAccount.MaxOpenPositionSize.ToString() ;
            txtMinPosSize.Text = selectedAccount.MinimumPositionSize.ToString();
            txtMinSL.Text = selectedAccount.MinStopLossPips.ToString();
            txtMinTP.Text = selectedAccount.MinTakeProfitPips.ToString();
            txtPosInc.Text = selectedAccount.PositionIncrement.ToString();
            txtAccName.Text = selectedAccount.Name;
        }

        private void SaveSelectedAccount()
        {
            if (selectedAccount == null) return;

            if (selectedAccount.Name != txtAccName.Text)
            {
                if (accMan.FindAccountDescriptor(txtAccName.Text) != null)
                {
                    MessageBox.Show("Account name is repeated");
                    return;
                }

                if (txtAccName.Text.Trim().Length == 0 )
                {
                    MessageBox.Show("Account name is empt");
                    return;
                }
            }

            selectedAccount.InitialDeposit = int.Parse(txtInitialDeposit.Text);
            selectedAccount.LeverageFactor = int.Parse(txtLeverage.Text);
            selectedAccount.CallMarginThreshold = double.Parse(txtCallMargin.Text);
            selectedAccount.MaxOpenPositionCountLimitation = int.Parse(txtMaxOpenPosCount.Text);
            selectedAccount.MaxOpenPositionSize = double.Parse(txtMaxOpenPosTotalSize.Text);
            selectedAccount.MinimumPositionSize = double.Parse(txtMinPosSize.Text);
            selectedAccount.MinStopLossPips = int.Parse(txtMinSL.Text);
            selectedAccount.MinTakeProfitPips = int.Parse(txtMinTP.Text);
            selectedAccount.PositionIncrement = double.Parse(txtPosInc.Text);
            selectedAccount.Name = txtAccName.Text;

            isSaving = true;
            lstAccounts.Items[accMan.Accounts.IndexOf(selectedAccount)] = selectedAccount.Name;
            isSaving = false;

            if (AccountManager.GetInstance().DefaultAccount == null)
            {
                lblDefaultAccount.Text = "";
                AccountManager.GetInstance().DefaultAccountName = "";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveSelectedAccount();
            AccountManager.Save();
            Hide();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AccountManager.Reload();
            Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if ( lstAccounts.SelectedIndex == - 1) return;

            accMan.DefaultAccountName = selectedAccount.Name; ;

            lblDefaultAccount.Text = selectedAccount.Name;
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            AccountDescriptor acc = new AccountDescriptor();

            string name = "acc";
            int counter = 0;

            while (accMan.FindAccountDescriptor(name + counter.ToString()) != null) counter++;

            acc.Name = name + counter.ToString();

            accMan.Accounts.Add(acc);

            lstAccounts.Items.Add(acc.Name);
            lstAccounts.SelectedIndex = lstAccounts.Items.Count - 1;
        }

        private void cmdDeleteAccount_Click(object sender, EventArgs e)
        {
            int idx = lstAccounts.SelectedIndex;

            if (idx == -1) return;

            lstAccounts.Items.RemoveAt(idx);

            accMan.Accounts.RemoveAt(idx);
            selectedAccount = null;

            if (idx < lstAccounts.Items.Count)
            {
                lstAccounts.SelectedIndex = idx;
            }
            else
            {
                lstAccounts.SelectedIndex = lstAccounts.Items.Count - 1;
            }
        }
    }
}
