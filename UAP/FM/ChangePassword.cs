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
    public partial class ChangePassword : Layout.Normal
    {
        string UserID;
        public ChangePassword(string paramUserID)
        {
            InitializeComponent();
            this.ActiveControl = txtOldPass;
            UserID = paramUserID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = Encryption.Encrypt(txtNewPassword.Text);

     
                 if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("please input Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtRetypePass.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("password not match!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNewPassword.Text != txtRetypePass.Text)
                {
                    MessageBox.Show("New Password and Retype-Password does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                {
                    int isExistPassword = BIS.SqlHelper.ExecuteScalarInt("SELECT COUNT(*) FROM T_User WHERE UserID='" + UserID + "' AND Password='" + Utils.CS.Encryption.Encrypt(txtOldPass.Text) + "' ");
                    if (isExistPassword > 0)
                    {
                        SqlHelper.ExecuteNonQuery("UPDATE T_User SET Password='" + Encryption.Encrypt(txtNewPassword.Text) + "',IsChanged=1  WHERE UserID='" + UserID + "' ");
                        txtNewPassword.Clear();
                        MessageBox.Show("Password changed!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("Invalid old-password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



 
 


    }
}
