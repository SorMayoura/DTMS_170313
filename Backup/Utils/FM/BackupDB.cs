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
    public partial class BackupDB : Layout.Normal
    {
        public BackupDB()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                btnBackUp.Enabled = true;
            } 
       
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            
            Utils.CS.BackupRestore bk = new Utils.CS.BackupRestore();
            bk.Server = DAL.SqlHelper.IPAddress;
            bk.UID = DAL.SqlHelper.UserID;
            bk.PWD = DAL.SqlHelper.Password;
            bk.Database = DAL.SqlHelper.DatabaseName;
            bk.BackPath = txtPath.Text;
            bk.Bar = progressBar;
            bk.DbBackup();
            if (progressBar.Value == 100)
            {
                btnBackUp.Enabled = false;
                lbProgress.Text = bk.Bar.Value.ToString() + "%";
                MessageBox.Show("The Database Was Backup Successfully", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("The Database Failed Backup", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Cursor = Cursors.Default;
           
           
         
        }
    }
}
