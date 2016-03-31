namespace CurrencyStudio
{
    partial class frmSignalProperties
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
            this.signalInstanceProperties = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSignalName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTf = new System.Windows.Forms.TextBox();
            this.txtInst = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signalInstanceProperties
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.signalInstanceProperties, 2);
            this.signalInstanceProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalInstanceProperties.HelpVisible = false;
            this.signalInstanceProperties.Location = new System.Drawing.Point(3, 113);
            this.signalInstanceProperties.Name = "signalInstanceProperties";
            this.signalInstanceProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.signalInstanceProperties.Size = new System.Drawing.Size(370, 358);
            this.signalInstanceProperties.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Signal Name:";
            // 
            // lblSignalName
            // 
            this.lblSignalName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSignalName.AutoSize = true;
            this.lblSignalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignalName.Location = new System.Drawing.Point(123, 28);
            this.lblSignalName.Name = "lblSignalName";
            this.lblSignalName.Size = new System.Drawing.Size(14, 13);
            this.lblSignalName.TabIndex = 10;
            this.lblSignalName.Text = "?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time Frame:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Instruments:";
            // 
            // txtTf
            // 
            this.txtTf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTf.Location = new System.Drawing.Point(123, 55);
            this.txtTf.Name = "txtTf";
            this.txtTf.Size = new System.Drawing.Size(193, 20);
            this.txtTf.TabIndex = 12;
            // 
            // txtInst
            // 
            this.txtInst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInst.Location = new System.Drawing.Point(123, 85);
            this.txtInst.Name = "txtInst";
            this.txtInst.Size = new System.Drawing.Size(239, 20);
            this.txtInst.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtInst, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.signalInstanceProperties, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSignalName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTf, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmdOk, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 514);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Image = global::CurrencyStudio.Properties.Resources.OK;
            this.cmdOk.Location = new System.Drawing.Point(245, 477);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(128, 34);
            this.cmdOk.TabIndex = 13;
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmSignalProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSignalProperties";
            this.Text = "Signal Properties";
            this.Load += new System.EventHandler(this.frmSignalProperties_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid signalInstanceProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSignalName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTf;
        private System.Windows.Forms.TextBox txtInst;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdOk;
    }
}