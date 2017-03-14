using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTL
{
    public partial class DateText : UserControl
    {
        public  object DateValue;
        public DateText()
        {
            InitializeComponent();
            DateValue = DBNull.Value;
        }

        private void btnClearDate_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtpValue_ValueChanged(object sender, EventArgs e)
        {
            if (dtpValue.Value != dtpValue.MaxDate)
            {
                lbDate.Visible = false;
                lbDate.Text    = dtpValue.Text;
                DateValue      = dtpValue.Value;
            }
        }

        public void Clear() 
        {
            dtpValue.Value = dtpValue.MaxDate;
            lbDate.Visible = true;
            lbDate.Text = "";
            DateValue = DBNull.Value;
          
        }


    }
}
