namespace Utils.FM
{
    partial class ViewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReport));
            this.axCrystalActiveXReportViewer1 = new AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axCrystalActiveXReportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(910, 469);
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.FlatAppearance.BorderSize = 0;
            // 
            // BTMaximizeFM
            // 
            this.BTMaximizeFM.FlatAppearance.BorderSize = 0;
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            // 
            // axCrystalActiveXReportViewer1
            // 
            this.axCrystalActiveXReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCrystalActiveXReportViewer1.Enabled = true;
            this.axCrystalActiveXReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.axCrystalActiveXReportViewer1.Name = "axCrystalActiveXReportViewer1";
            this.axCrystalActiveXReportViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalActiveXReportViewer1.OcxState")));
            this.axCrystalActiveXReportViewer1.Size = new System.Drawing.Size(910, 440);
            this.axCrystalActiveXReportViewer1.TabIndex = 0;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 471);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewReport";
            this.ShowIcon = false;
            this.Text = "Report";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalActiveXReportViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer axCrystalActiveXReportViewer1;




    }
}