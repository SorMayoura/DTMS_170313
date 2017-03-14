using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Utils.CS;
using BIS;

namespace UAP.FM
{
    public partial class Users : Layout.Normal
    {

        string UserID;
        string AutoID = "";
        string trnStatus = "";
        public Users(string paramUserID,bool enableSearch)
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
            UserID = paramUserID;
            initUser();
            if (enableSearch)
            {
                txtSearch.ReadOnly = false;
            }
            else 
            {
             //   txtSearch.HintActive = true;
                txtSearch.TextHint = UserID;
                txtSearch.Text = UserID;
                txtSearch.Enabled = false;
                txtSearch.BackColor = SystemColors.Info;
                btnAddNew.Enabled = false;
                trnStatus = "Update";
            }
        }

        private void initUser()
        {
            string query = @"SELECT    [UserID]
                                      ,[UserName]
                                      ,[Password]
                                      ,[ExpireDate]
                                      ,[Department]
                                      ,[Branch]
                                  FROM [T_User] WHERE Status='A'";
            DataTable tabUser = SqlHelper.ExecuteDataTable(query);
            dgvUser.DataSource = tabUser;
        }

        private void searchUser(string keyWord)
        {
            string query = @"SELECT    [UserID]
                                      ,[UserName]
                                      ,[Password]
                                      ,[ExpireDate]
                                      ,[Department]
                                      ,[Branch]
                                  FROM [T_User] WHERE Status='A' AND ( UserID LIKE N'%" + keyWord + "%' OR UserName LIKE N'%" + keyWord + "%'  OR Department LIKE N'%" + keyWord + "%' OR Branch LIKE N'%" + keyWord + "%' ) ";
            DataTable tabUser = SqlHelper.ExecuteDataTable(query);
            dgvUser.DataSource = tabUser;
        }

        private void Clear() 
        {
            txtUserID.Text = "";
            txtUserName.Text ="";
            txtPassword.Text ="";
            txtRetypePass.Text ="";
            txtDepartment.Text ="";
            txtBranch.Text = "";
            txtPassword.ReadOnly = false;
            txtRetypePass.ReadOnly = false;
            txtPassword.BackColor = Color.White;
            txtRetypePass.BackColor = Color.White;
        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = Encryption.Encrypt(txtPassword.Text);
                
                if (txtUserName.Text == "") 
                {
                    MessageBox.Show("please input UserName!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("please input Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtRetypePass.Text != txtPassword.Text)
                {
                    MessageBox.Show("password not match!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDepartment.Text == "")
                {
                    MessageBox.Show("Please input department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtBranch.Text == "")
                {
                    MessageBox.Show("Please input branch", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (trnStatus == "Insert")
                    {
                        SqlHelper.ExecuteNonQuery("INSERT INTO T_User(UserID,UserName,Password,Department,Branch,CreatedBy,CreatedDate)VALUES('" + AutoID + "','" + txtUserName.Text + "','" + Encryption.Encrypt(txtPassword.Text) + "','" + txtDepartment.Text + "','" + txtBranch.Text + "' ,'" + UserID + "',GETDATE()) ");
                        MessageBox.Show("User saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        trnStatus = "";
                        btnAddNew.Enabled = true;
                        btnSave.Enabled = false;
                        initUser();
                    }
                    else if (trnStatus == "Update") 
                    {
                        SqlHelper.ExecuteNonQuery("Update T_User UserName=N'"+ txtUserName.Text +"',Department=N'"+ txtDepartment.Text +"',Branch=N'"+ txtBranch.Text +"' WHERE UserID='"+ txtUserID.Text +"' ");
                        MessageBox.Show("User updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trnStatus = "";
                        initUser();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchUser(txtSearch.Text);
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUser.SelectedRows)
            {
                txtUserID.Text = row.Cells["colUserID"].Value.ToString();
                txtUserName.Text = row.Cells["colUserName"].Value.ToString();
                txtPassword.Text = row.Cells["colUserName"].Value.ToString();
                txtRetypePass.Text = row.Cells["colUserName"].Value.ToString();
                txtDepartment.Text = row.Cells["colDepartment"].Value.ToString();
                txtBranch.Text = row.Cells["colBranch"].Value.ToString();
                txtPassword.ReadOnly = true;
                txtRetypePass.ReadOnly = true;
                txtPassword.BackColor = SystemColors.Info;
                txtRetypePass.BackColor = SystemColors.Info;
                btnSave.Enabled = true;
                btnAddNew.Enabled = true;
                trnStatus = "Update";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Clear();
            AutoID = Utils.CS.Functions.GenerateID("UserID", "T_User", "U", 2);
            txtUserID.Text = AutoID;
            trnStatus = "Insert";
            this.ActiveControl = txtUserName;
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
        }

 


    }
}
