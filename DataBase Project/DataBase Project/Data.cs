using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBase_Project
{
    public enum loginStatus { Reader, Admin, Unlogin };
    class Data
    {
        public static loginStatus identity = loginStatus.Unlogin;
        public static string currentAccount = "";
        public static string currentPasswd = "";
        public static SqlConnection currentConnection = new SqlConnection();
    }
}
