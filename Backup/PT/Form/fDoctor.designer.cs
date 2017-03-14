namespace PT.Form
{
    partial class fDoctor
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.grd_Today = new System.Windows.Forms.DataGridView();
            this.col_Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
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
            this.splitContainer3.Panel1.Controls.Add(this.txt_Search);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.splitContainer3.Size = new System.Drawing.Size(949, 506);
            this.splitContainer3.SplitterDistance = 46;
            this.splitContainer3.TabIndex = 24;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(161, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(212, 21);
            this.txt_Search.TabIndex = 30;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(41, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Search Keyword :";
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
            this.splitContainer4.Panel2.Controls.Add(this.btn_Add);
            this.splitContainer4.Panel2.Controls.Add(this.btn_Modify);
            this.splitContainer4.Panel2.Controls.Add(this.btn_Del);
            this.splitContainer4.Size = new System.Drawing.Size(949, 451);
            this.splitContainer4.SplitterDistance = 403;
            this.splitContainer4.TabIndex = 0;
            // 
            // grd_Today
            // 
            this.grd_Today.AllowDrop = true;
            this.grd_Today.AllowUserToAddRows = false;
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
            this.col_Sex,
            this.col_Skill,
            this.col_PhoneNum,
            this.col_Email,
            this.col_Address});
            this.grd_Today.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Today.EnableHeadersVisualStyles = false;
            this.grd_Today.Location = new System.Drawing.Point(0, 0);
            this.grd_Today.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grd_Today.Name = "grd_Today";
            this.grd_Today.Size = new System.Drawing.Size(949, 403);
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
            this.col_ID.HeaderText = "Doctor ID";
            this.col_ID.Name = "col_ID";
            // 
            // col_Name
            // 
            this.col_Name.FillWeight = 60.34969F;
            this.col_Name.HeaderText = "Doctor Name";
            this.col_Name.Name = "col_Name";
            // 
            // col_Sex
            // 
            this.col_Sex.FillWeight = 60.34969F;
            this.col_Sex.HeaderText = "Sex";
            this.col_Sex.Name = "col_Sex";
            // 
            // col_Skill
            // 
            this.col_Skill.FillWeight = 60.34969F;
            this.col_Skill.HeaderText = "Skill";
            this.col_Skill.Name = "col_Skill";
            // 
            // col_PhoneNum
            // 
            this.col_PhoneNum.FillWeight = 60.34969F;
            this.col_PhoneNum.HeaderText = "Phone No";
            this.col_PhoneNum.Name = "col_PhoneNum";
            // 
            // col_Email
            // 
            this.col_Email.FillWeight = 60.34969F;
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            // 
            // col_Address
            // 
            this.col_Address.FillWeight = 60.34969F;
            this.col_Address.HeaderText = "Address";
            this.col_Address.Name = "col_Address";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(662, 9);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 27);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modify.BackColor = System.Drawing.Color.White;
            this.btn_Modify.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.Location = new System.Drawing.Point(754, 8);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(92, 27);
            this.btn_Modify.TabIndex = 34;
            this.btn_Modify.Text = "Update";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del.BackColor = System.Drawing.Color.White;
            this.btn_Del.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(847, 8);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(92, 27);
            this.btn_Del.TabIndex = 33;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // fDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 529);
            this.Controls.Add(this.splitContainer3);
            this.Name = "fDoctor";
            this.Text = "fPatient";
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
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView grd_Today;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Skill;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Address;

    }
}