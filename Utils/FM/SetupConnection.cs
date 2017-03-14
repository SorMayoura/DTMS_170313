using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Utils.CS;


namespace Utils.FM
{
    public partial class SetupConnection : Layout.Normal
    {

        bool updateConfig;

        //Drag Drop Control Property


        public SetupConnection(bool update)
        {
            InitializeComponent();
            this.txtServer.CharacterCasing = CharacterCasing.Upper;
            txtServer.Text = Configuration.getServer();
            txtDatabase.Text = Configuration.getDatabase();
            txtUser.Text = Configuration.getUserID();
            txtPassword.Text = Configuration.getPassword();
            this.updateConfig = update;

            this.ActiveControl = txtServer;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateConfig)
                {
                    Configuration.RemoveFileConfig();
                    Configuration.AddConfigConnection(txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
                    MessageBox.Show(" Connection  changed successfully!!", "Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Configuration.AddConfigConnection(txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
                    MessageBox.Show(" Connection  saved successfully!!", "Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void diagConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Configuration.existFileConfig())
            {
                Application.Exit();
            }
        }

       

      
    }

}