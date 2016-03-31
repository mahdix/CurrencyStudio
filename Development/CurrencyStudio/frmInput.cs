using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CurrencyStudio
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }

        public string msg = "";
        public string defaultInput = "";
        public string result = null;

        private void frmInput_Load(object sender, EventArgs e)
        {
            lblMessage.Text = msg;
            txtInput.Text = defaultInput;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            result = txtInput.Text;
            Close();
        }
    }
}
