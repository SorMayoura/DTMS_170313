using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;


namespace BIS
{
    public class SqlHelper
    {
        private static SqlDataReader reader;

        public static string IPAddress = Utils.CS.Configuration.getServer();
        public static string DatabaseName = Utils.CS.Configuration.getDatabase();
        public static string UserID = Utils.CS.Configuration.getUserID();
        public static string Password = Utils.CS.Configuration.getPassword();

        public static string connStr = "Data Source=" + IPAddress + ";Initial Catalog=" + DatabaseName + ";USER ID=" + UserID + ";PASSWORD=" + Password + ";";
        public static SqlConnection conn1 = new SqlConnection(connStr);


        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show( ex.Message);
            }

            return 0;
        }

        public static int ExecuteNonQuery(string sql, Dictionary<string,object> parameter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        foreach (KeyValuePair<string, object> pair in parameter)
                        {
                          cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return 0;
        }

       


        public static int ExecuteScalarInt(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(parameters);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return 0;
        }

        public static int ExecuteNonQuery(string sql)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show( ex.Message);
            }

            return 0;
        }


        public static DataTable QueryData(string objectName, string columnNames, string conditions)
        {
            string Query = String.Format("SELECT {0} FROM {1} WHERE {2}", columnNames, objectName, conditions);
            return SqlHelper.ExecuteDataTable(Query);
        }

        public static DataTable QueryData(string objectName, string columnNames, string conditions, string OrderBy)
        {
            string Query = String.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3}", columnNames, objectName, conditions, OrderBy);
            return SqlHelper.ExecuteDataTable(Query);
        }

        public static DataTable QueryData(string objectName)
        {
            string Query = String.Format("SELECT * FROM {0} ", objectName);
            return SqlHelper.ExecuteDataTable(Query);
        }

        public static DataTable QueryData(string objectName, string OrderBy)
        {
            string Query = String.Format("SELECT * FROM {0} ORDER BY {1}", objectName, OrderBy);
            return SqlHelper.ExecuteDataTable(Query);
        }


        //public static enum TransactionType
        //{
        //    Insert,
        //    Update,
        //    Delete
        //}



        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }


        public static DateTime ExecuteScalarDateTime(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    object value = cmd.ExecuteScalar();
                    if (value == DBNull.Value)
                    {
                        value = DateTime.Now;
                    }
                    return Convert.ToDateTime(value);
                }
            }
        }


        public static int ExecuteScalarInt(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    object value = cmd.ExecuteScalar();
                    return Convert.ToInt32(value);
                }
            }
        }


        public static decimal ExecuteScalarDecimal(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    object value = cmd.ExecuteScalar();
                    return Convert.ToDecimal(value);
                }
            }
        }


        public static string ExecuteScalarString(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    object value = cmd.ExecuteScalar();
                    return Convert.ToString(value);
                }
            }
        }

        public static string ExecuteScalarString(string TableName, string ColumnValue, string ColumnCondition, string Value)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string sqlQuery = string.Format("SELECT TOP 1 {0} FROM {1} WHERE {2}='{3}'", ColumnValue, TableName, ColumnCondition, Value);
                    cmd.CommandText = sqlQuery;
                    object value = cmd.ExecuteScalar();
                    return Convert.ToString(value);
                }
            }
        }



        public static decimal ExecuteScalarDecimalProcedure(string procedureName, string[] parameterName, object[] parameterValue)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < parameterName.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
                    }
                    object value = cmd.ExecuteScalar();
                    if (value == DBNull.Value)
                    {
                        value = 0;
                    }
                    return Convert.ToDecimal(value);
                }
            }
        }


        public static object ExecuteScalarProcedure(string procedureName, string[] parameterName, object[] parameterValue)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < parameterName.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static object ExecuteScalarProcedure(string procedureName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    return cmd.ExecuteScalar();
                }
            }
        }


        public static DataTable ExecuteDataTableProcedure(string procedureName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }

        public static DataTable ExecuteDataTableProcedure(string procedureName, string[] parameterName, object[] parameterValue)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < parameterName.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameterName[i], parameterValue[i]);
                    }
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }



        public static DataTable ExecuteDataTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }


        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);

                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }

        public static DataSet ExecuteDataSet(string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                string query = "Select * From " + tableName;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset, tableName);
                    return dataset;
                }
            }
        }

        public static DataSet ExecuteDataSet(string tableName, string condition)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                string query = "Select * From " + tableName + " WHERE " + condition;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset, tableName);
                    return dataset;
                }
            }
        }

        public static void updateData(DataSet ds)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                string tableName = ds.Tables[0].TableName;
                string query = "Select * From " + tableName;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    builder.GetUpdateCommand();
                    adapter.Update(ds, tableName);

                }
            }
        }


        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            return reader;

        }

        public static SqlDataReader GetReader(string sql, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(parameters);
            reader = cmd.ExecuteReader();
            return reader;

        }
        public static int ExecuteSqlTran(string sqlQuery)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    cmd.CommandText = sqlQuery;
                    count = cmd.ExecuteNonQuery();
                    tx.Commit();

                    return count;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            return 0;
        }

        public static void ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {

                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public static int ExecuteSqlTran(List<String> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {

                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }


        public static int ExecuteSqlTranProcedure(string ProcedureName, string[] Parameters, object[] Values)
        {
            if (Parameters.Length != Values.Length)
            {
                System.Windows.Forms.MessageBox.Show("Your Parameters and Values is not equal length!!!", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    SqlTransaction tx = conn.BeginTransaction();
                    cmd.Transaction = tx;
                    try
                    {
                        int count = 0;
                        cmd.CommandText = ProcedureName;
                        cmd.CommandType = CommandType.StoredProcedure;
                        for (int i = 0; i < Parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(Parameters[i], Values[i]);
                        }
                        count += cmd.ExecuteNonQuery();
                        tx.Commit();
                        return count;
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        return 0;
                    }
                }
            }
            return 0;
        }

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }


        private static void PrepareCommandProcedure(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }


        public static object FromDbValue(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return value;
            }
        }

        public static object ToDbValue(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }




        #region Insert Update Delete DataSQL with DataSet



        /// <GetDsView>
        /// GetDsView
        /// </GetDsView>
      /// <param name="querySql"></param>
      /// <returns></returns>
        public static DataSet GetDsView(string querySql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = querySql;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset;
                }
            }
        }

        /// <summary>
        /// Add Row To Table
        /// </summary>
        /// <param name="dsView"></param>
        /// <param name="colNames"></param>
        /// <param name="Values"></param>
        /// <param name="dgvView"></param>
        /// <returns></returns>

        public static void UpdateDataSet(DataSet dsView, string[] colNames, object[] Values, DataGridView dgvView)
        {
            try
            {

                DataRow dr = dsView.Tables[0].NewRow();
                //Set value to all rows
                for (int i = 0; i < colNames.Length; i++)
                {
                    dr[colNames[i]] = Values[i];
                }
                //Add DataRow to DataTable
                dsView.Tables[0].Rows.Add(dr);
                //Refresh DataGridView  
                dgvView.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Update Data DataTable
        /// </summary>
        /// <param name="dsView"></param>
        /// <param name="colNames"></param>
        /// <param name="Values"></param>
        /// <param name="KeyID"></param>
        /// <param name="KeyValue"></param>
        /// <param name="dgvView"></param>

        public static void UpdateDataSet(DataSet dsView, string[] colNames, object[] Values, string KeyID, object KeyValue, DataGridView dgvView)
        {
            try
            {

                DataRow[] dr = dsView.Tables[0].Select(KeyID + "=" + KeyValue);
                //Set value to all rows
                for (int i = 0; i < colNames.Length; i++)
                {
                    dr[0][colNames[i]] = Values[i];
                }
                //Refresh DataGridView
                dgvView.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Remove Row From DataTable
        /// </summary>
        /// <param name="dsView"></param>
        /// <param name="KeyID"></param>
        /// <param name="KeyValue"></param>
        /// <param name="dgvView"></param>
        public static void UpdateDataSet(DataSet dsView, string KeyID, object KeyValue, DataGridView dgvView)
        {
            try
            {

                DataRow[] dr = dsView.Tables[0].Select(KeyID + "=" + KeyValue);
                //Set value to all rows
                dsView.Tables[0].Rows.Remove(dr[0]);
                //Refresh DataGridView
                dgvView.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Get DataAdapter
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static SqlDataAdapter GetAdapter(string tableName)
        {
            SqlDataAdapter adapter = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    adapter = new SqlDataAdapter("SELECT * FROM " + tableName, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.UpdateCommand = builder.GetUpdateCommand();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return adapter;
        }

        /// <summary>
        /// Get DataSet Update
        /// </summary>
        /// <param name="dsView"></param>
        /// <param name="colRemove"></param>
        /// <returns></returns>

        public static DataSet GetDSUpdate(DataSet dsView, string[] colRemove)
        {
            DataSet dsUpdate = dsView;
            try
            {
                //Declare New obj

                //Loop remove columns
                foreach (string colName in colRemove)
                {
                    dsUpdate.Tables[0].Columns.Remove(colName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dsUpdate;
        }
        #endregion

    }

}