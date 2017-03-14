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
    public partial class fPatient : Layout.NoTopBar
    {
        public fPatient()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            fPatient_Mod pm = new fPatient_Mod();
            pm.ShowDialog();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }
    }
}
