using System;
using System.Configuration;

namespace DBUtility
{
    /// <summary>
    /// 公共常量
    /// </summary>
    public class PubConstant
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                return _connectionString;
            }
        }
    }
}
