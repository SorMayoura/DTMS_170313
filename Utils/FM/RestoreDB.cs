using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utils.FM
{
    public partial class RestoreDB : Layout.Normal
    {
        public RestoreDB()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = txtPath.Text;
            openFileDialog1.Filter = "BAK files (*.bak)|*.bak";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPath.Text = openFileDialog1.FileName;
                    btnRestore.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

/*00            this.Cursor = Cursors.WaitCursor;
            Utils.CS.BackupRestore bk = new Utils.CS.BackupRestore();
            bk.Server = DAL.SqlHelper.IPAddress;
            bk.UID = DAL.SqlHelper.UserID;
            bk.PWD = DAL.SqlHelper.Password;
            bk.Database = DAL.SqlHelper.DatabaseName;
            bk.RestoreFile = txtPath.Text;
            bk.Bar = progressBar;
            MessageBox.Show(bk.DbRestore(), "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbProgress.Text = bk.Bar.Value.ToString() + "%";
            this.Cursor = Cursors.Default;
00*/
        }
    }
}
