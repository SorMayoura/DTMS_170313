using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BIS;
using Utils.CS;


namespace UAP.FM
{
    public partial class AddControl : Layout.Normal
    {
        DataTable tabControl = null;

        public AddControl(List<string[]> listControl)
        {
            InitializeComponent();
            tabControl = SqlHelper.ExecuteDataTable("Select ControlName From T_Controls");           
            initNewControl(listControl);
            this.ActiveControl = btnSave;
            if (dgvControl.Rows.Count > 0)
            {
                btnSave.Enabled = true;
            }
            else 
            {
                btnSave.Enabled = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow rows in dgvControl.Rows)
                {
                   ControlMenu.Save(rows.Cells["ControlName"].Value.ToString(), rows.Cells["ControlText"].Value.ToString());
                }
                MessageBox.Show("Controls has saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void initNewControl(List<string[]> paramListControl)
        {
            foreach (string[] control in paramListControl)
            {
               if(isNewControl(control[0]))
               {
                   dgvControl.Rows.Add(control);
               }
            }

        }

        private bool isNewControl(string paramValue)
        {
            bool newControl = true;
            foreach (DataRow row in tabControl.Rows)
            {
                if (row["ControlName"].ToString() == paramValue)
                {
                    newControl = false;
                }
            }
            return newControl;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
