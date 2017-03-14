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
            this.splitContainer1.Size = new System.Drawing.Size(1107, 723);
            this.splitContainer1.SplitterWidth = 6;
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTminimizeFM.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            // 
            // BTMaximizeFM
            // 
            this.BTMaximizeFM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTMaximizeFM.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTCloseFM.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
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
            // btn_InStruction
            // 
            this.btn_InStruction.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_LogOff
            // 
            this.btn_LogOff.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer4.Size = new System.Drawing.Size(1107, 646);
            this.splitContainer4.SplitterWidth = 5;
            // 
            // panelMain
            // 
            this.panelMain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelMain.Size = new System.Drawing.Size(903, 646);
            // 
            // btn_Backup
            // 
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click_1);
            // 
            // btn_Print
            // 
            this.btn_Print.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 725);
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