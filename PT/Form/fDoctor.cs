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
    public partial class fDoctor : Layout.NoTopBar
    {
        public fDoctor()
        {
            InitializeComponent();
        }



        #region Methods

        /// <summary>
        /// initDoctorData
        /// </summary>
        private void initDoctorData() 
        {
            string sql = "SELECT * FROM T_Doctor WHERE Status='A' ";
            DataTable TDoctor = BIS.SqlHelper.ExecuteDataTable(sql);
            grd_Today.DataSource = TDoctor;
        }


        

        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            fDoctor_Mod docM = new fDoctor_Mod();
            docM.ShowDialog();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            fDoctor_Mod docM = new fDoctor_Mod();
            docM.ShowDialog();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
