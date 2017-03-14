namespace Layout
{
    partial class Normal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BTminimizeFM = new System.Windows.Forms.Button();
            this.BTMaximizeFM = new System.Windows.Forms.Button();
            this.BTCloseFM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 329);
            this.panel1.TabIndex = 17;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
            this.splitContainer1.Size = new System.Drawing.Size(595, 327);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 15;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel1_MouseDown);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BTminimizeFM);
            this.splitContainer2.Panel2.Controls.Add(this.BTMaximizeFM);
            this.splitContainer2.Panel2.Controls.Add(this.BTCloseFM);
            this.splitContainer2.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel2_MouseDown);
            this.splitContainer2.Size = new System.Drawing.Size(595, 25);
            this.splitContainer2.SplitterDistance = 479;
            this.splitContainer2.TabIndex = 0;
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTminimizeFM.BackColor = System.Drawing.Color.White;
            this.BTminimizeFM.FlatAppearance.BorderSize = 0;
            this.BTminimizeFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTminimizeFM.Font = new System.Drawing.Font("Marlett", 10.25F);
            this.BTminimizeFM.Location = new System.Drawing.Point(18, 3);
            this.BTminimizeFM.Name = "BTminimizeFM";
            this.BTminimizeFM.Size = new System.Drawing.Size(25, 19);
            this.BTminimizeFM.TabIndex = 13;
            this.BTminimizeFM.TabStop = false;
            this.BTminimizeFM.Text = "";
            this.BTminimizeFM.UseVisualStyleBackColor = false;
            this.BTminimizeFM.Click += new System.EventHandler(this.BTminimizeFM_Click);
            // 
            // BTMaximizeFM
            // 
            this.BTMaximizeFM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTMaximizeFM.BackColor = System.Drawing.Color.White;
            this.BTMaximizeFM.FlatAppearance.BorderSize = 0;
            this.BTMaximizeFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMaximizeFM.Font = new System.Drawing.Font("Marlett", 8.25F);
            this.BTMaximizeFM.Location = new System.Drawing.Point(49, 3);
            this.BTMaximizeFM.Name = "BTMaximizeFM";
            this.BTMaximizeFM.Size = new System.Drawing.Size(25, 19);
            this.BTMaximizeFM.TabIndex = 12;
            this.BTMaximizeFM.Text = "";
            this.BTMaximizeFM.UseVisualStyleBackColor = false;
            this.BTMaximizeFM.Click += new System.EventHandler(this.BTMaximizeFM_Click);
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTCloseFM.BackColor = System.Drawing.Color.Red;
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTCloseFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCloseFM.Font = new System.Drawing.Font("Marlett", 8.25F);
            this.BTCloseFM.ForeColor = System.Drawing.Color.White;
            this.BTCloseFM.Location = new System.Drawing.Point(79, 3);
            this.BTCloseFM.Name = "BTCloseFM";
            this.BTCloseFM.Size = new System.Drawing.Size(23, 19);
            this.BTCloseFM.TabIndex = 14;
            this.BTCloseFM.TabStop = false;
            this.BTCloseFM.Text = "";
            this.BTCloseFM.UseVisualStyleBackColor = false;
            this.BTCloseFM.Click += new System.EventHandler(this.BTCloseFM_Click);
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button BTminimizeFM;
        public System.Windows.Forms.Button BTMaximizeFM;
        public System.Windows.Forms.Button BTCloseFM;
    }
}