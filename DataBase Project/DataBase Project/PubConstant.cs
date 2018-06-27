using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBase_Project
{
    /// <summary>
    /// 公共常量
    /// </summary>
    public class PubConstant
    {
        public enum loginStatus { Reader, Admin, Unlogin };
        public static loginStatus identity = loginStatus.Unlogin;
        public static string currentAccount = "";
        public static string currentPasswd = "";
        public static SqlConnection currentConnection = new SqlConnection();

        //只能输入数字的事件
        public static void numberInputOnly(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
