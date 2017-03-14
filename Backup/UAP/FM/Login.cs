using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utils.CS;
using BIS;
using Utils.FM;

namespace UAP.FM
{
    public partial class FMLogin : Layout.Normal
    {

        public string UserID { get; set; }
        public string UserName { get; set; }

        //flag login
      bool login = false;
      private Form mainForm;
      MenuStrip menuStripM;


      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
          if (keyData == (Keys.Control | Keys.R))
          {
              Utils.FM.RestoreDB rs = new Utils.FM.RestoreDB();
              rs.ShowDialog();
              return true;
          }
          return base.ProcessCmdKey(ref msg, keyData);
      }

        public FMLogin(Form paramMainForm,MenuStrip paramMenuStrip)
        {
            if (System.IO.File.Exists(Utils.CS.Configuration.path))
            {
                InitializeComponent();
                //Pass Value From paramenter To variable MainForm
                this.mainForm = paramMainForm;
                this.menuStripM = paramMenuStrip;
                lbProductDetails.Text = Application.ProductName + "." + Application.ProductVersion + "   Copyright ©  2016";
                this.ActiveControl = txtUserName;
            }
            else 
            {
                Utils.FM.SetupConnection conn = new Utils.FM.SetupConnection(false);
                conn.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login() 
        {
            //Select Record User
            DataTable recordUser = SqlHelper.ExecuteDataTable("SELECT UserID,UserName FROM T_User Where UserName='" + txtUserName.Text + "' AND Password='" + Encryption.Encrypt(txtPassword.Text) + "' ");
            //If has record
            if (recordUser.Rows.Count > 0)
            {
                //SET login True
                login = true;
                ////SET status User to statusBar
                //mainForm.tslUser.Text = "User: " + txtUserName.Text;
                ////SET status Server to statusBar
                //mainForm.tslServer.Text = "Server: " + SqlHelper.IPAddress;
                ////SET Value UserID to Property MainForm
                //mainForm.UserID = getUserID();
                ////SET Branch To Property
                //mainForm.Branch = getBranch();
                ////SET Value UserName to Property MainForm
                //mainForm.UserName = txtUserName.Text;
                ////System Details
                //mainForm.lbSystemDetails.Text = "MBReport && SMS System       Version." + Application.ProductVersion + "   Copyright ©  2016";


                this.UserID = recordUser.Rows[0]["UserID"].ToString();
                this.UserName = recordUser.Rows[0]["UserName"].ToString(); 
                ////Init Login
                 initUserPermission(menuStripM);
                if (!this.isPasswordChanged())
                {
                    ChangePassword changePassFM = new ChangePassword(getUserID());
                    changePassFM.ShowDialog();
                }
                this.Close();
        

                //this.Cursor = Cursors.WaitCursor;
                //initLoanLate();
                //this.Cursor = Cursors.Default;
        

            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Select isChanged
        private bool isPasswordChanged()
        {
            //Select UserID
            object isChanged = SqlHelper.ExecuteScalar("Select IsChanged From T_User Where UserName='" + txtUserName.Text + "' AND Password='" + Encryption.Encrypt(txtPassword.Text) + "' ");
            if (Convert.ToInt32(isChanged) == 1)
            {
                return true;
            }

            return false;
        }

        //Select UserID
        private string getUserID()
        {
            //Select UserID
            object userID = SqlHelper.ExecuteScalar("Select UserID From T_User Where UserName='" + txtUserName.Text + "' AND Password='" + Encryption.Encrypt(txtPassword.Text) + "' ");
            return Convert.ToString(userID);
        }

        //Select UserID
        private string getBranch()
        {
            //Select UserID
            string branchName = SqlHelper.ExecuteScalarString("Select Branch From T_User Where UserName='" + txtUserName.Text + "' AND Password='" + Encryption.Encrypt(txtPassword.Text) + "' ");
            if (getDepartment() == "Admin") 
            {
                branchName = "All";
            }
            return branchName;
        }

        //Select UserID
        private string getDepartment()
        {
            //Select UserID
            string branchDepName = SqlHelper.ExecuteScalarString("Select Department From T_User Where UserName='" + txtUserName.Text + "' AND Password='" + Encryption.Encrypt(txtPassword.Text) + "' ");
            return branchDepName;
        }


        //init Permission User
        private void initUserPermission(MenuStrip paramMenuStrip)       
        {

            //Query Permission By User
            DataTable tabUserPermission = SqlHelper.ExecuteDataTable("Select * From T_UserPermission Where UserID='" + getUserID() + "' AND Permission=1 AND Status='A' ");

                //Loop Visible Control On The MainForm
                foreach (ToolStripMenuItem item in paramMenuStrip.Items)
                {
                    //Visible controls one by one
                    visibleControlUser(item);
                }
            

            
            //Loop Permission With Control On The MainForm
            foreach (DataRow rows in tabUserPermission.Rows)
            {
                foreach (ToolStripMenuItem item in paramMenuStrip.Items)
                {
                    //Check Permission one by one
                    checkControlUser(item, rows["ControlName"].ToString());
                }
            }

        }


        // Visible Control Users
        private void visibleControlUser(ToolStripMenuItem element)
        {
            //Visible All Control
            element.Visible = false;
            // Loop SubMenu
            foreach (ToolStripMenuItem child in element.DropDownItems)
            {
                //Recursive Control
                visibleControlUser(child);
            }

        }


        // Check Control Users
        private void checkControlUser(ToolStripMenuItem element, string controlID)
        {
            //If ControlID equal ControlName
            if (controlID == element.Name)
            {
                //Enable Control To User
                element.Visible = true;
            }
            // Loop SubMenu
            foreach (ToolStripMenuItem child in element.DropDownItems)
            {
                //Recursive Control
                checkControlUser(child, controlID);
            }

        }


        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If login false Exit Application
            if (login==false)
            {
                Application.Exit();
            }
        }

        private void nextControl(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void cmbLocation_KeyDown(object sender, KeyEventArgs e)
        {
            nextControl(e);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            nextControl(e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                Login();
            }
        }

        private void FMLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.M) 
            {
                Utils.FM.SetupConnection configConnFM = new SetupConnection(true);
                configConnFM.ShowDialog();
            } 
        }

        private void FMLogin_Load(object sender, EventArgs e)
        {

        }

    

    }
}
