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
    public partial class AddUser : Layout.Normal
    {

        public AddUser()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    SqlHelper.ExecuteNonQuery("INSERT INTO T_User(UserName,Password,Department,Branch)VALUES('" + txtUserName.Text + "','" + Encryption.Encrypt(txtPassword.Text) + "','" + txtDepartment.Text + "','" + txtBranch.Text + "' )");

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtDepartment.Clear();
                    txtBranch.Clear();
                    MessageBox.Show("User saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private int getUserID() 
        {
            object userID = SqlHelper.ExecuteScalar("Select UserID From T_User Where UserName='"+ txtUserName.Text +"' AND Password='"+ Encryption.Encrypt(txtPassword.Text) +"' ");
            return Convert.ToInt32(userID);
        }

 


    }
}
