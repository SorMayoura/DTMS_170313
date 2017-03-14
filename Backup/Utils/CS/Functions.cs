using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading;

using DAL;


namespace Utils.CS
{
    public class Functions
    {


        public static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch
            {
                // ...
            }
        }


        public static string GenerateID(string columName,string tableNanme,string prefix, int length)
        {
            string lastID = SqlHelper.ExecuteScalarString("SELECT ISNULL(MAX(" + columName + "),0) FROM " + tableNanme + " ");
            int maxID = Convert.ToInt32(GetOnlyNumber(lastID));
            //Example: C011
            string ID = prefix + (maxID + 1).ToString("D" + length.ToString());
            return ID;
        }

        public static decimal GetExchangeRate()
        {
            try
            {
                string query = "SELECT ISNULL(ExchangeRate,0) AS ExchangeRate FROM T_ExchangeRate WHERE DateExchange=(SELECT MAX(DateExchange) FROM T_ExchangeRate) ";
                decimal ExchangeRate = Convert.ToDecimal(SqlHelper.ExecuteScalar(query));
                return ExchangeRate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        public static decimal GetExchangeRate(DateTime dateExchange)
        {
            try
            {
                string query = "SELECT ISNULL(ExchangeRate,0) ExchangeRate  FROM T_ExchangeRate WHERE DATEDIFF(D,DateExchange,'" + dateExchange + "')= 0 ";
                decimal ExchangeRate = Convert.ToDecimal(SqlHelper.ExecuteScalar(query));
                return ExchangeRate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }


        public static string GetOnlyNumber(string str)
        {
            char[] refArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] inputArray = str.ToCharArray();
            string ext = string.Empty;
            foreach (char item in inputArray)
            {
                if (refArray.Contains(item))
                {
                    ext += item.ToString();
                }
            }
            return ext;
        }


        public static string GetDecimal(string str)
        {
            char[] refArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','.' };
            char[] inputArray = str.ToCharArray();
            string ext = string.Empty;
            foreach (char item in inputArray)
            {
                if (refArray.Contains(item))
                {
                    ext += item.ToString();
                }
            }
            return ext;
        }



        public static string FormatNumber(decimal value)
        {
            var s = string.Format("{0:0.00}", value);

            if (s.EndsWith("00"))
            {
                return ((int)value).ToString();
            }
            else
            {
                return s;
            }
        }

        public static decimal ConvertToUSD(decimal rate, decimal amountInput)
        {
           decimal amountUSD = 0;
           amountUSD = amountInput / rate;
         return amountUSD;
        }

        public static decimal ConvertToRiel(decimal rate, decimal amountInput)
        {
            decimal amountRiel = 0;
            amountRiel = amountInput * rate;
            
            return amountRiel;
        }



        public static int indexCombobox(ComboBox cmbItem, string valueDisplay)
        {
            int index = -1;
            if (cmbItem.DisplayMember == cmbItem.ValueMember)
            {
                foreach (DataRowView rv in cmbItem.Items)
                {
                    index++;
                    if (rv[0].ToString() == valueDisplay)
                    {
                        return index;
                    }
                }
            }
            else
            {
                foreach (DataRowView rv in cmbItem.Items)
                {
                    index++;
                    if (rv[0].ToString() == valueDisplay || rv[1].ToString() == valueDisplay)
                    {
                        return index;
                    }

                }
            }

            
            return 0;
        }

        public static DataRow[] RowArray(DataTable TData, string columnFilter, string valueFilter, bool likeFilter)
        {
            try
            {
                //Filter Data
                if (!likeFilter)
                {
                    var query = TData.AsEnumerable()
                      .Where
                       (
                       fields =>
                       fields.Field<string>(columnFilter) == valueFilter
                       )
                       .OrderBy(fields => fields.Field<string>(columnFilter));
                    // If have Reocrd
                    if (query.GetEnumerator().MoveNext())
                    {
                        // Set DataTable from Linq
                        return query.CopyToDataTable().Select();
                    }

                }
                //Filter Data with Like
                else
                {
                 var query = TData.AsEnumerable()
                .Where
                 (
                 fields =>
                 fields.Field<string>(columnFilter).Contains(valueFilter)
                 )
                 .OrderBy(fields => fields.Field<string>(columnFilter));
                    // If have Reocrd
                    if (query.GetEnumerator().MoveNext())
                    {
                        // Set DataTable from Linq
                        return query.CopyToDataTable().Select();
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }


        public static DataTable TFilter(DataTable TData, string columnFilter, string valueFilter, bool likeFilter)
        {
            try
            {
                //Filter Data
                if (!likeFilter)
                {
                    var query = TData.AsEnumerable()
                      .Where
                       (
                       fields =>
                       fields.Field<string>(columnFilter) == valueFilter
                       )
                       .OrderBy(fields => fields.Field<string>(columnFilter));
                    // If have Reocrd
                    if (query.GetEnumerator().MoveNext())
                    {
                        // Set DataTable from Linq
                        return query.CopyToDataTable();
                    }
                    else 
                    {
                        return TData.Clone();
                    }

                }
                //Filter Data with Like
                else
                {
                    var query = TData.AsEnumerable()
                   .Where
                    (
                    fields =>
                    fields.Field<string>(columnFilter).Contains(valueFilter)
                    )
                    .OrderBy(fields => fields.Field<string>(columnFilter));
                    // If have Reocrd
                    if (query.GetEnumerator().MoveNext())
                    {
                        // Set DataTable from Linq
                        return query.CopyToDataTable();
                    }
                    else
                    {
                        return TData.Clone();
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public static decimal isNullZero(object values)
        {
            if (string.IsNullOrEmpty(values.ToString()))
            {
                return 0;
            }

            return Convert.ToDecimal(values);
        }

        public static float ToAmountFloat(string currencyAmount)
        {
            if (string.IsNullOrEmpty(currencyAmount))
            {
                currencyAmount = "0";
            }
            string amount = currencyAmount.Trim(new char[] { ',', '$', ' ', ';' });
            if (amount == "")
            {
                amount = "0";
            }
            return Convert.ToSingle(amount);

        }

        public static decimal ToAmountDecimal(string currencyAmount)
        {
            if (string.IsNullOrEmpty(currencyAmount))
            {
                currencyAmount = "0";
            }
            string amount = currencyAmount.Trim(new char[] { ',', '$', ' ', ';' });
            if (amount == "")
            {
                amount = "0";
            }
            return Convert.ToDecimal(amount);

        }



        public static string ToCurrency(string currencyAmount)
        {
            if (string.IsNullOrEmpty(currencyAmount))
            {
                currencyAmount = "0";
            }
            string amount = currencyAmount.Trim(new char[] { ',', '$', ' ', ';' });
            if (amount == "")
            {
                amount = "0";
            }
            return Convert.ToDecimal(amount).ToString("C2");

        }

        public static string FormatPhoneNumber(string phoneNumber)
        {
            string number = Regex.Replace(phoneNumber, @"\s+", "");
            //If index start with zero Remove
            if (number.StartsWith("0"))
            {
                return number.Remove(0, 1);
            }
            return number;
        }


        public static object FormatValue(object Values)
        {
            if (Values.ToString() == "-")
            {
                return Values;
            }

            return Convert.ToDecimal(Values);
        }

        public static string SubText(string TextValue, string TextStart, string TextEnd)
        {
            int Start, End;
            if (TextValue.Contains(TextStart) && TextValue.Contains(TextEnd))
            {
                Start = TextValue.IndexOf(TextStart, 0) + TextStart.Length;
                End = TextValue.IndexOf(TextEnd, Start);

                return TextValue.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        public static string SubText(string TextValue, string TextStart)
        {
            int Start, End;
            if (TextValue.Contains(TextStart))
            {
                Start = TextValue.IndexOf(TextStart, 0) + TextStart.Length;
                End = TextValue.Length;

                return TextValue.Substring(Start, End - Start);
            }
            else
            {
                return "N/A";
            }
        }

        public static string SubText(string TextValue, int StartIndex, string TextEnd)
        {
            int Start, End;
            if (TextValue.Contains(TextEnd))
            {
                Start = TextValue.IndexOf(TextEnd, 0) + TextEnd.Length;
                End = TextValue.Length;

                return TextValue.Substring(StartIndex, End - Start);
            }
            else
            {
                return "N/A";
            }
        }

        public static string[] SubAddress(string TextValue)
        {
            if (TextValue.Contains("ST"))
            {
                string[] Address = TextValue.Split(new string[] { "ST" }, StringSplitOptions.RemoveEmptyEntries);
                return Address;
            }
            else
            {
                string[] Address = { "N/A", "N/A" };
                return Address;
            }

        }


        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^0([1-9]\d{1}\d{6}$)|^0([1-9]\d{1}\d{7}$)").Success;
        }


        public static string SMSLateInformation(string HouseNo, string Street, string DueDate, int OverDay, string TPay, string Penalty, string TTDue)
        {
            string SMSInformation = "";
            if (OverDay < 6)
            {
                SMSInformation = "សូមអធ្យាស្រ័យការបង់រំលោះផ្ទះលេខ " + HouseNo + "ផ្លូវ" + Street + "ដែលត្រូវបង់ថ្ងៃ " + DueDate + " បើហួសពី5ថ្ងៃត្រូវពិន័យ 5%. សូមអរគុណ                                                                ";
            }
            else
            {
                SMSInformation = "សូមអធ្យាស្រ័យការបង់រំលោះផ្ទះលេខ " + HouseNo + "ផ្លូវ" + Street + "ដែលត្រូវបង់ថ្ងៃ " + DueDate + " បានយឺត " + OverDay + "ថ្ងៃ ប្រាក់ត្រូវបង់" + TPay + "+ពិន័យ" + Penalty + "=" + TTDue + ". សូមអរគុណ                                                                ";

            }

            return SMSInformation;
        }

        public static void BindingData(System.Windows.Forms.Control[] ControllList, System.Data.DataSet dataSetName, string[] columList)
        {
            Control control = null;
            string column = null;
            for (int i = 0; i < ControllList.Length; i++)
            {
                control = ControllList[i];
                column = columList[i];
                if (control is TextBox)
                {
                    control.DataBindings.Add("Text", dataSetName, column, true, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                    control.DataBindings.Add("Value", dataSetName, column, true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }

        }

        public static string GenerateAutoID(string Pefix, int IDNumber)
        {
            return Pefix + (IDNumber + 1).ToString("D2");
        }



    }

}