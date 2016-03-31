namespace CurrencyStudio
{
    partial class frmSignals
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.cmdUpdateGroup = new System.Windows.Forms.Button();
            this.cmdDeleteGroup = new System.Windows.Forms.Button();
            this.cmdNewGroup = new System.Windows.Forms.Button();
            this.lstSignalDefinitions = new System.Windows.Forms.ListBox();
            this.signalGroupsTree = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSignalCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdTestSignalDefinition = new System.Windows.Forms.Button();
            this.lblSignalAssemblyName = new System.Windows.Forms.Label();
            this.txtSignalDefCode = new ScintillaNet.Scintilla();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cmdNewInline = new System.Windows.Forms.ToolStripButton();
            this.cmdNewAssembly = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdsaveAndClose = new System.Windows.Forms.ToolStripButton();
            this.cmdCloseNoSave = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSignalDefCode)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lstSignalDefinitions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.signalGroupsTree, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSignalCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSignalDefCode, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 410);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdMoveDown);
            this.panel2.Controls.Add(this.cmdMoveUp);
            this.panel2.Controls.Add(this.cmdUpdateGroup);
            this.panel2.Controls.Add(this.cmdDeleteGroup);
            this.panel2.Controls.Add(this.cmdNewGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 29);
            this.panel2.TabIndex = 11;
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMoveDown.Image = global::CurrencyStudio.Properties.Resources.MoveDown;
            this.cmdMoveDown.Location = new System.Drawing.Point(160, 4);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(30, 23);
            this.cmdMoveDown.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdMoveDown, "Move down selected group");
            this.cmdMoveDown.UseVisualStyleBackColor = true;
            this.cmdMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMoveUp.Image = global::CurrencyStudio.Properties.Resources.MoveUp;
            this.cmdMoveUp.Location = new System.Drawing.Point(121, 4);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(30, 23);
            this.cmdMoveUp.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdMoveUp, "Move up selected group");
            this.cmdMoveUp.UseVisualStyleBackColor = true;
            this.cmdMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // cmdUpdateGroup
            // 
            this.cmdUpdateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUpdateGroup.Image = global::CurrencyStudio.Properties.Resources.Update;
            this.cmdUpdateGroup.Location = new System.Drawing.Point(82, 4);
            this.cmdUpdateGroup.Name = "cmdUpdateGroup";
            this.cmdUpdateGroup.Size = new System.Drawing.Size(30, 23);
            this.cmdUpdateGroup.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdUpdateGroup, "Change selected signal group title");
            this.cmdUpdateGroup.UseVisualStyleBackColor = true;
            this.cmdUpdateGroup.Click += new System.EventHandler(this.cmdUpdateGroup_Click);
            // 
            // cmdDeleteGroup
            // 
            this.cmdDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteGroup.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.cmdDeleteGroup.Location = new System.Drawing.Point(43, 4);
            this.cmdDeleteGroup.Name = "cmdDeleteGroup";
            this.cmdDeleteGroup.Size = new System.Drawing.Size(30, 23);
            this.cmdDeleteGroup.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdDeleteGroup, "Delete selected signal group");
            this.cmdDeleteGroup.UseVisualStyleBackColor = true;
            this.cmdDeleteGroup.Click += new System.EventHandler(this.cmdDeleteGroup_Click);
            // 
            // cmdNewGroup
            // 
            this.cmdNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNewGroup.Image = global::CurrencyStudio.Properties.Resources.NewProperty;
            this.cmdNewGroup.Location = new System.Drawing.Point(4, 4);
            this.cmdNewGroup.Name = "cmdNewGroup";
            this.cmdNewGroup.Size = new System.Drawing.Size(30, 23);
            this.cmdNewGroup.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdNewGroup, "Add a new signal group");
            this.cmdNewGroup.UseVisualStyleBackColor = true;
            this.cmdNewGroup.Click += new System.EventHandler(this.cmdNewGroup_Click);
            // 
            // lstSignalDefinitions
            // 
            this.lstSignalDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSignalDefinitions.FormattingEnabled = true;
            this.lstSignalDefinitions.Location = new System.Drawing.Point(3, 63);
            this.lstSignalDefinitions.Name = "lstSignalDefinitions";
            this.lstSignalDefinitions.Size = new System.Drawing.Size(194, 160);
            this.lstSignalDefinitions.TabIndex = 0;
            this.lstSignalDefinitions.SelectedIndexChanged += new System.EventHandler(this.lstSignalDefinitions_SelectedIndexChanged);
            // 
            // signalGroupsTree
            // 
            this.signalGroupsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalGroupsTree.FullRowSelect = true;
            this.signalGroupsTree.HideSelection = false;
            this.signalGroupsTree.HotTracking = true;
            this.signalGroupsTree.Location = new System.Drawing.Point(3, 262);
            this.signalGroupsTree.Name = "signalGroupsTree";
            this.signalGroupsTree.Size = new System.Drawing.Size(194, 110);
            this.signalGroupsTree.TabIndex = 10;
            this.signalGroupsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.signalsTree_AfterSelect);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Signal Groups";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.tableLayoutPanel1.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(194, 60);
            this.label4.TabIndex = 5;
            this.label4.Text = "Signals";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignalCode
            // 
            this.lblSignalCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSignalCode.AutoSize = true;
            this.lblSignalCode.Location = new System.Drawing.Point(203, 8);
            this.lblSignalCode.Name = "lblSignalCode";
            this.lblSignalCode.Size = new System.Drawing.Size(67, 13);
            this.lblSignalCode.TabIndex = 1;
            this.lblSignalCode.Text = "Signal Code:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmdTestSignalDefinition, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSignalAssemblyName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(320, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 30);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // cmdTestSignalDefinition
            // 
            this.cmdTestSignalDefinition.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdTestSignalDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTestSignalDefinition.Image = global::CurrencyStudio.Properties.Resources.Test;
            this.cmdTestSignalDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdTestSignalDefinition.Location = new System.Drawing.Point(504, 3);
            this.cmdTestSignalDefinition.Name = "cmdTestSignalDefinition";
            this.cmdTestSignalDefinition.Size = new System.Drawing.Size(75, 24);
            this.cmdTestSignalDefinition.TabIndex = 9;
            this.cmdTestSignalDefinition.Text = "Test";
            this.cmdTestSignalDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdTestSignalDefinition.UseVisualStyleBackColor = true;
            this.cmdTestSignalDefinition.Click += new System.EventHandler(this.cmdTestSignalDefinition_Click);
            // 
            // lblSignalAssemblyName
            // 
            this.lblSignalAssemblyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSignalAssemblyName.AutoSize = true;
            this.lblSignalAssemblyName.Location = new System.Drawing.Point(3, 8);
            this.lblSignalAssemblyName.Name = "lblSignalAssemblyName";
            this.lblSignalAssemblyName.Size = new System.Drawing.Size(13, 13);
            this.lblSignalAssemblyName.TabIndex = 13;
            this.lblSignalAssemblyName.Text = "?";
            // 
            // txtSignalDefCode
            // 
            this.txtSignalDefCode.AcceptsTab = false;
            this.tableLayoutPanel1.SetColumnSpan(this.txtSignalDefCode, 2);
            this.txtSignalDefCode.ConfigurationManager.Language = "cs";
            this.txtSignalDefCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSignalDefCode.Location = new System.Drawing.Point(203, 33);
            this.txtSignalDefCode.Margins.Margin0.Width = 25;
            this.txtSignalDefCode.Margins.Margin1.Width = 0;
            this.txtSignalDefCode.Margins.Margin2.Width = 20;
            this.txtSignalDefCode.Name = "txtSignalDefCode";
            this.tableLayoutPanel1.SetRowSpan(this.txtSignalDefCode, 5);
            this.txtSignalDefCode.Size = new System.Drawing.Size(696, 374);
            this.txtSignalDefCode.Styles.BraceBad.FontName = "Verdana";
            this.txtSignalDefCode.Styles.BraceLight.FontName = "Verdana";
            this.txtSignalDefCode.Styles.ControlChar.FontName = "Verdana";
            this.txtSignalDefCode.Styles.Default.FontName = "Verdana";
            this.txtSignalDefCode.Styles.IndentGuide.FontName = "Verdana";
            this.txtSignalDefCode.Styles.LastPredefined.FontName = "Verdana";
            this.txtSignalDefCode.Styles.LineNumber.FontName = "Verdana";
            this.txtSignalDefCode.Styles.Max.FontName = "Verdana";
            this.txtSignalDefCode.TabIndex = 8;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNewInline,
            this.cmdNewAssembly,
            this.cmdDelete,
            this.cmdSave,
            this.toolStripSeparator1,
            this.cmdsaveAndClose,
            this.cmdCloseNoSave});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(902, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cmdNewInline
            // 
            this.cmdNewInline.Image = global::CurrencyStudio.Properties.Resources.New;
            this.cmdNewInline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNewInline.Name = "cmdNewInline";
            this.cmdNewInline.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cmdNewInline.Size = new System.Drawing.Size(95, 22);
            this.cmdNewInline.Text = "New Inline";
            this.cmdNewInline.Click += new System.EventHandler(this.cmdNewInline_Click);
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
            // cmdDelete
            // 
            this.cmdDelete.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cmdDelete.Size = new System.Drawing.Size(72, 22);
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Image = global::CurrencyStudio.Properties.Resources.Save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cmdSave.Size = new System.Drawing.Size(63, 22);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdsaveAndClose
            // 
            this.cmdsaveAndClose.Image = global::CurrencyStudio.Properties.Resources.CloseSave;
            this.cmdsaveAndClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdsaveAndClose.Name = "cmdsaveAndClose";
            this.cmdsaveAndClose.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cmdsaveAndClose.Size = new System.Drawing.Size(108, 22);
            this.cmdsaveAndClose.Text = "Save && Close";
            this.cmdsaveAndClose.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cmdCloseNoSave
            // 
            this.cmdCloseNoSave.Image = global::CurrencyStudio.Properties.Resources.CloseNoSave;
            this.cmdCloseNoSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCloseNoSave.Name = "cmdCloseNoSave";
            this.cmdCloseNoSave.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cmdCloseNoSave.Size = new System.Drawing.Size(139, 22);
            this.cmdCloseNoSave.Text = "Close without Save";
            this.cmdCloseNoSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 410);
            this.panel1.TabIndex = 3;
            // 
            // frmSignals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.MaximizeBox = false;
            this.Name = "frmSignals";
            this.ShowInTaskbar = false;
            this.Text = "Signal Studio";
            this.Load += new System.EventHandler(this.frmSignals_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSignalDefCode)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ScintillaNet.Scintilla txtSignalDefCode;
        private System.Windows.Forms.ListBox lstSignalDefinitions;
        private System.Windows.Forms.Label lblSignalCode;
        private System.Windows.Forms.Button cmdTestSignalDefinition;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cmdNewInline;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView signalGroupsTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdUpdateGroup;
        private System.Windows.Forms.Button cmdDeleteGroup;
        private System.Windows.Forms.Button cmdNewGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdsaveAndClose;
        private System.Windows.Forms.ToolStripButton cmdCloseNoSave;
        private System.Windows.Forms.Button cmdMoveDown;
        private System.Windows.Forms.Button cmdMoveUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton cmdNewAssembly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSignalAssemblyName;
    }
}