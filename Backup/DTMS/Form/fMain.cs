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
            MenuStrip menuStriptM = new MenuStrip();
            UAP.FM.FMLogin log = new UAP.FM.FMLogin(this, menuStriptM);
            log.ShowDialog();
            //this.menuStrip1 = menuStriptM;
            this.UserID = log.UserID;
            this.UserName = log.UserName;

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
            Utils.FM.BackupDB bk = new Utils.FM.BackupDB();
            bk.ShowDialog();
        }
    }
}
