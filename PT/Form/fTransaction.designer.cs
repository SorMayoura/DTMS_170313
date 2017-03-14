namespace PT.Form
{
    partial class fTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.grd_Today = new System.Windows.Forms.DataGridView();
            this.col_Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Dr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Chair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Appointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Detail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Today)).BeginInit();
            this.SuspendLayout();
            // 
            // BTminimizeFM
            // 
            this.BTminimizeFM.FlatAppearance.BorderSize = 0;
            this.BTminimizeFM.Location = new System.Drawing.Point(2, 1);
            // 
            // BTCloseFM
            // 
            this.BTCloseFM.FlatAppearance.BorderSize = 0;
            this.BTCloseFM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTCloseFM.Location = new System.Drawing.Point(37, 3);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 23);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.splitContainer3.Panel1.Controls.Add(this.btnSave);
            this.splitContainer3.Panel1.Controls.Add(this.textBox2);
            this.splitContainer3.Panel1.Controls.Add(this.textBox1);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.txt_Search);
            this.splitContainer3.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.splitContainer3.Size = new System.Drawing.Size(949, 506);
            this.splitContainer3.SplitterDistance = 75;
            this.splitContainer3.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(638, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 27);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Search";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 21);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 21);
            this.textBox1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(341, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Patient Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Patient        ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(40, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Transaction No :";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(143, 11);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(173, 21);
            this.txt_Search.TabIndex = 26;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 5);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.grd_Today);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button3);
            this.splitContainer4.Panel2.Controls.Add(this.button2);
            this.splitContainer4.Panel2.Controls.Add(this.button1);
            this.splitContainer4.Size = new System.Drawing.Size(949, 422);
            this.splitContainer4.SplitterDistance = 374;
            this.splitContainer4.TabIndex = 0;
            // 
            // grd_Today
            // 
            this.grd_Today.AllowDrop = true;
            this.grd_Today.AllowUserToDeleteRows = false;
            this.grd_Today.AllowUserToResizeColumns = false;
            this.grd_Today.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grd_Today.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Today.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_Today.BackgroundColor = System.Drawing.Color.White;
            this.grd_Today.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Today.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_Today.ColumnHeadersHeight = 25;
            this.grd_Today.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Chk,
            this.col_ID,
            this.col_Name,
            this.col_Time,
            this.col_Dr,
            this.col_Chair,
            this.col_Purpose,
            this.col_TotalPrice,
            this.col_Appointment,
            this.col_Detail});
            this.grd_Today.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Today.EnableHeadersVisualStyles = false;
            this.grd_Today.Location = new System.Drawing.Point(0, 0);
            this.grd_Today.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grd_Today.Name = "grd_Today";
            this.grd_Today.Size = new System.Drawing.Size(949, 374);
            this.grd_Today.TabIndex = 3;
            // 
            // col_Chk
            // 
            this.col_Chk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Chk.FillWeight = 456.8528F;
            this.col_Chk.HeaderText = "";
            this.col_Chk.Name = "col_Chk";
            this.col_Chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Chk.Width = 30;
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 60.34969F;
            this.col_ID.HeaderText = "Transaction No";
            this.col_ID.Name = "col_ID";
            // 
            // col_Name
            // 
            this.col_Name.FillWeight = 60.34969F;
            this.col_Name.HeaderText = "Date";
            this.col_Name.Name = "col_Name";
            // 
            // col_Time
            // 
            this.col_Time.FillWeight = 60.34969F;
            this.col_Time.HeaderText = "Patient";
            this.col_Time.Name = "col_Time";
            // 
            // col_Dr
            // 
            this.col_Dr.FillWeight = 60.34969F;
            this.col_Dr.HeaderText = "Doctor";
            this.col_Dr.Name = "col_Dr";
            // 
            // col_Chair
            // 
            this.col_Chair.FillWeight = 60.34969F;
            this.col_Chair.HeaderText = "Chair No";
            this.col_Chair.Name = "col_Chair";
            // 
            // col_Purpose
            // 
            this.col_Purpose.FillWeight = 60.34969F;
            this.col_Purpose.HeaderText = "Service";
            this.col_Purpose.Name = "col_Purpose";
            // 
            // col_TotalPrice
            // 
            this.col_TotalPrice.FillWeight = 60.34969F;
            this.col_TotalPrice.HeaderText = "Price";
            this.col_TotalPrice.Name = "col_TotalPrice";
            // 
            // col_Appointment
            // 
            this.col_Appointment.FillWeight = 60.34969F;
            this.col_Appointment.HeaderText = "Next Appointment";
            this.col_Appointment.Name = "col_Appointment";
            // 
            // col_Detail
            // 
            this.col_Detail.FillWeight = 60.34969F;
            this.col_Detail.HeaderText = "Detail";
            this.col_Detail.Name = "col_Detail";
            this.col_Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(662, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 27);
            this.button3.TabIndex = 35;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(754, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 27);
            this.button2.TabIndex = 34;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(847, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 33;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.splitContainer3);
            this.Name = "fTransaction";
            this.Text = "fTransaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.splitContainer3, 0);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Today)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView grd_Today;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Dr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Chair;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Appointment;
        private System.Windows.Forms.DataGridViewLinkColumn col_Detail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;



    }
}