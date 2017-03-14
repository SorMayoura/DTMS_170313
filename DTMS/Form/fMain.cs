using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTMS.Form
{
    public partial class fMain : Layout.Main
    {
        string UserID = "X";
        string UserName = "X";

        public fMain()
        {
            InitializeComponent();
            //MenuStrip menuStriptM = menuStrip1;
      //00      MenuStrip menuStriptM = new MenuStrip();
      //00      UAP.FM.FMLogin log = new UAP.FM.FMLogin(this, menuStriptM);
      //00      log.ShowDialog();
            //this.menuStrip1 = menuStriptM;
      //00      this.UserID = log.UserID;
      //      this.UserName = log.UserName;

            initStatusDetails();
        }

        #region Methods
        
        private void initStatusDetails()
        {
            if (UserName != null)
            {
                //tslServer.Text = "Server:" + DAL.SqlHelper.IPAddress;
                //tslDatabase.Text = "Database:" + DAL.SqlHelper.DatabaseName;
                //tslUser.Text = "User:" + this.UserName.ToUpper();
                //tslDateTime.Text = "Date:" + DateTime.Now.ToString("dd-MM-yyyy");
            }

        }
        #endregion

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            PT.Form.fAppointment_1 fApp = new PT.Form.fAppointment_1();
            fApp.TopLevel = false;
            this.panelMain.Controls.Add(fApp);
            fApp.Show();
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            PT.Form.fTransaction fTran = new PT.Form.fTransaction();
            fTran.TopLevel = false;
            this.panelMain.Controls.Add(fTran);
            fTran.Show();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            PT.fUser fUsers = new PT.fUser();
            fUsers.TopLevel = false;
            this.panelMain.Controls.Add(fUsers);
            fUsers.Show();
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            PT.Form.fPatient fPat = new PT.Form.fPatient();
            fPat.TopLevel = false;
            this.panelMain.Controls.Add(fPat);
            fPat.Show();
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            PT.Form.fDoctor fDoc = new PT.Form.fDoctor();
            fDoc.TopLevel = false;
            this.panelMain.Controls.Add(fDoc);
            fDoc.Show();
        }

        private void btn_BackUp_Click(object sender, EventArgs e)
        {

        }

        private void btn_Backup_Click_1(object sender, EventArgs e)
        {
            Utils.FM.BackupDB bk = new Utils.FM.BackupDB();
            bk.ShowDialog();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }
    }
}
