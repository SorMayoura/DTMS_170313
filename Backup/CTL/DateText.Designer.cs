namespace CTL
{
    partial class DateText
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDate = new System.Windows.Forms.Label();
            this.btnClearDate = new System.Windows.Forms.Button();
            this.dtpValue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.White;
            this.lbDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDate.Location = new System.Drawing.Point(1, 1);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(132, 21);
            this.lbDate.TabIndex = 1010;
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearDate
            // 
            this.btnClearDate.BackColor = System.Drawing.Color.Silver;
            this.btnClearDate.FlatAppearance.BorderSize = 0;
            this.btnClearDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDate.ForeColor = System.Drawing.Color.White;
            this.btnClearDate.Location = new System.Drawing.Point(139, 2);
            this.btnClearDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnClearDate.Name = "btnClearDate";
            this.btnClearDate.Size = new System.Drawing.Size(17, 19);
            this.btnClearDate.TabIndex = 1009;
            this.btnClearDate.Text = "C";
            this.btnClearDate.UseCompatibleTextRendering = true;
            this.btnClearDate.UseVisualStyleBackColor = false;
            this.btnClearDate.Click += new System.EventHandler(this.btnClearDate_Click);
            // 
            // dtpValue
            // 
            this.dtpValue.CustomFormat = "dd-MM-yyyy";
            this.dtpValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValue.Location = new System.Drawing.Point(0, 0);
            this.dtpValue.Name = "dtpValue";
            this.dtpValue.ShowUpDown = true;
            this.dtpValue.Size = new System.Drawing.Size(175, 23);
            this.dtpValue.TabIndex = 1008;
            this.dtpValue.ValueChanged += new System.EventHandler(this.dtpValue_ValueChanged);
            // 
            // DateText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnClearDate);
            this.Controls.Add(this.dtpValue);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DateText";
            this.Size = new System.Drawing.Size(174, 24);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbDate;
        public System.Windows.Forms.Button btnClearDate;
        public System.Windows.Forms.DateTimePicker dtpValue;

    }
}
