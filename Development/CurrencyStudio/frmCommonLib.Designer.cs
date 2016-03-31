namespace CurrencyStudio
{
    partial class frmCommonLib
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
            this.lstLibs = new System.Windows.Forms.ListBox();
            this.cmdAddLib = new System.Windows.Forms.Button();
            this.cmdDeleteLib = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLibs
            // 
            this.lstLibs.FormattingEnabled = true;
            this.lstLibs.Location = new System.Drawing.Point(26, 45);
            this.lstLibs.Name = "lstLibs";
            this.lstLibs.Size = new System.Drawing.Size(299, 303);
            this.lstLibs.TabIndex = 0;
            // 
            // cmdAddLib
            // 
            this.cmdAddLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddLib.Image = global::CurrencyStudio.Properties.Resources.Add;
            this.cmdAddLib.Location = new System.Drawing.Point(26, 361);
            this.cmdAddLib.Name = "cmdAddLib";
            this.cmdAddLib.Size = new System.Drawing.Size(132, 42);
            this.cmdAddLib.TabIndex = 1;
            this.cmdAddLib.UseVisualStyleBackColor = true;
            this.cmdAddLib.Click += new System.EventHandler(this.cmdAddLib_Click);
            // 
            // cmdDeleteLib
            // 
            this.cmdDeleteLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeleteLib.Image = global::CurrencyStudio.Properties.Resources.Delete;
            this.cmdDeleteLib.Location = new System.Drawing.Point(193, 361);
            this.cmdDeleteLib.Name = "cmdDeleteLib";
            this.cmdDeleteLib.Size = new System.Drawing.Size(132, 42);
            this.cmdDeleteLib.TabIndex = 1;
            this.cmdDeleteLib.UseVisualStyleBackColor = true;
            this.cmdDeleteLib.Click += new System.EventHandler(this.cmdDeleteLib_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Image = global::CurrencyStudio.Properties.Resources.CloseSave;
            this.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClose.Location = new System.Drawing.Point(26, 419);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(299, 48);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Installed Libraries:";
            // 
            // frmCommonLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdDeleteLib);
            this.Controls.Add(this.cmdAddLib);
            this.Controls.Add(this.lstLibs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCommonLib";
            this.ShowInTaskbar = false;
            this.Text = "Custom Libraries";
            this.Load += new System.EventHandler(this.frmCommonLib_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLibs;
        private System.Windows.Forms.Button cmdAddLib;
        private System.Windows.Forms.Button cmdDeleteLib;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
    }
}