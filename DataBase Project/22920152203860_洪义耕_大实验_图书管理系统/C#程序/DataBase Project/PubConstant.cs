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
    }
}
