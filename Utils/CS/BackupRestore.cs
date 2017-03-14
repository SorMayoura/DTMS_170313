//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Utils.CS
//{
//    class BackupRestore
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Utils.CS
{
    public class BackupRestore
    {
        /// <summary>
   /*00     /// server
        /// </summary>
        private string server = "";
        public string Server
        {
            get { return this.server; }
            set { this.server = value; }
        }
        /// <summary>
        /// log-in name
        /// </summary>
        private string uid = "";
        public string UID
        {
            get { return this.uid; }
            set { this.uid = value; }
        }
        /// <summary>
        /// login password

        /// </summary>
        private string pwd = "";
        public string PWD
        {
            get { return this.pwd; }
            set { this.pwd = value; }
        }
        /// <summary>
        ///The database to be operated
        /// </summary>
        private string database = "";
        public string Database
        {
            get { return this.database; }
            set { this.database = value; }
        }
        /// <summary>
        /// Database connection string
        /// </summary>
        private string conn = "";
        /// <summary>
        /// Backup path
        /// </summary>
        private string backPath = "";
        public string BackPath
        {
            get { return this.backPath; }
            set { this.backPath = value; }
        }
        /// <summary>
        /// Restore the file path
        /// </summary>
        private string restoreFile = "";
        public string RestoreFile
        {
            get { return this.restoreFile; }
            set { this.restoreFile = value; }
        }
        private ProgressBar bar;

        public ProgressBar Bar
        {
            get { return bar; }
            set { bar = value; }
        }
        /// <summary>
        /// Constructor for the DbBackUpAndRestore class
        /// </summary>
        public BackupRestore()
        {
        }
        /// <summary>
        /// Cut the string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="bg"></param>
        /// <param name="ed"></param>
        /// <returns></returns>
        public string StringCut(string str, string bg, string ed)
        {
            string sub;
            sub = str.Substring(str.IndexOf(bg) + bg.Length);
            sub = sub.Substring(0, sub.IndexOf(";"));
            return sub;
        }
        /// <summary>
        /// Construct file name
        /// </summary>
        /// <returns>file name</returns>
        private void CreatePath()
        {
            string CurrTime = System.DateTime.Now.ToString();
            CurrTime = CurrTime.Replace("-", "");
            CurrTime = CurrTime.Replace(":", "");
            CurrTime = CurrTime.Replace(" ", "");
            CurrTime = CurrTime.Substring(0, 12);
            string dbFileName = "\\" + Database + ".BAK";
            string dbPathFile = "\\" + Database + "_" + DateTime.Now.ToString("yyMMdd_hhmmss");
            backPath += dbPathFile;
            if(!Directory.Exists(dbPathFile))
            {
                Directory.CreateDirectory(backPath);
            }
            backPath += dbFileName;
         
        }
        private void Step(string message, int percent)
        {
            Bar.Value = percent;
        }



        public ArrayList GetServerList()
        {
            ArrayList alServers = new ArrayList();

            SQLDMO.Application sqlApp = new SQLDMO.ApplicationClass();
            try
            {
                SQLDMO.NameList serverList = sqlApp.ListAvailableSQLServers();
                for (int i = 1; i <= serverList.Count; i++)
                {
                    alServers.Add(serverList.Item(i));
                    //comboBox1.Items.Add(serverList.Item(i)); 
                    //listBox1.Items.Add(serverList.Item(i));

                }
            }
            catch (Exception e)
            {
                throw (new Exception("Take the database server list error：" + e.Message));
            }
            finally
            {
                sqlApp.Quit();
            }
            return alServers;
        }
        //Get the database list
        public ArrayList GetDbList()
        {
            string ServerName = server;
            string UserName = uid;
            string Password = pwd;

            ArrayList alDbs = new ArrayList();
            SQLDMO.Application sqlApp = new SQLDMO.ApplicationClass();
            SQLDMO.SQLServer svr = new SQLDMO.SQLServerClass();
            try
            {
                svr.Connect(ServerName, UserName, Password);
                foreach (SQLDMO.Database db in svr.Databases)
                {
                    if (db.Name != null)
                        alDbs.Add(db.Name);
                    //listBox2.Items.Add(db.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error connecting to the database：" + e.Message);
            }
            finally
            {
                svr.DisConnect();
                sqlApp.Quit();
            }
            return alDbs;
        } 


        /// <summary>
        /// database backup
        /// </summary>
        /// <returns>Backup is successful</returns>
        public bool DbBackup()
        {
            CreatePath();
            SQLDMO.Backup oBackup = new SQLDMO.BackupClass();
            SQLDMO.SQLServer oSQLServer = new SQLDMO.SQLServerClass();
            try
            {
                oSQLServer.LoginSecure = false;
                oSQLServer.Connect(server, uid, pwd);
                oBackup.Action = SQLDMO.SQLDMO_BACKUP_TYPE.SQLDMOBackup_Database;
                SQLDMO.BackupSink_PercentCompleteEventHandler pceh = new SQLDMO.BackupSink_PercentCompleteEventHandler(Step);
                oBackup.PercentComplete += pceh;
                oBackup.Database = database;
                oBackup.Files = backPath;
                oBackup.BackupSetName = database;
                oBackup.BackupSetDescription = "Database Backup";
                oBackup.Initialize = true;
                oBackup.SQLBackup(oSQLServer);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                oSQLServer.DisConnect();
            }
        }
        /// <summary>
        /// Database recovery
        /// </summary>
        public string DbRestore()
        {
            if (exepro() != true)
            {
                return "Operation Failed";
            }
            else
            {
                SQLDMO.Restore oRestore = new SQLDMO.RestoreClass();
                SQLDMO.SQLServer oSQLServer = new SQLDMO.SQLServerClass();
                try
                {
                  
                    exepro();
                    oSQLServer.LoginSecure = false;
                    oSQLServer.Connect(server, uid, pwd);
                    oRestore.Action = SQLDMO.SQLDMO_RESTORE_TYPE.SQLDMORestore_Database;
                    SQLDMO.RestoreSink_PercentCompleteEventHandler pceh = new SQLDMO.RestoreSink_PercentCompleteEventHandler(Step);
                    oRestore.PercentComplete += pceh;
                    oRestore.Database = database;
                    ///Self-modification
                    oRestore.Files = restoreFile;
                    oRestore.FileNumber = 1;
                    oRestore.ReplaceDatabase = true;
                    oRestore.SQLRestore(oSQLServer);
                    return "The Database Was Restored Successfully";
                }
                catch (Exception e)
                {
                    return "Recovery database failed due to:" + e.Message;
                    throw e;
                }
                finally
                {
                    oSQLServer.DisConnect();
                }
            }
        }
        /// <summary>
        /// Kill all the processes of the current library
        /// </summary>
        /// <returns></returns>
        private bool exepro()
        {
            bool success = true;
            SQLDMO.SQLServer svr = new SQLDMO.SQLServerClass();
            try
            {
                svr.Connect(server, uid, pwd);
                //Get all the list of processes
                SQLDMO.QueryResults qr = svr.EnumProcesses(-1);
                int iColPIDNum = -1;
                int iColDbName = -1;
                //Find and restore database-related processes
                for (int i = 1; i <= qr.Columns; i++)
                {
                    string strName = qr.get_ColumnName(i);
                    if (strName.ToUpper().Trim() == "SPID")
                    {
                        iColPIDNum = i;
                    }
                    else if (strName.ToUpper().Trim() == "DBNAME")
                    {
                        iColDbName = i;
                    }
                    if (iColPIDNum != -1 && iColDbName != -1)
                        break;
                }
                //The relevant process will be closed  

                for (int i = 1; i <= qr.Rows; i++)
                {
                    int lPID = qr.GetColumnLong(i, iColPIDNum);
                    string strDBName = qr.GetColumnString(i, iColDbName);
                    if (strDBName.ToUpper() == database)
                        svr.KillProcess(lPID);
                }
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }
        public bool Operate(bool isBackup)
        {
            //Backup：use master;backup database @name to disk=@path;
            //Restore：use master;restore database @name from disk=@path; 
            SqlConnection connection = new SqlConnection("Data Source=" + server + ";initial catalog=" + database + ";user id=" + uid + ";password=" + pwd + ";");
            //if (!restoreFile.EndsWith(".bak"))
            //{
            //    restoreFile += ".bak";
            //}
            if (isBackup)//backup database 
            {
                SqlCommand command = new SqlCommand("use master;backup database @name to disk=@path;", connection);
                connection.Open();
                command.Parameters.AddWithValue("@name", Database);
                command.Parameters.AddWithValue("@path", restoreFile);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else//Restore the database 
            {
                SqlCommand command = new SqlCommand("use master;restore database @name from disk=@path;", connection);
                connection.Open();
                command.Parameters.AddWithValue("@name", Database);
                command.Parameters.AddWithValue("@path", restoreFile);
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }  00*/
    }
}

