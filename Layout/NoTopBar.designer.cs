namespace Layout
{
    partial class NoTopBar
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
            this.BTminimizeFM = new System.Windows.Forms.Button();
            this.BTCloseFM = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTminimizeFM.BackColor = System.Drawing.SystemColors.Control;
            this.BTminimizeFM.FlatAppearance.BorderSize = 0;
            this.BTminimizeFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTminimizeFM.Font = new System.Drawing.Font("Marlett", 10.25F);
            this.BTminimizeFM.Location = new System.Drawing.Point(-72, 1);
            this.BTminimizeFM.Name = "BTminimizeFM";
            this.BTminimizeFM.Size = new System.Drawing.Size(25, 19);
            this.BTminimizeFM.TabIndex = 19;
            this.BTminimizeFM.Text = "";
            this.BTminimizeFM.UseVisualStyleBackColor = false;
            this.BTminimizeFM.Click += new System.EventHandler(this.BTminimizeFM_Click_1);
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTCloseFM.BackColor = System.Drawing.SystemColors.Control;
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTCloseFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCloseFM.Font = new System.Drawing.Font("Marlett", 8.25F);
            this.BTCloseFM.ForeColor = System.Drawing.Color.Black;
            this.BTCloseFM.Location = new System.Drawing.Point(-42, 3);
            this.BTCloseFM.Name = "BTCloseFM";
            this.BTCloseFM.Size = new System.Drawing.Size(23, 19);
            this.BTCloseFM.TabIndex = 20;
            this.BTCloseFM.Text = "";
            this.BTCloseFM.UseVisualStyleBackColor = false;
            this.BTCloseFM.Click += new System.EventHandler(this.BTCloseFM_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BTCloseFM);
            this.splitContainer1.Panel2.Controls.Add(this.BTminimizeFM);
            this.splitContainer1.Size = new System.Drawing.Size(597, 23);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.TabIndex = 21;
            // 
            // NoTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoTopBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoTopBar_MouseDown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BTminimizeFM;
        public System.Windows.Forms.Button BTCloseFM;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}