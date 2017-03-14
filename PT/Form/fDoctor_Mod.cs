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
    public partial class fDoctor_Mod : Layout.Normal
    {

        public fDoctor_Mod()
        {
            InitializeComponent();
            EnableControl(false);
        }



        #region Variable

        string TrnStatus = "";
        string sql = "";
        Dictionary<string, object> parameter;

        #endregion

        #region Methods


        private void EnableControl(bool status)
        {
            txt_ID.Enabled = status;
            txt_Name.Enabled = status;
            cmb_Sex.Enabled = status;
            cmb_skill.Enabled = status;
            txt_Tel.Enabled = status;
            txt_Mail.Enabled = status;
            txt_Address.Enabled = status;
            
        }

        private void AddNew()
        {
            TrnStatus = "Saved";

            EnableControl(true);
            txt_ID.Enabled = false;
            this.ActiveControl = txt_Name;

 
            txt_ID.Text = "";
            txt_Name.Text = "";
            cmb_Sex.SelectedIndex = -1 ;
            cmb_skill.SelectedIndex = -1;
            txt_Tel.Text = "";
            txt_Mail.Text = "";
            txt_Address.Text = "";
            

        }

        private void UpdateData()
        {
            TrnStatus = "Updated";

            EnableControl(true);
            txt_ID.Enabled = false;
            this.ActiveControl = txt_Name;
        }

        private void SaveData()
        {
            try
            {
                //New Parameter
                parameter = new Dictionary<string, object>();
                parameter.Add("@DocID", txt_ID.Text);
                parameter.Add("@DocName", txt_Name.Text);
                parameter.Add("@Sex", cmb_Sex.Text);
                parameter.Add("@Skill", cmb_skill.Text);
                parameter.Add("@Tel", txt_Tel.Text);
                parameter.Add("@Mail", txt_Mail.Text);
                parameter.Add("@Address", txt_Address.Text);

                if (TrnStatus == "Saved")
                {
                    sql = "INSERT INTO T_Doctor(DocID,DocName,Sex,Skill,Tel,Mail,Address)VALUES(@DocID,@DocName,@Sex,@Skill,@Tel,@Mail,@Address) ";
                }
                else if (TrnStatus == "Updated")
                {
                    sql = "UPDATE T_Doctor SET DocID=@DocID,DocName=@DocName,Sex=@Sex,Skill=@Skill,Tel=@Tel,Mail=@Mail,Address=@Address ";
                }
                
                BIS.SqlHelper.ExecuteNonQuery(sql, parameter);
                MessageBox.Show("Data " + TrnStatus, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        #endregion

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
