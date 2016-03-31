using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CurrencyStudio.Core.RuntimeSystem;

namespace CurrencyStudio
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();            
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(loadSerializers));
        }

        private void loadSerializers(object data)
        {
            Serializers.Init();
        }
    }
}
