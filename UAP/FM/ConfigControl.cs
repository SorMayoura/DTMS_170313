using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BIS;


namespace UAP.FM
{
    public partial class ConfigControl : Layout.Normal
    {
        DataSet ds;
        public ConfigControl()
        {
            InitializeComponent();
            bindingControl();
            if (dgvControl.Rows.Count > 0)
            {
                btnSave.Enabled = true;
            }
            else 
            {
                btnSave.Enabled = false;
            }
        }

     

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            ds.EndInit();
            SqlHelper.updateData(ds);
            MessageBox.Show("Controls saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bindingControl() 
        {
            
            ds = SqlHelper.ExecuteDataSet("T_Controls"); ;
            dgvControl.DataSource = ds.Tables[0];
        }

    }
}
