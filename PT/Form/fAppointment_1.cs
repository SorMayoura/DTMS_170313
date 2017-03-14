using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PT.Form
{
    public partial class fAppointment_1 : Layout.NoTopBar
    {
        public fAppointment_1()
        {
            InitializeComponent();
        }

        private void initAppoinmentData(Boolean bToday, string sDoctor)
        {
            string sql;
            DataTable TAppoinment;

            if (bToday)
            {
                sql = "SELECT * FROM APPOINMENT WHERE APP_DATE = " + DateTime.Today + " AND DR_ID = " + sDoctor;
                TAppoinment = BIS.SqlHelper.ExecuteDataTable(sql);
            } else
            {
                sql = "SELECT * FROM APPOINMENT WHERE APP_DATE between " + dtp_Start.Value + " AND " + dtp_End.Value + " AND DR_ID = " + sDoctor;
                TAppoinment = BIS.SqlHelper.ExecuteDataTable(sql);
            }
            grd_Today.DataSource = TAppoinment;
        }

        private void fAppointment_1_Load(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fAppointment_Mod fApp_Mod = new fAppointment_Mod();
            fApp_Mod.ShowDialog();
        }
    }
}
