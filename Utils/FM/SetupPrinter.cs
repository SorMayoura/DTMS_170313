using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Utils.CS;

namespace Utils.FM
{
    public partial class SetupPrinter : Layout.Normal
    {

        bool updateConfig;
        public SetupPrinter(bool update)
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbPrinterName.Items.Add(printer);
            }

            if (update)
            {
                cbPrinterName.SelectedIndex = cbPrinterName.FindStringExact(Configurations.getPrinter());
                this.updateConfig = update;
            }

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
                    Configurations.RemoveFileConfig();
                    Configurations.AddConfigConnection(cbPrinterName.Text);
                    MessageBox.Show(" Connection  changed successfully!!", "Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Configurations.AddConfigConnection(cbPrinterName.Text);
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
            if (!Configurations.existFileConfig())
            {
                Application.Exit();
            }
        }


    }

}
namespace Utils.FM{
    class Configurations
    {
        public static string path = Directory.GetCurrentDirectory() + "\\DefaultPrinter.ini";
        public static void AddConfigConnection(string printerName)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("PrinterName:" + printerName);
                }
            }

        }

        public static string getPrinter()
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[1];
                    int index = 0;
                    string s = "";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while ((s = sr.ReadLine()) != null)
                        {
                            connConfig[index] = s;
                            index++;
                        }
                    }

                    if (index == 1)
                    {
                        string printerName = connConfig[0].Replace("PrinterName:", "");
                        return printerName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
        }

        public static bool ReadConfigConnection(string printer)
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[1];
                    int index = 0;
                    string s = "";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    using (StreamReader sr = File.OpenText(path))
                    {

                        while ((s = sr.ReadLine()) != null)
                        {
                            connConfig[index] = s;
                            index++;
                        }
                    }

                    if (index == 1)
                    {
                        string PrinterName = connConfig[0].Replace("PrinterName:", "");


                        if (printer == PrinterName)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;
        }

        public static bool existFileConfig()
        {
            if (File.Exists(path))
            {
                return true;
            }

            return false;
        }

        public static void RemoveFileConfig()
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
    
    }




