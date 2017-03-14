using System;
using System.IO;
using System.Windows.Forms;


namespace Utils.CS
{
    public class Configuration
    {
        public static string path = Directory.GetCurrentDirectory() + "\\ConnectionConfig.ini";
        public static void AddConfigConnection(string server, string database, string user, string password)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Server:" + server);
                    sw.WriteLine("Database:" + database);
                    sw.WriteLine("User:" + user);
                    sw.WriteLine("Password:" + Security.Encrypt(password));
                }
            }

        }

        public static string getServer()
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[4];
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

                    if (index == 4)
                    {
                        string serverName = connConfig[0].Replace("Server:", "");
                        return serverName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
        }
        public static string getDatabase()
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[4];
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

                    if (index == 4)
                    {
                        string databaseName = connConfig[1].Replace("Database:", "");
                        return databaseName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return "";
        }
        public static string getUserID()
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[4];
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

                    if (index == 4)
                    {
                        string userID = connConfig[2].Replace("User:", "");
                        return userID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return "";
        }

        public static string getPassword()
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[4];
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

                    if (index == 4)
                    {
                        string pwd = connConfig[3].Replace("Password:", "");
                        return Security.Decrypt(pwd);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return "";
        }

        public static bool ReadConfigConnection(string server, string database, string user, string password)
        {
            try
            {
                if (File.Exists(path))
                {
                    string[] connConfig = new string[4];
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

                    if (index == 4)
                    {
                        string serverName = connConfig[0].Replace("Server:", "");
                        string databaseName = connConfig[1].Replace("Database:", "");
                        string userName = connConfig[2].Replace("User:", "");
                        string pwd = connConfig[3].Replace("Password:", "");

                        if (server == serverName && database == databaseName && user == userName && Security.Encrypt(password) == pwd)
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

        //try
        //{
        //    File.Delete(path);
        //    File.Copy(path, @"f:\tt.txt");
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("The process failed: {0}", e.ToString());
        //}

    }


}