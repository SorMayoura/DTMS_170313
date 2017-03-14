namespace DTMS.Form
{
    partial class fMain
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
            this.splitContainer1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer1.Size = new System.Drawing.Size(1220, 674);
            this.splitContainer1.SplitterWidth = 6;
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTminimizeFM.Location = new System.Drawing.Point(-8, 1);
            this.BTminimizeFM.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // BTMaximizeFM
            // 
            this.BTMaximizeFM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTMaximizeFM.Location = new System.Drawing.Point(33, 1);
            this.BTMaximizeFM.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTCloseFM.Location = new System.Drawing.Point(73, 1);
            this.BTCloseFM.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // btn_User
            // 
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // btn_Patient
            // 
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(48, -13);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(89, -13);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // btn_LogOff
            // 
            this.btn_LogOff.Location = new System.Drawing.Point(130, -13);
            this.btn_LogOff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer4.Size = new System.Drawing.Size(1220, 597);
            this.splitContainer4.SplitterWidth = 5;
            // 
            // panelMain
            // 
            this.panelMain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelMain.Size = new System.Drawing.Size(1016, 597);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 676);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "fMain";
            this.Text = "fMain";
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}