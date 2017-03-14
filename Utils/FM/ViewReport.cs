using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Reflection;
using System.IO;
using DAL;
using System.Collections;

namespace Utils.FM
{

    public partial class ViewReport : Layout.Normal
    {


        public ViewReport()
        {
            InitializeComponent();
        }




        /****** View with Source Object ******/


        private ADODB.Recordset ConvertToRecordset(DataTable inTable)
        {

            ADODB.Recordset result = new ADODB.Recordset();
            result.CursorLocation = ADODB.CursorLocationEnum.adUseClient;

            ADODB.Fields resultFields = result.Fields;
            System.Data.DataColumnCollection inColumns = inTable.Columns;

            foreach (DataColumn inColumn in inColumns)
            {
                resultFields.Append(inColumn.ColumnName
                    , TranslateType(inColumn.DataType)
                    , inColumn.MaxLength
                    , inColumn.AllowDBNull ? ADODB.FieldAttributeEnum.adFldIsNullable : ADODB.FieldAttributeEnum.adFldUnspecified
                    , null);
            }

            result.Open(System.Reflection.Missing.Value
                    , System.Reflection.Missing.Value
                    , ADODB.CursorTypeEnum.adOpenStatic
                    , ADODB.LockTypeEnum.adLockOptimistic, 0);

            foreach (DataRow dr in inTable.Rows)
            {
                result.AddNew(System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                for (int columnIndex = 0; columnIndex < inColumns.Count; columnIndex++)
                {
                    resultFields[columnIndex].Value = dr[columnIndex];
                }
            }

            return result;
        }

        ADODB.DataTypeEnum TranslateType(Type columnType)
        {
            string typeName = columnType.FullName;
            switch (typeName)
            {
                case "System.Boolean":
                    return ADODB.DataTypeEnum.adBoolean;

                case "System.Byte":
                    return ADODB.DataTypeEnum.adUnsignedTinyInt;

                case "System.Char":
                    return ADODB.DataTypeEnum.adChar;

                case "System.DateTime":
                    return ADODB.DataTypeEnum.adDate;

                case "System.Decimal":
                    return ADODB.DataTypeEnum.adCurrency;

                case "System.Double":
                    return ADODB.DataTypeEnum.adDouble;

                case "System.Int16":
                    return ADODB.DataTypeEnum.adSmallInt;

                case "System.Int32":
                    return ADODB.DataTypeEnum.adInteger;

                case "System.Int64":
                    return ADODB.DataTypeEnum.adBigInt;

                case "System.SByte":
                    return ADODB.DataTypeEnum.adTinyInt;

                case "System.Single":
                    return ADODB.DataTypeEnum.adSingle;

                case "System.UInt16":
                    return ADODB.DataTypeEnum.adUnsignedSmallInt;

                case "System.UInt32":
                    return ADODB.DataTypeEnum.adUnsignedInt;

                case "System.UInt64":
                    return ADODB.DataTypeEnum.adUnsignedBigInt;

                case "System.String":
                    return ADODB.DataTypeEnum.adLongVarWChar;
                default:
                    return ADODB.DataTypeEnum.adLongVarWChar;
            }
        }





        public ViewReport(
            string titleReport,
            string rptFile,
            string querySql,
            string[] paramName,
            object[] paramValues,

            string rptFileSubReport,
            string querySqlSubReport,
            string[] paramNameSubReport,
            object[] paramValuesSubReport,
            bool staticPrinter
            )
        {



            InitializeComponent();
            this.Text = titleReport;
            //00 CRAXDDRT.Application crxApp = new CRAXDDRT.Application();
            //00 CRAXDDRT.Report report = new CRAXDDRT.Report();
            ADODB.Connection conn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            string connstr = "Provider=SQLOLEDB;Data Source=" + SqlHelper.IPAddress + ";Initial Catalog=" + SqlHelper.DatabaseName + ";User Id=" + SqlHelper.UserID + ";Password=" + SqlHelper.Password + ";";
            string reportFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "/Report/" + rptFile;
            try
            {
                conn.Open(connstr, null, null, 0);
                //00 report = crxApp.OpenReport(reportFile, OpenReportMethod.OpenReportByDefault);
                //00 report.DiscardSavedData();
                if (paramName != null)
                {
                    for (int i = 0; i < paramName.Length; i++)
                    {
                        ;//00report.ParameterFields.GetItemByName(paramName[i], null).AddCurrentValue(paramValues[i]);
                    }
                }
                rs.Open(
                       querySql,
                    // SQL statement / table,view name /  
                    // stored procedure call / file name 
                       conn,                                            // Connection / connection string 
                       ADODB.CursorTypeEnum.adOpenForwardOnly,          // Cursor type. (forward-only cursor) 
                       ADODB.LockTypeEnum.adLockOptimistic,             // Lock type. (locking records only  
                    // when you call the Update method. 
                      (int)ADODB.CommandTypeEnum.adCmdText);

                /* For Execute StoreProcedure */
                //rs.Open(query, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                //00 report.Database.SetDataSource(rs, 3, 1);

                #region SubReport
                rs = new ADODB.Recordset();
                rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                rs.Open(
                      querySqlSubReport,
                    // SQL statement / table,view name /  
                    // stored procedure call / file name 
                      conn,                                            // Connection / connection string 
                      ADODB.CursorTypeEnum.adOpenForwardOnly,          // Cursor type. (forward-only cursor) 
                      ADODB.LockTypeEnum.adLockOptimistic,             // Lock type. (locking records only  
                    // when you call the Update method. 
                     (int)ADODB.CommandTypeEnum.adCmdText);
                //00 report.OpenSubreport(rptFileSubReport).Database.SetDataSource(rs, 3, 1);
                #endregion

                if (staticPrinter)
                {
                    string printerName = Configurations.getPrinter();
                    //00 report.SelectPrinter("", printerName, "");
                    //report.PrintOut(false, 1, true, 1, 200);
                }
                //00 this.axCrystalActiveXReportViewer1.ReportSource = report;
                this.axCrystalActiveXReportViewer1.ViewReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public ViewReport(string titleReport, string rptFile, string querySql, string[] paramName, object[] paramValues, bool staticPrinter)
        {

            InitializeComponent();
            this.Text = titleReport;
            //00 CRAXDDRT.Application crxApp = new CRAXDDRT.Application();
            //00 CRAXDDRT.Report report = new CRAXDDRT.Report();
            ADODB.Connection conn = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            string connstr = "Provider=SQLOLEDB;Data Source=" + SqlHelper.IPAddress + ";Initial Catalog=" + SqlHelper.DatabaseName + ";User Id=" + SqlHelper.UserID + ";Password=" + SqlHelper.Password + ";";
            string reportFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "/Report/" + rptFile;
            try
            {

                conn.Open(connstr, null, null, 0);
                //00 report = crxApp.OpenReport(reportFile, OpenReportMethod.OpenReportByDefault);
                //00 report.DiscardSavedData();
                if (paramName != null)
                {
                    for (int i = 0; i < paramName.Length; i++)
                    {
                        ;//00 report.ParameterFields.GetItemByName(paramName[i], null).AddCurrentValue(paramValues[i]);
                    }
                }
                rs.Open(
                       querySql,
                    // SQL statement / table,view name /  
                    // stored procedure call / file name 
                       conn,                                            // Connection / connection string 
                       ADODB.CursorTypeEnum.adOpenForwardOnly,          // Cursor type. (forward-only cursor) 
                       ADODB.LockTypeEnum.adLockOptimistic,             // Lock type. (locking records only  
                    // when you call the Update method. 
                      (int)ADODB.CommandTypeEnum.adCmdText);

                /* For Execute StoreProcedure */
            //    rs.Open(querySql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                //00 report.Database.SetDataSource(rs, 3, 1);
                if (staticPrinter)
                {
                    string printerName = Configurations.getPrinter();
                    //00 report.SelectPrinter("", printerName, "");
                    //report.PrintOut(false, 1, true, 1, 200);
                }
                //00 this.axCrystalActiveXReportViewer1.ReportSource = report;
                this.axCrystalActiveXReportViewer1.ViewReport();
               

            }
            catch (Exception ex)
            {
                //this.Dispose();
                //this.Close();
                MessageBox.Show(ex.Message);
                
            }


        }



        public ViewReport
            (
            string titleReport,
            string rptFile,
            string procedureName,
            string procedureParam,
            string[] rptParamName,
            object[] rptParamValues,
            bool staticPrinter

            )
        {



            InitializeComponent();
            this.Text = titleReport;
            //00 CRAXDDRT.Application crxApp = new CRAXDDRT.Application();
            //00 CRAXDDRT.Report report = new CRAXDDRT.Report();
            ADODB.Connection conn = new ADODB.Connection();

            ADODB.Recordset rs = new ADODB.Recordset();
            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            string connstr = "Provider=SQLOLEDB;Data Source=" + SqlHelper.IPAddress + ";Initial Catalog=" + SqlHelper.DatabaseName + ";User Id=" + SqlHelper.UserID + ";Password=" + SqlHelper.Password + ";";
            string reportFile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "/Report/" + rptFile;
            try
            {


                conn.Open(connstr, null, null, 0);
                //00 report = crxApp.OpenReport(reportFile, OpenReportMethod.OpenReportByDefault);
                //00 report.DiscardSavedData();
                if (rptParamName != null)
                {
                    for (int i = 0; i < rptParamName.Length; i++)
                    {
                        //00 report.ParameterFields.GetItemByName(rptParamName[i], null).AddCurrentValue(rptParamValues[i]);
                    }
                }

                rs.Open(procedureName, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);
                //00 report.Database.SetDataSource(rs, 3, 1);
                if (staticPrinter)
                {
                    string printerName = Configurations.getPrinter();
                    //00 report.SelectPrinter("", printerName, "");
                    //report.PrintOut(false, 1, true, 1, 200);
                }
                //00 this.axCrystalActiveXReportViewer1.ReportSource = report;
                this.axCrystalActiveXReportViewer1.ViewReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


    }
}