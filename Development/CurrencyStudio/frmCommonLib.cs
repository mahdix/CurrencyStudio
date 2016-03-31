using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CurrencyStudio.Core.RuntimeSystem;
using CurrencyStudio.Core.Helper;
using System.Reflection;

namespace CurrencyStudio
{
    public partial class frmCommonLib : Form
    {
        public frmCommonLib()
        {
            InitializeComponent();
        }

        private void frmCommonLib_Load(object sender, EventArgs e)
        {
            foreach (string lib in RuntimeManager.GetInstance().CommonLibraries)
            {
                lstLibs.Items.Add(lib);
            }
        }

        private void cmdDeleteLib_Click(object sender, EventArgs e)
        {
            if (lstLibs.SelectedIndex == -1) return;

            int oldIdx = lstLibs.SelectedIndex;
            string name = lstLibs.SelectedItem.ToString();

            RuntimeManager.GetInstance().CommonLibraries.Remove(name);

            File.Delete(Path.Combine(FileUtils.AppFolder, name));

            lstLibs.SelectedIndex = Math.Min(lstLibs.Items.Count - 1, oldIdx);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            RuntimeManager.Save();

            Close();
        }

        private void cmdAddLib_Click(object sender, EventArgs e)
        {
            string file = FileUtils.AskAssemblyFile();

            if (file == null) return;

            string libName = Path.GetFileName(file);
            string targetPath = Path.Combine(FileUtils.AppFolder, Def.CommonLibFolder);
            targetPath = Path.Combine(targetPath ,libName);

            if (File.Exists(targetPath))
            {
                if (MessageBox.Show("A file with the same name exists. overwrite?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            File.Copy(file, targetPath, true);

            RuntimeManager.GetInstance().CommonLibraries.Add(libName);

            lstLibs.Items.Add(libName);
            lstLibs.SelectedIndex = lstLibs.Items.Count-1;
        }
    }
}
