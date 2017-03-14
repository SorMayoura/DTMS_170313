namespace Utils.FM
{
    partial class BackupDB
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
            this.btnPath = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbProgress = new System.Windows.Forms.Label();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbProgress);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Controls.Add(this.btnPath);
            this.splitContainer1.Panel2.Controls.Add(this.btnBackUp);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPath);
            this.splitContainer1.Size = new System.Drawing.Size(614, 231);
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.FlatAppearance.BorderSize = 0;
            this.BTminimizeFM.Location = new System.Drawing.Point(12, 2);
            this.BTminimizeFM.Size = new System.Drawing.Size(29, 20);
            // 
            // BTMaximizeFM
            // 
            this.BTMaximizeFM.Enabled = false;
            this.BTMaximizeFM.FlatAppearance.BorderSize = 0;
            this.BTMaximizeFM.Location = new System.Drawing.Point(48, 2);
            this.BTMaximizeFM.Size = new System.Drawing.Size(29, 20);
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTCloseFM.Location = new System.Drawing.Point(83, 2);
            this.BTCloseFM.Size = new System.Drawing.Size(27, 20);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(484, 94);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(73, 25);
            this.btnPath.TabIndex = 9;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
//00            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Enabled = false;
            this.btnBackUp.Location = new System.Drawing.Point(484, 124);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(73, 25);
            this.btnBackUp.TabIndex = 8;
            this.btnBackUp.Text = "Backup";
            this.btnBackUp.UseVisualStyleBackColor = true;
//00            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path:";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Info;
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(107, 96);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(354, 22);
            this.txtPath.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(107, 125);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(354, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(282, 152);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(25, 14);
            this.lbProgress.TabIndex = 11;
            this.lbProgress.Text = "0%";
            // 
            // BackupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 233);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BackupDB";
            this.Text = "BackupDB";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbProgress;
    }
}