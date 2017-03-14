
using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;

namespace Utils.CS
{
    public class ControlMenu
    {
        public static List<string[]> ListControl = new List<string[]>();

        private static void initControl(ToolStripMenuItem element)
        {
            string[] list = { element.Name, element.Text };
            ListControl.Add(list);
            foreach (ToolStripMenuItem child in element.DropDownItems)
            {
                initControl(child);
            }
        }

        public static void initControl(MenuStrip menu)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                initControl(item);
            }
        }

        public static void Save(string name, string text)
        {
            DAL.SqlHelper.ExecuteNonQuery("INSERT INTO T_Controls(ControlName,ControlText)VALUES(N'" + name + "',N'" + text + "')");
        }







    }
}

