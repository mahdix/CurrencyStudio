namespace CurrencyStudio
{
    partial class frmSelectSignalDef
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
            this.treeSignalGroups = new System.Windows.Forms.TreeView();
            this.lstSignalDefs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeSignalGroups
            // 
            this.treeSignalGroups.Location = new System.Drawing.Point(28, 53);
            this.treeSignalGroups.Name = "treeSignalGroups";
            this.treeSignalGroups.Size = new System.Drawing.Size(234, 290);
            this.treeSignalGroups.TabIndex = 0;
            this.treeSignalGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSignalGroups_AfterSelect);
            // 
            // lstSignalDefs
            // 
            this.lstSignalDefs.FormattingEnabled = true;
            this.lstSignalDefs.Location = new System.Drawing.Point(303, 53);
            this.lstSignalDefs.Name = "lstSignalDefs";
            this.lstSignalDefs.Size = new System.Drawing.Size(282, 290);
            this.lstSignalDefs.TabIndex = 1;
            this.lstSignalDefs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSignalDefs_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Signal Groups:";
            // 
            // cmdOk
            // 
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Image = global::CurrencyStudio.Properties.Resources.OK;
            this.cmdOk.Location = new System.Drawing.Point(457, 379);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(128, 41);
            this.cmdOk.TabIndex = 3;
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Image = global::CurrencyStudio.Properties.Resources.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(323, 379);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(128, 41);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Signal Definitions in side the selected group:";
            // 
            // frmSelectSignalDef
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(616, 441);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSignalDefs);
            this.Controls.Add(this.treeSignalGroups);
            this.Name = "frmSelectSignalDef";
            this.ShowInTaskbar = false;
            this.Text = "Select Signal Definition";
            this.Load += new System.EventHandler(this.frmSelectSignalDef_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeSignalGroups;
        private System.Windows.Forms.ListBox lstSignalDefs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label2;
    }
}