using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Helper;
using CurrencyStudio.Core.UI;
using System.IO;
using CurrencyStudio.Core.RuntimeSystem.Interface;

namespace CurrencyStudio
{
    public partial class frmSignalProperties : Form
    {
        public frmSignalProperties()
        {
            InitializeComponent();
        }

        public SignalInstance signal = null;
        private PropertyBag signalInstancePropertyBag = null;

        private void frmSignalProperties_Load(object sender, EventArgs e)
        {
            lblSignalName.Text = signal.DefinitionName;

            signalInstancePropertyBag = new PropertyBag();
            signalInstancePropertyBag.GetValue += new PropertySpecEventHandler(pBag_GetValue);
            signalInstancePropertyBag.SetValue += new PropertySpecEventHandler(pBag_SetValue);

            signalInstancePropertyBag.Properties.Clear();

            foreach (string param in signal.InternalObject.SignalInput.Keys)
            {
                signalInstancePropertyBag.Properties.Add(new PropertySpec(param, typeof(string)));
            }

            signalInstanceProperties.SelectedObject = signalInstancePropertyBag;
        }

        void pBag_SetValue(object sender, PropertySpecEventArgs e)
        {
            signal.InternalObject.SignalInput[e.Property.Name] = e.Value;
            signal.InputParametersValues[e.Property.Name] = e.Value;
        }

        void pBag_GetValue(object sender, PropertySpecEventArgs e)
        {
            if (signal.InternalObject.SignalInput.ContainsKey(e.Property.Name))
            {
                e.Value = signal.InternalObject.SignalInput[e.Property.Name];
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            signal.TimeFrame = txtTf.Text;
            Utils.DelimitedStringToList(txtInst.Text, signal.Instruments);
            Close();
        }

    }
}
